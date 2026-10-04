using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LAS_TERRAIN.IO
{
    /// <summary>Crash-recoverable publication of two independently prepared LAS files.</summary>
    public static class LasPairPublication
    {
        private const string Version = "LASPAIR1";

        public static string JournalPath(string firstFinalPath)
        {
            return Path.GetFullPath(firstFinalPath) + ".las-pair-recovery";
        }

        public static void Publish(PreparedLasFile first, PreparedLasFile second)
        {
            if (first == null || second == null) throw new ArgumentNullException("prepared");
            string journal = JournalPath(first.FinalPath);
            if (File.Exists(journal))
                throw new IOException("Незавершённая публикация LAS: " + journal);

            string firstHash = Fingerprint(first.StagePath);
            string secondHash = Fingerprint(second.StagePath);
            string[] record = { Version,
                first.FinalPath, first.StagePath, first.ExpectedFinalFingerprint, firstHash,
                second.FinalPath, second.StagePath, second.ExpectedFinalFingerprint, secondHash };

            WriteJournal(journal, record);
            first.PreserveForRecovery();
            second.PreserveForRecovery();
            try
            {
                first.Publish();
                second.Publish();
                File.Delete(journal);
            }
            catch (Exception ex)
            {
                throw new IOException("Публикация LAS не завершена. Восстановление: " + journal, ex);
            }
        }

        /// <summary>Publish only unfinished stages; never rerun point collection or CAD mutations.</summary>
        public static void Recover(string firstFinalPath)
        {
            string journal = JournalPath(firstFinalPath);
            string[] record = ReadJournal(journal);
            RecoverOne(record[1], record[2], record[3], record[4]);
            if (Fingerprint(record[1]) != record[4])
                throw new IOException("Первый LAS был изменён после публикации: " + record[1]);
            RecoverOne(record[5], record[6], record[7], record[8]);
            if (Fingerprint(record[1]) != record[4])
                throw new IOException("Первый LAS был изменён во время восстановления: " + record[1]);
            File.Delete(journal);
        }

        private static void RecoverOne(string finalPath, string stagePath,
            string expectedFinal, string expectedPublished)
        {
            string current = Fingerprint(finalPath);
            if (current == expectedPublished) return;
            if (current != expectedFinal)
                throw new IOException("Конечный LAS изменён; восстановление остановлено: " + finalPath);
            if (Fingerprint(stagePath) != expectedPublished)
                throw new IOException("Подготовленный LAS отсутствует или повреждён: " + stagePath);
            using (PreparedLasFile prepared = PreparedLasFile.OpenForRecovery(
                finalPath, stagePath, expectedFinal))
            {
                prepared.PreserveForRecovery();
                prepared.Publish();
            }
        }

        private static void WriteJournal(string path, string[] record)
        {
            string temp = path + ".tmp-" + Guid.NewGuid().ToString("N");
            try
            {
                using (FileStream stream = new FileStream(temp, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine(record[0]);
                    for (int i = 1; i < record.Length; i++)
                        writer.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(record[i])));
                    writer.Flush();
                    stream.Flush();
                }
                if (File.Exists(path)) throw new IOException("Recovery journal already exists: " + path);
                File.Move(temp, path);
            }
            finally
            {
                if (File.Exists(temp)) File.Delete(temp);
            }
        }

        private static string[] ReadJournal(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            if (lines.Length != 9 || lines[0] != Version)
                throw new InvalidDataException("Unknown LAS recovery journal format: " + path);
            string[] record = new string[9];
            record[0] = Version;
            for (int i = 1; i < record.Length; i++)
                record[i] = Encoding.UTF8.GetString(Convert.FromBase64String(lines[i]));
            if (!String.Equals(JournalPath(record[1]), Path.GetFullPath(path), StringComparison.OrdinalIgnoreCase))
                throw new InvalidDataException("LAS recovery journal path mismatch: " + path);
            return record;
        }

        public static string Fingerprint(string path)
        {
            if (!File.Exists(path)) return "missing";
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (SHA256 hash = SHA256.Create())
            {
                byte[] bytes = hash.ComputeHash(stream);
                StringBuilder result = new StringBuilder("sha256:");
                foreach (byte value in bytes) result.Append(value.ToString("x2"));
                return result.ToString();
            }
        }
    }
}
