using System;
using System.Collections.Generic;
using System.IO;

namespace RoboLasInstaller
{
    internal static class PackageInstallPlan
    {
        internal sealed class FileEntry
        {
            internal readonly PackageArchive.Entry Source;
            internal readonly string Destination;
            internal string Staged;
            internal string Backup;
            internal bool Committed;
            internal bool HadOriginal;
            internal FileEntry(PackageArchive.Entry source, string destination)
            {
                Source = source;
                Destination = destination;
            }
        }

        internal static List<FileEntry> Create(PackageArchive archive, string topomaticPath, string appDataPath)
        {
            List<FileEntry> files = new List<FileEntry>();
            HashSet<string> destinations = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            bool hasAssembly = false;
            bool hasManifest = false;
            foreach (PackageArchive.Entry entry in archive.Entries)
            {
                string path = entry.Name.Replace('\\', '/');
                bool directory = path.EndsWith("/", StringComparison.Ordinal);
                if (directory) path = path.Substring(0, path.Length - 1);
                if (!directory && path == "package.json") continue;
                if (directory && (path == "bin" || path == "plugins" || path == "icons" || path == "files")) continue;
                string root;
                string relative;
                if (path.StartsWith("bin/", StringComparison.Ordinal))
                {
                    root = topomaticPath; relative = path.Substring(4);
                }
                else if (path.StartsWith("plugins/", StringComparison.Ordinal))
                {
                    root = topomaticPath; relative = path.Substring(8);
                }
                else if (path.StartsWith("icons/", StringComparison.Ordinal))
                {
                    root = Path.Combine(topomaticPath, "icons"); relative = path.Substring(6);
                }
                else if (path.StartsWith("files/", StringComparison.Ordinal))
                {
                    root = appDataPath; relative = path.Substring(6);
                }
                else throw new InvalidDataException("Unexpected package entry: " + entry.Name);
                string destination = ResolveDestination(root, relative);
                EnsureNoReparsePoint(destination);
                if (directory) continue;
                if (!destinations.Add(destination))
                    throw new InvalidDataException("Duplicate package destination: " + entry.Name);
                if (path == "bin/LAS_TERRAIN.dll") hasAssembly = true;
                if (path == "plugins/LAS_TERRAIN.plugin") hasManifest = true;
                files.Add(new FileEntry(entry, destination));
            }
            if (!hasAssembly || !hasManifest)
                throw new InvalidDataException("Package is missing the RoboLas assembly or plugin manifest.");
            foreach (FileEntry file in files)
            {
                string parent = Path.GetDirectoryName(file.Destination);
                while (parent != null)
                {
                    if (destinations.Contains(parent))
                        throw new InvalidDataException("Package file is also a directory: " + parent);
                    parent = Path.GetDirectoryName(parent);
                }
            }
            return files;
        }

