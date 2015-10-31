using System;
using System.IO;

namespace Problem_03
{
    /*
    Define classes File { string name, int size } and Folder { string name, File[] files, Folder[] childFolders } 
    and using them build a tree keeping all files and folders on the hard drive starting from C:\WINDOWS. 
    Implement a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly.
    Use recursive DFS traversal.
    */
    public class StartUp
    {
        public static void Main()
        {
            const string rootFolder = @"C:\Windows";
            Console.WriteLine("Building Folder tree...");
            var root = BuildDirectoryTree(rootFolder);
            Console.WriteLine("Folder tree build");

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(
                        @"Enter sub folder path in C:\Windows(example type \Fonts or push Enter for root folder C:\Windows) or type exit to quit: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    var subFolderPath = Console.ReadLine();
                    if (subFolderPath == "exit")
                    {
                        break;
                    }

                    var folderPath = rootFolder + subFolderPath;
                    var subFolderTree = GetSubTree(root, folderPath);
                    var fileSizeInBites = GetFileSizeInFolderTree(subFolderTree);

                    Console.WriteLine("{0} folder size in bytes is {1} or {2:0.00} GigaBytes", folderPath, fileSizeInBites, (decimal)fileSizeInBites / (1024 * 1024 * 1024));
                    Console.WriteLine(@"This does not include access denied folders! If you want full file size try starting the .exe from bin\debug with administrator rights");

                }
                catch (DirectoryNotFoundException e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }

        private static long GetFileSizeInFolderTree(Folder currentFolder)
        {
            var currentFileSize = 0L;
            foreach (var file in currentFolder.Files)
            {
                currentFileSize += file.Size;
            }

            foreach (var childFolder in currentFolder.ChildFolders)
            {
                currentFileSize += GetFileSizeInFolderTree(childFolder);
            }
            
            return currentFileSize;
        }

        private static Folder GetSubTree(Folder root, string folderName)
        {
            if (root.Name.ToLower() == folderName.ToLower())
            {
                return root;
            }

            var folderNameLength = folderName.Length;
            foreach (var child in root.ChildFolders)
            {
                if (child.Name.Length <= folderNameLength)
                {
                    var folderNameStart = folderName.Substring(0, child.Name.Length);
                    if (child.Name.ToLower() == folderNameStart.ToLower())
                    {
                        return GetSubTree(child, folderName);
                    }
                }
                
            }
            throw new DirectoryNotFoundException("Specified folder not found");
        }

        private static Folder BuildDirectoryTree(string rootFolder)
        {
            try
            {
                var childFolders = Directory.GetDirectories(rootFolder);
                var filesInFolder = Directory.GetFiles(rootFolder);
                var currentFolder = new Folder(rootFolder, filesInFolder.Length, childFolders.Length);

                for (int i = 0; i < childFolders.Length; i++)
                {
                    currentFolder.ChildFolders[i] = BuildDirectoryTree(childFolders[i]);
                }

                for (int i = 0; i < filesInFolder.Length; i++)
                {
                    var fileName = filesInFolder[i].Substring(rootFolder.Length + 1);
                    var fileInfo = new FileInfo(filesInFolder[i]);
                    currentFolder.Files[i] = new File(fileName, fileInfo.Length);
                }

                return currentFolder;
            }
            catch (UnauthorizedAccessException e)
            {

                Console.WriteLine(e.Message);
                return new Folder(e.Message);
            }
        }
    }
}
