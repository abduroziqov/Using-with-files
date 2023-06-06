using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = args[0]; // get the path from the first argument
        DeleteFolders(path, "bin"); // delete all the bin folders
        DeleteFolders(path, "obj"); // delete all the obj folders
    }

    static void DeleteFolders(string path, string name)
    {
        DirectoryInfo dir = new DirectoryInfo(path); // create a directory info object
        foreach (var subDir in dir.GetDirectories(name, SearchOption.AllDirectories)) // get all the subdirectories with the given name
        {
            subDir.Delete(true); // delete the subdirectory and its contents
        }
    }
}