        internal static void Extract(PackageArchive archive, string topomaticPath, string appDataPath,
            Action<int, string> progress)
        {
            List<FileEntry> files = Create(archive, topomaticPath, appDataPath);
            archive.ValidateAll();
            string ticket = Guid.NewGuid().ToString("N");
            bool committed = false;
            try
            {
                // Stage every file on its destination volume. A corrupt archive
                // and a staging failure cannot replace an installed file.
                foreach (FileEntry file in files)
                {
                    EnsureNoReparsePoint(file.Destination);
                    Directory.CreateDirectory(Path.GetDirectoryName(file.Destination));
                    EnsureNoReparsePoint(file.Destination);
                    file.Staged = file.Destination + ".robolas-" + ticket + ".tmp";
                    file.Backup = file.Destination + ".robolas-" + ticket + ".bak";
                    archive.ExtractValidated(file.Source, file.Staged);
                }
                for (int i = 0; i < files.Count; i++)
                {
                    FileEntry file = files[i];
                    EnsureNoReparsePoint(file.Destination);
                    file.HadOriginal = File.Exists(file.Destination);
                    if (file.HadOriginal)
                        File.Replace(file.Staged, file.Destination, file.Backup);
                    else
                        File.Move(file.Staged, file.Destination);
                    file.Committed = true;
                    if (progress != null) progress((int)((i + 1.0) / files.Count * 100), file.Source.Name);
                }
                committed = true;
            }
            catch (Exception original)
            {
                Exception rollbackFailure = null;
                for (int i = files.Count - 1; i >= 0; i--)
                {
                    FileEntry file = files[i];
                    try
                    {
                        if (file.Backup != null && File.Exists(file.Backup))
                        {
                            EnsureNoReparsePoint(file.Destination);
                            if (File.Exists(file.Destination)) File.Replace(file.Backup, file.Destination, null);
                            else File.Move(file.Backup, file.Destination);
                        }
                        else if (file.Committed && !file.HadOriginal)
                        {
                            EnsureNoReparsePoint(file.Destination);
                            File.Delete(file.Destination);
                        }
                    }
                    catch (Exception ex) { rollbackFailure = ex; }
                }
                if (rollbackFailure != null)
                    throw new IOException("Installation failed and rollback needs attention: " + rollbackFailure.Message, original);
                throw;
            }
            finally
            {
                foreach (FileEntry file in files)
                {
                    try { if (file.Staged != null && File.Exists(file.Staged)) File.Delete(file.Staged); }
                    catch (IOException) { }
                    if (committed)
                    {
                        try { if (file.Backup != null && File.Exists(file.Backup)) File.Delete(file.Backup); }
                        catch (IOException) { }
                    }
                }
            }
        }

        internal static void Extract(PackageArchive archive, string topomaticPath, string appDataPath)
        {
            Extract(archive, topomaticPath, appDataPath, null);
        }

        private static string ResolveDestination(string root, string relativePath)
        {
            if (string.IsNullOrEmpty(relativePath) || Path.IsPathRooted(relativePath))
                throw new InvalidDataException("Invalid package entry path.");
            string[] parts = relativePath.Split('/');
            foreach (string part in parts)
            {
                if (part.Length == 0 || part == "." || part == ".." || part.IndexOf(':') >= 0 ||
                    part.EndsWith(" ", StringComparison.Ordinal) || part.EndsWith(".", StringComparison.Ordinal) ||
                    part.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0 || IsWindowsDeviceName(part))
                    throw new InvalidDataException("Package entry escapes its destination.");
            }
            string fullRoot = Path.GetFullPath(root);
            string destination = Path.GetFullPath(Path.Combine(fullRoot, string.Join(Path.DirectorySeparatorChar.ToString(), parts)));
            string rootPrefix = fullRoot.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal)
                ? fullRoot : fullRoot + Path.DirectorySeparatorChar;
            if (!destination.StartsWith(rootPrefix, StringComparison.OrdinalIgnoreCase))
                throw new InvalidDataException("Package entry escapes its destination.");
            return destination;
        }

        private static bool IsWindowsDeviceName(string part)
        {
            string stem = part.Split('.')[0].ToUpperInvariant();
            if (stem == "CON" || stem == "PRN" || stem == "AUX" || stem == "NUL") return true;
            return stem.Length == 4 && (stem.StartsWith("COM", StringComparison.Ordinal) ||
                   stem.StartsWith("LPT", StringComparison.Ordinal)) && stem[3] >= '1' && stem[3] <= '9';
        }

        private static void EnsureNoReparsePoint(string destination)
        {
            string full = Path.GetFullPath(destination);
            string volumeRoot = Path.GetPathRoot(full);
            string current = volumeRoot;
            foreach (string part in full.Substring(volumeRoot.Length).Split(
                new char[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar }))
            {
                if (part.Length == 0) continue;
                current = Path.Combine(current, part);
                try
                {
                    if ((File.GetAttributes(current) & FileAttributes.ReparsePoint) != 0)
                        throw new InvalidDataException("Package destination uses a filesystem link: " + current);
                }
                catch (FileNotFoundException) { }
                catch (DirectoryNotFoundException) { }
            }
        }
    }
}
