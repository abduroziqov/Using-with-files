using System.IO;

namespace Using_with_files
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string file = @"C:\Users\abdur\OneDrive\Рабочий стол\PDP\3-module\Test-files\.gitignore1";

            if (File.Exists(file)) // checks file (is file have)
            {
                Console.WriteLine("This file is already available in this folder.");
            }
            else
            {
                File.Create(file);  // creates
                Console.WriteLine("File has been succesfully created.");
            }
        }
    }
}