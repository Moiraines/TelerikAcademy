namespace Problem_02
{
    using System;
    using System.IO;

    /*
    Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and to display 
    all files matching the mask *.exe. Use the class System.IO.Directory. 
    */
    public class StartUp
    {
        public static void Main()
        {

            const string rootFolder = @"C:\Windows";
            const string filesToSearch = @"*.exe";

            TraverseFolder(rootFolder, filesToSearch);
        }

        private static void TraverseFolder(string rootFolder, string filesToSearch)
        {
            try
            {
                var folders = Directory.EnumerateDirectories(rootFolder);

                foreach (var currentDirectory in folders)
                {
                    TraverseFolder(currentDirectory, filesToSearch);
                }
            }
            catch (UnauthorizedAccessException e)
            {

                Console.WriteLine(e.Message);
            }

            var files = Directory.EnumerateFiles(rootFolder, filesToSearch);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
