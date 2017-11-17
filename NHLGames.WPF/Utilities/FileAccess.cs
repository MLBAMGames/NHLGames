using System;
using System.Collections.Generic;
using System.IO;

namespace NHLGames.WPF.Utilities
{
    public class FileAccess
    {
        /// <summary>
        /// DirectoryInfo.GetFiles can cause AuthorizationException Errors, hence this function
        /// </summary>
        /// <param name="root">Root folder to search (eg. "C:\Program Files")</param>
        /// <param name="searchPattern">Pattern to search for (eg. "vlc.exe" or "*.exe")</param>
        /// <returns>List of paths</returns>
        public static List<string> GetFiles(string root, string searchPattern)
        {
            List<string> result = new List<string>();

            Stack<string> pending = new Stack<string>();
            pending.Push(root);

            while (pending.Count != 0)
            {
                dynamic path = pending.Pop();
                string[] nextDir = null;
                try
                {
                    nextDir = Directory.GetFiles(path, searchPattern);
                }
                catch
                {
                }
                if (nextDir != null && nextDir.Length != 0)
                {
                    result.AddRange(nextDir);
                }
                try
                {
                    nextDir = Directory.GetDirectories(path);
                    foreach (string subdir in nextDir)
                    {
                        pending.Push(subdir);
                    }
                }
                catch
                {
                }
            }

            return result;
        }


        public static bool IsFileReadonly(string path)
        {

            FileAttributes attributes = File.GetAttributes(path);
            return (attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;

        }



        public static void RemoveReadOnly(string path)
        {
            FileAttributes attributes = File.GetAttributes(path);

            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                // Make the file RW
                attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
                File.SetAttributes(path, attributes);
                Console.WriteLine(Properties.Resources.msgRemoveReadOnly, path);
            }

        }

        public static void AddReadonly(string path)
        {
            File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.ReadOnly);
            Console.WriteLine(Properties.Resources.msgAddReadOnly, path);
        }

        public static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        public static bool HasAccess(string filePath, bool createIt = true, bool reportException = false)
        {
            try
            {
                if (createIt)
                    File.WriteAllText(filePath, Properties.Resources.msgTestTxtContent);

                using (StreamReader inputstreamreader = new StreamReader(filePath))
                {
                    inputstreamreader.Close();
                }
                using (FileStream inputStream = File.Open(filePath, FileMode.Open, System.IO.FileAccess.ReadWrite, FileShare.None))
                {
                    inputStream.Close();
                }

                if (createIt)
                    File.Delete(filePath);
                return true;
            }
            catch (Exception ex)
            {
                if (reportException)
                {
                    Console.WriteLine(Properties.Resources.errorGeneral, ex.Message);
                }
                return false;
            }
        }

    }
}
