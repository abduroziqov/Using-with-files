namespace Using_with_files
namespace Using_with_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] binFile = Directory.GetDirectories(@"C:\Users\abdur\OneDrive\Рабочий стол\PDP\3-module\Lesson_06\", "bin*");

                string line;

                }
            // Print the file paths to the console
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write content to the file
                writer.WriteLine("Hello, my name is Quvonchbek!");
                writer.WriteLine("This is a sample file.");
            }
            Console.WriteLine("File has been written.");
        }
    }
}