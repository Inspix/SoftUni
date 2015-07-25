using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TraverseandSaveDirectoryContentsinaTree
{
    class Program
    {

        static void Main(string[] args)
        {
            Tree<Folder> root = new Tree<Folder>(new Folder(@"C:\Program Files\"));

            Traverse(@"C:\Program Files\", root);

            var node = root.FindSubTree(new Folder("Java"));
            Console.WriteLine(node.Value.Name);
            CalculateSumOfFileSizes(node);

            node = root.FindSubTree(new Folder("TortoiseGit"));
            Console.WriteLine(node.Value.Name);
            CalculateSumOfFileSizes(node);
        }

        static void CalculateSumOfFileSizes(Tree<Folder> node)
        {
            long sum = 0;
            Stack<Tree<Folder>> subfolders = new Stack<Tree<Folder>>();
            foreach (var subfolder in node.Children)
            {
                subfolders.Push(subfolder);
            }
            while(subfolders.Count > 0)
            {
                var folder = subfolders.Pop();
                foreach (var child in folder.Children)
                {
                    subfolders.Push(child);
                }
                foreach (var file in folder.Value.Files)
                {
                    sum += file.Size;
                }
            }
            Console.WriteLine(sum);
        }


        static void Traverse(string startingDirectory, Tree<Folder> root)
        {
            var dirs = new DirectoryInfo(startingDirectory).GetDirectories();

            foreach (var dir in dirs)
            {
                var childNode = new Tree<Folder>(new Folder(dir.Name));
                var files = dir.GetFiles();
                foreach (var file in files)
                {
                    childNode.Value.AddFile(new File(file.Name, (int)file.Length));
                }
                root.AddChild(childNode);
                Traverse(dir.FullName, childNode);
            }
        }
    }
}
