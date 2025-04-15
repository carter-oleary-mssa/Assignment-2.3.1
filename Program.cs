using System.IO;
using System.Runtime.CompilerServices;

// Initialize info to be written to file
string name = "Carter O'Leary";
string age = "29";
string address = "12345 Real Street, Town, ST 10101";
string[] info = {name, age, address};

// Initialize file path and if it doesn't exist, create it
string dir = "C:\\Users\\Carter\\Desktop\\test\\";
string filePath = Path.Combine(dir, "test.txt");
Directory.CreateDirectory(dir);

// Write text to specified file and close StreamWriter
StreamWriter writer = new StreamWriter(filePath);
foreach (string line in info)
{
    writer.WriteLine(line);
}
writer.Close();

// Initialize reader, read, and print text from file to console
StreamReader reader = new StreamReader(filePath);
string fileText = reader.ReadToEnd();
Console.WriteLine($"Text from the file:\n{fileText}");

reader.Close();