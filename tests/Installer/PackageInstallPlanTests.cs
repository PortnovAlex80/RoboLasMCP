using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using RoboLasInstaller;

internal static class PackageInstallPlanTests
{
    private sealed class Item
    {
        internal string Name;
        internal string Body;
        internal Item(string name, string body) { Name = name; Body = body; }
    }

    private static int assertions;
    private static void Check(bool value, string message)
    {
        assertions++;
        if (!value) throw new Exception(message);
    }

    private static uint Crc(byte[] data)
    {
        uint crc = 0xffffffff;
        foreach (byte value in data)
        {
            crc ^= value;
            for (int bit = 0; bit < 8; bit++)
                crc = (crc >> 1) ^ ((crc & 1) != 0 ? 0xedb88320u : 0u);
        }
        return crc ^ 0xffffffff;
    }

    private static byte[] Archive(params Item[] items)
    {
        MemoryStream memory = new MemoryStream();
        BinaryWriter writer = new BinaryWriter(memory);
        List<int> offsets = new List<int>();
        foreach (Item item in items)
        {
            byte[] name = Encoding.ASCII.GetBytes(item.Name);
            byte[] body = Encoding.UTF8.GetBytes(item.Body);
            offsets.Add((int)memory.Position);
            writer.Write(0x04034b50u);
            writer.Write((ushort)20); writer.Write((ushort)0); writer.Write((ushort)0);
            writer.Write((ushort)0); writer.Write((ushort)0);
            writer.Write(Crc(body)); writer.Write((uint)body.Length); writer.Write((uint)body.Length);
            writer.Write((ushort)name.Length); writer.Write((ushort)0);
            writer.Write(name); writer.Write(body);
        }
        int central = (int)memory.Position;
        for (int i = 0; i < items.Length; i++)
        {
            byte[] name = Encoding.ASCII.GetBytes(items[i].Name);
            byte[] body = Encoding.UTF8.GetBytes(items[i].Body);
            writer.Write(0x02014b50u);
            writer.Write((ushort)20); writer.Write((ushort)20);
            writer.Write((ushort)0); writer.Write((ushort)0);
            writer.Write((ushort)0); writer.Write((ushort)0);
            writer.Write(Crc(body)); writer.Write((uint)body.Length); writer.Write((uint)body.Length);
            writer.Write((ushort)name.Length); writer.Write((ushort)0); writer.Write((ushort)0);
            writer.Write((ushort)0); writer.Write((ushort)0); writer.Write((uint)0);
            writer.Write((uint)offsets[i]); writer.Write(name);
        }
        int centralSize = (int)memory.Position - central;
        writer.Write(0x06054b50u);
        writer.Write((ushort)0); writer.Write((ushort)0);
        writer.Write((ushort)items.Length); writer.Write((ushort)items.Length);
        writer.Write((uint)centralSize); writer.Write((uint)central); writer.Write((ushort)0);
        writer.Flush();
        return memory.ToArray();
    }

    private static Item Dll() { return new Item("bin/LAS_TERRAIN.dll", "replacement"); }
    private static Item Manifest() { return new Item("plugins/LAS_TERRAIN.plugin", "manifest"); }

    private static void RejectsWithoutWriting(string basePath, string existing, string label, byte[] archive)
    {
        string package = Path.Combine(basePath, label + ".tpm");
        File.WriteAllBytes(package, archive);
        bool rejected = false;
        try
        {
            using (PackageArchive zip = new PackageArchive(package))
                PackageInstallPlan.Extract(zip, Path.GetDirectoryName(existing), Path.Combine(basePath, "appdata"));
        }
        catch (InvalidDataException) { rejected = true; }
        Check(rejected, label + " archive accepted");
        Check(File.ReadAllText(existing) == "original", label + " changed existing DLL");
    }

