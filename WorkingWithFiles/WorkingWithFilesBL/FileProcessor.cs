using System;
using System.IO;

namespace WorkingWithFilesBL
{
    public class FileProcessor
    {
        public string InputFilePath { get; }
        private static readonly string _backupDirectoryName = "backup";
        private static readonly string _inProgressDirectoryName = "processing";
        private static readonly string _completeDirectoryName = "complete";
        public FileProcessor(string filePath)
        {
           
        InputFilePath = filePath;
        }
        public void Process()
        {
            Console.WriteLine($"Pradedu bylos apdorojima {InputFilePath}");
            if(!File.Exists(InputFilePath))
            {
                Console.WriteLine($"KLAIDA: byla {InputFilePath} neegzistuoja.");
                return;
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(InputFilePath);
            string rootDirectoryPath = directoryInfo.Parent.Parent.FullName;
            Console.WriteLine($"Sakninis katalogas yra {rootDirectoryPath}");
            string backupDirectoryPath = Path.Combine(rootDirectoryPath, _backupDirectoryName);
            //if(!Directory.Exists(backupDirectoryPath))
            //{
            //    Console.WriteLine($"Kuriamas {backupDirectoryPath}");
                  Directory.CreateDirectory(backupDirectoryPath);
            //}
            string inputFileName = Path.GetFileName(InputFilePath);
            string backupFilePath = Path.Combine(backupDirectoryPath, inputFileName);
            Console.WriteLine($"Kopijuoju{ InputFilePath} i { backupFilePath}");
            File.Copy(InputFilePath, backupFilePath);

            Directory.CreateDirectory(Path.Combine(rootDirectoryPath, _inProgressDirectoryName));
            string inProgressFilePath =
                Path.Combine(rootDirectoryPath, _inProgressDirectoryName, inputFileName);
            if(File.Exists(inProgressFilePath))
            {
                Console.WriteLine($"KLAIDA: byla {inProgressFilePath} jau apdorota.");
                return;
            }
            Console.WriteLine($"Perkeliu {InputFilePath} i {inProgressFilePath}");
            File.Move(InputFilePath, inProgressFilePath);
            string extension = Path.GetExtension(InputFilePath);
            switch (extension)
            {
                case ".txt":
                    ProcessTextFile(inProgressFilePath);
                    break;
                default:
                    Console.WriteLine($"Nepalaikomas bylos tipas {extension}");
                    break;
            }
            string completeDirectoryPath = Path.Combine(rootDirectoryPath, _completeDirectoryName);
            Directory.CreateDirectory(completeDirectoryPath);

            Console.WriteLine($"Perkelimas {inProgressFilePath} i {completeDirectoryPath}");
            var completeFileName = string.Format(
                "{0}-{1}{2}",
                Path.GetFileNameWithoutExtension(InputFilePath), Guid.NewGuid(), extension);
            var completedFilePath = Path.Combine(completeDirectoryPath, completeFileName);
            File.Move(inProgressFilePath, completedFilePath);

            string inProgressDiectoryPath = Path.GetDirectoryName(inProgressFilePath);
            Directory.Delete(inProgressFilePath, true);

        }
        private void ProcessTextFile (string inProgressFilePath)
        {
            Console.WriteLine($"Apdorojama byla {inProgressFilePath}");
        }
    }
}
