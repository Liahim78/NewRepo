using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForPlarium.Models
{
    class TreeDirectory
    {
        private Directory value;

        public Directory Value
        {
            get { return value; }
            set { this.value = value; }
        }

        private List<TreeDirectory> directories;

        public List<TreeDirectory> Directories
        {
            get { return directories; }
            set { directories = value; }
        }

        private List<File> files;

        public List<File> Files
        {
            get { return files; }
            set { files = value; }
        }
        public TreeDirectory(Directory value)
        {
            this.value = value;

        }
        public void AddDirectory(Directory value)
        {
            Directories.Add(new TreeDirectory(value));
        }

        public void AddListDirectory(List<Directory> listValue)
        {
            foreach (var item in listValue)
            {
                Directories.Add(new TreeDirectory(item));
            }
        }

        public void AddFile(File item)
        {
            Files.Add(item);
        }
    }
}
