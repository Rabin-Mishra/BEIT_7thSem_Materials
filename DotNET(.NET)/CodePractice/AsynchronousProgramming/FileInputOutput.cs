using System;
using System.IO;
using System.Threading.Tasks;

public class FileOperations
{
    // Method to read a file asynchronously
    public async Task<string> ReadFileAsync(string filepath)
    {
        using (StreamReader reader = new StreamReader(filepath))
        {
            return await reader.ReadToEndAsync();
        }
    }

    // Method to write content to a file asynchronously
    public async Task WriteFileAsync(string filepath, string content)
    {
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            await writer.WriteAsync(content);
        }
    }

    // Main method for entry point
    public static async Task Main(string[] args)
    {
        FileOperations fileOps = new FileOperations();

        // Write content to a file
        await fileOps.WriteFileAsync("example.txt", "Hello, this is an example file.");

        // Read content from the file
        string content = await fileOps.ReadFileAsync("example.txt");

        // Output the content
        Console.WriteLine("File content:");
        Console.WriteLine(content);
    }
}
