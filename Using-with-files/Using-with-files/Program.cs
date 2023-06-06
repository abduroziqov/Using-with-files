using System.IO;
using System.Diagnostics;
namespace Using_with_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            string filter = "*.exe";
            string[] files = Directory.GetFiles(folder, filter);
            foreach (var file in files)
            {
                Console.WriteLine($"Name of file: {file}");
            }
        }
    }
}