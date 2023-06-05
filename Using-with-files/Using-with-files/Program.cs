namespace Using_with_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Give file location
            string filePath = @"C:\Users\abdur\OneDrive\Рабочий стол\PDP\3-module\Lesson_06\test.txt";

            // Create a new instance of StreamReader and pass the file path
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                // Read the file line by line until the end of the file is reached
                while ((line = reader.ReadLine()) != null)
                {
                    // Process the line as needed
                    Console.WriteLine(line);
                }
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