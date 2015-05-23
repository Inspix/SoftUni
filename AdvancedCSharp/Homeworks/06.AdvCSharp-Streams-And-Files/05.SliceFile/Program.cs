﻿using System.Collections.Generic;
using System.IO;

namespace _05.SliceFile
{
    class Program
    {
        static List<string> names = new List<string>(); 
        static void Main(string[] args)
        {
            Slice("bla.mp3", "../dir/", 5);
            Assemble(names, "newBla.mp3", "../Test/");
        }

        static void Slice(string filename, string destinationDir, int parts)
        {
            
            byte[] buffer = new byte[4096];

            string name = filename.Substring(0, filename.LastIndexOf('.'));
            string extension = filename.Substring(filename.LastIndexOf('.'));

            Directory.CreateDirectory(destinationDir);
           
            using (FileStream reader = new FileStream(filename,FileMode.Open))
            {
                long size = reader.Length/parts;
                for (int i = 1; i <= parts; i++)
                {
                    if (i == parts)
                    {
                        size = reader.Length;
                    }
                    using (FileStream writer = new FileStream(destinationDir + name + "-Part-" + i + extension, FileMode.Create))
                    {
                        int newSize = 0;
                        int difference = 0;
                        while (true)
                        {
                            if (newSize + 4096 > size)
                            {
                                difference =  newSize + 4096 - (int)size;
                            }
                            if (newSize == size)
                            {
                                break;
                            }
                            int bytes = reader.Read(buffer, 0, buffer.Length - difference);
                            if (bytes == 0)
                            {
                                break;
                            }
                            writer.Write(buffer, 0, bytes);
                            newSize += buffer.Length - difference;
                        }
                    }
                    names.Add(name + "-Part-" + i + extension);
                }
            }
        }

        static void Assemble(List<string> file, string name,string destinationDir)
        {
            Directory.CreateDirectory(destinationDir);
            FileStream write = new FileStream(destinationDir + name, FileMode.Append);
            
            byte[] buffer = new byte[4096];
            using (write)
            {
                for (int i = 0; i < file.Count; i++)
                {
                    using (FileStream reader = new FileStream("../dir/"+file[i],FileMode.Open))
                    {
                        while (true)
                        {
                            int bytes = reader.Read(buffer, 0, buffer.Length);
                            if (bytes == 0)
                            {
                                break;
                            }
                            write.Write(buffer, 0, bytes);
                        }
                    }
                }
            }
        }
    }
}