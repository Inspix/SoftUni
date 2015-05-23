using System.IO;

namespace _04.CopyBinnaryFile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FileStream stream = new FileStream("file.mp3", FileMode.Open);
            FileStream writer = new FileStream("../newFile.mp3", FileMode.Create);
            byte[] buffer = new byte[4096];
            
            using (stream)
            {
                int position = 0;

                using (writer)
                {
                    while (true)
                    {
                        int bytes = stream.Read(buffer, 0, buffer.Length);
                        if (bytes == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, bytes);
                        position += bytes;
                    }
                }
            }
        }
    }
}
