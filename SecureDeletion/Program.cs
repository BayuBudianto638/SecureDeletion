using System;
using System.IO;
using System.Security;

namespace SecureFileDeletion
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                using (FileStream stream = File.OpenWrite("C:\\Users\\user\\Pictures\\KTP.png"))
                {
                    byte[] randomData = new byte[stream.Length];
                    Random random = new Random();
                    random.NextBytes(randomData);
                    stream.Write(randomData, 0, randomData.Length);
                }
            }

            if (File.Exists(insecureFilePath))
            {
                File.Delete(insecureFilePath);
                Console.WriteLine("File deleted securely.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            // Clear the secure string
            filePath.Clear();
        }
    }
}