using System.Collections.Generic;

namespace Problem_03
{
    public class Folder
    {
        public Folder(string name, int filesCount, int foldersCount)
        {
            this.Name = name;
            this.Files = new File[filesCount];
            this.ChildFolders = new Folder[foldersCount];
        }

        public Folder(string name)
            : this(name, 0, 0)
        {
            
        }


        public string Name { get; set; }

        public Folder[] ChildFolders { get; set; }

        public File[] Files { get; set; }
    }
}
