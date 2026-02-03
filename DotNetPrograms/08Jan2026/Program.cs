using System;
class Program
{
    static void Main()
    {
        // string path = "data.txt";
        // File.WriteAllText(path, "File I/O Example in C#");
        // File.WriteAllText(path, "Files I/O Example in C#");
        // Console.WriteLine("Data written to file");
        // string content = File.ReadAllText("data.txt");
        // Console.WriteLine("File content:");
        // Console.WriteLine(content);
        //======================================================================//
        // using (StreamWriter writer = new StreamWriter("log.txt"))
        // {
        //     writer.WriteLine("Application Started");
        //     writer.WriteLine("Processing Data");
        //     writer.WriteLine("Application Ended");
        // }
        // using (StreamReader reader = new StreamReader("log.txt"))
        // {
        //     string line;
        //     while ((line = reader.ReadLine()) != null)
        //     {
        //         Console.WriteLine(line);
        //     }
        // }
        //========================================================================//
        // User user = new User {Id = 1, Name = "Alice"};
        // using (StreamWriter writer = new StreamWriter("user.txt"))
        // {
        //     writer.WriteLine(user.Id);
        //     writer.WriteLine(user.Name);
        //     user.Id = 2;
        //     user.Name = "Bob";
        //     writer.WriteLine(user.Id);
        //     writer.WriteLine(user.Name);
        // }
        // Console.WriteLine("User data saved");
        //=========================================================================//
        // User user = new User();
        // using (StreamReader reader = new StreamReader("user.txt"))
        // {
        //     user.Id = int.Parse(reader.ReadLine());
        //     user.Name = reader.ReadLine();
        // }
        // Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");
        //==========================================================================//
        User user = new User {Id = 2, Name = "Bob"};
        using (BinaryWriter writer = new BinaryWriter(File.Open("user.bin", FileMode.Create)))
        {
            writer.Write(user.Id);
            writer.Write(user.Name);
        }
        Console.WriteLine("Binary user saved");
        using (BinaryReader reader = new BinaryReader(File.Open("user.bin", FileMode.Open)))
        {
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadString());
        }
    }
}
