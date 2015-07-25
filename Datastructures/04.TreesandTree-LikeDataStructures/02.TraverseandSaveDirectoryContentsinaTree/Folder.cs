using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TraverseandSaveDirectoryContentsinaTree
{
    public class Folder : IEquatable<Folder>
    {
        public string Name { get; set; }
        public List<File> Files { get; private set; }

        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
        }
        
        public void AddFile(File file)
        {
            this.Files.Add(file);
        }
        public bool Equals(Folder other)
        {
            return this.Name == other.Name;
        }
    }
}