    public static int Main(string[] args)
    {
        if (args.Length != 2) throw new ArgumentException("Pass a fresh test directory and a release .tpm path");
        string basePath = Path.GetFullPath(args[0]);
        Directory.CreateDirectory(basePath);
        string root = Path.Combine(basePath, "host");
        Directory.CreateDirectory(root);
        string existing = Path.Combine(root, "LAS_TERRAIN.dll");
        File.WriteAllText(existing, "original");

        byte[] valid = Archive(new Item("package.json", "{}"), Dll(), Manifest(),
            new Item("icons/example.png", "icon"));
        string validPackage = Path.Combine(basePath, "valid.tpm");
        File.WriteAllBytes(validPackage, valid);
        using (PackageArchive zip = new PackageArchive(validPackage))
        {
            List<PackageInstallPlan.FileEntry> plan = PackageInstallPlan.Create(zip,
                Path.GetPathRoot(basePath), Path.Combine(basePath, "appdata"));
            Check(plan[0].Destination == Path.Combine(Path.GetPathRoot(basePath), "LAS_TERRAIN.dll"),
                "Volume root became drive-relative");
            PackageInstallPlan.Extract(zip, root, Path.Combine(basePath, "appdata"));
        }
        Check(File.ReadAllText(existing) == "replacement", "Valid DLL missing");
        Check(File.ReadAllText(Path.Combine(Path.Combine(root, "icons"), "example.png")) == "icon", "Valid icon missing");
        File.WriteAllText(existing, "original");

        RejectsWithoutWriting(basePath, existing, "traversal-dot", Archive(Dll(), Manifest(), new Item("bin/./probe", "bad")));
        RejectsWithoutWriting(basePath, existing, "traversal-parent", Archive(Dll(), Manifest(), new Item("bin/../probe", "bad")));
        RejectsWithoutWriting(basePath, existing, "duplicate-destination", Archive(Dll(), Manifest(), new Item("plugins/LAS_TERRAIN.dll", "bad")));
        RejectsWithoutWriting(basePath, existing, "missing-dll", Archive(Manifest()));
        RejectsWithoutWriting(basePath, existing, "device", Archive(Dll(), Manifest(), new Item("icons/CON.txt", "bad")));
        RejectsWithoutWriting(basePath, existing, "file-parent", Archive(Dll(), Manifest(), new Item("icons/tree", "a"), new Item("icons/tree/child", "b")));
        byte[] corruptCrc = (byte[])valid.Clone();
        // Last central entry is an icon; corruption must be found before replacing the first DLL.
        int iconHeader = FindSignature(corruptCrc, 0x02014b50u, 4);
        corruptCrc[iconHeader + 16] ^= 1;
        RejectsWithoutWriting(basePath, existing, "bad-crc", corruptCrc);
        byte[] truncated = new byte[valid.Length - 1];
        Array.Copy(valid, truncated, truncated.Length);
        RejectsWithoutWriting(basePath, existing, "truncated", truncated);
        byte[] encrypted = (byte[])valid.Clone();
        encrypted[6] = 1;
        RejectsWithoutWriting(basePath, existing, "encrypted", encrypted);
        byte[] descriptor = (byte[])valid.Clone();
        descriptor[6] = 8;
        RejectsWithoutWriting(basePath, existing, "descriptor", descriptor);
        byte[] centralMismatch = (byte[])valid.Clone();
        centralMismatch[FindSignature(centralMismatch, 0x02014b50u, 1) + 20] ^= 1;
        RejectsWithoutWriting(basePath, existing, "header-mismatch", centralMismatch);
        byte[] oversized = (byte[])valid.Clone();
        int dllCentral = FindSignature(oversized, 0x02014b50u, 2);
        oversized[dllCentral + 24] = 0xff;
        oversized[dllCentral + 25] = 0xff;
        oversized[dllCentral + 26] = 0xff;
        oversized[dllCentral + 27] = 0x7f;
        RejectsWithoutWriting(basePath, existing, "oversized", oversized);
        byte[] zip64 = (byte[])valid.Clone();
        int end = zip64.Length - 22;
        zip64[end + 12] = 0xff; zip64[end + 13] = 0xff;
        zip64[end + 14] = 0xff; zip64[end + 15] = 0xff;
        RejectsWithoutWriting(basePath, existing, "zip64", zip64);

        string rollbackRoot = Path.Combine(basePath, "rollback-host");
        Directory.CreateDirectory(rollbackRoot);
        string rollbackDll = Path.Combine(rollbackRoot, "LAS_TERRAIN.dll");
        File.WriteAllText(rollbackDll, "original");
        bool interrupted = false;
        try
        {
            using (PackageArchive zip = new PackageArchive(validPackage))
                PackageInstallPlan.Extract(zip, rollbackRoot, Path.Combine(basePath, "rollback-appdata"),
                    delegate(int percentage, string name)
                    {
                        if (name == "plugins/LAS_TERRAIN.plugin") throw new IOException("Injected failure after second commit");
                    });
        }
        catch (IOException) { interrupted = true; }
        Check(interrupted, "Injected commit failure was not observed");
        Check(File.ReadAllText(rollbackDll) == "original", "Rollback did not restore DLL");
        Check(!File.Exists(Path.Combine(rollbackRoot, "LAS_TERRAIN.plugin")), "Rollback left a new manifest");
        Check(Directory.GetFiles(rollbackRoot, "*.robolas-*").Length == 0, "Rollback left staging files");

        string lockedRoot = Path.Combine(basePath, "locked-host");
        Directory.CreateDirectory(lockedRoot);
        string lockedDll = Path.Combine(lockedRoot, "LAS_TERRAIN.dll");
        string lockedManifest = Path.Combine(lockedRoot, "LAS_TERRAIN.plugin");
        File.WriteAllText(lockedDll, "original");
        File.WriteAllText(lockedManifest, "locked");
        bool lockFailure = false;
        using (FileStream lockHandle = new FileStream(lockedManifest, FileMode.Open, FileAccess.Read, FileShare.None))
        {
            try
            {
                using (PackageArchive zip = new PackageArchive(validPackage))
                    PackageInstallPlan.Extract(zip, lockedRoot, Path.Combine(basePath, "locked-appdata"));
            }
            catch (IOException) { lockFailure = true; }
        }
        Check(lockFailure, "Locked destination did not stop commit");
        Check(File.ReadAllText(lockedDll) == "original", "I/O rollback did not restore DLL");
        Check(File.ReadAllText(lockedManifest) == "locked", "I/O rollback changed locked manifest");

        string junctionRoot = Path.Combine(basePath, "junction-host");
        string outside = Path.Combine(basePath, "junction-outside");
        Directory.CreateDirectory(junctionRoot);
        Directory.CreateDirectory(outside);
        string junction = Path.Combine(junctionRoot, "icons");
        ProcessStartInfo linkInfo = new ProcessStartInfo("cmd.exe", "/c mklink /J \"" + junction + "\" \"" + outside + "\"");
        linkInfo.UseShellExecute = false;
        linkInfo.CreateNoWindow = true;
        using (Process link = Process.Start(linkInfo))
        {
            link.WaitForExit();
            Check(link.ExitCode == 0, "Junction fixture creation failed");
        }
        string junctionDll = Path.Combine(junctionRoot, "LAS_TERRAIN.dll");
        File.WriteAllText(junctionDll, "original");
        string junctionArchive = Path.Combine(basePath, "junction.tpm");
        File.WriteAllBytes(junctionArchive, valid);
        bool junctionRejected = false;
        try
        {
            using (PackageArchive zip = new PackageArchive(junctionArchive))
                PackageInstallPlan.Extract(zip, junctionRoot, Path.Combine(basePath, "junction-appdata"));
        }
        catch (InvalidDataException) { junctionRejected = true; }
        Check(junctionRejected, "Junction destination accepted");
        Check(File.ReadAllText(junctionDll) == "original", "Junction rejection changed DLL");
        Check(!File.Exists(Path.Combine(outside, "example.png")), "Junction escape wrote outside root");

        // Real release package verifies the Deflate path and complete layout.
        using (PackageArchive package = new PackageArchive(args[1]))
        {
            string releaseRoot = Path.Combine(basePath, "release-host");
            string releaseApp = Path.Combine(basePath, "release-appdata");
            List<PackageInstallPlan.FileEntry> plan = PackageInstallPlan.Create(package,
                releaseRoot, releaseApp);
            Check(plan.Count == 76, "Release package layout changed");
            package.ValidateAll();
            PackageInstallPlan.Extract(package, releaseRoot, releaseApp);
            foreach (PackageInstallPlan.FileEntry file in plan)
                Check(File.Exists(file.Destination) && new FileInfo(file.Destination).Length == file.Source.Size,
                    "Real package extraction differs: " + file.Source.Name);
        }
        Check(Environment.Version.Major == 2, "Test executable did not run on CLR 2");
        Console.WriteLine("PASS PackageInstallPlanTests: " + assertions + " assertions; CLR " + Environment.Version);
        return 0;
    }

    private static int FindSignature(byte[] bytes, uint signature, int index)
    {
        for (int i = 0; i <= bytes.Length - 4; i++)
        {
            if (BitConverter.ToUInt32(bytes, i) == signature && --index == 0) return i;
        }
        throw new Exception("Central header fixture missing");
    }
}
