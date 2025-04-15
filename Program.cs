using System.IO;
using System.Runtime.CompilerServices;

string name = "Carter O'Leary";
string age = "29";
string address = "12345 Real Street, Town, ST 10101";
string[] info = {name, age, address};

string dir = "C:\\Users\\Carter\\Desktop\\test\\";
string filePath = Path.Combine(dir, "test.txt");
Directory.CreateDirectory(dir);

StreamWriter writer = new StreamWriter(filePath);

foreach (string line in info)
{
    writer.WriteLine(line);
}

writer.Close();

StreamReader reader = new StreamReader(filePath);
string fileText = reader.ReadToEnd();
Console.WriteLine($"Text from the file:\n{fileText}");

reader.Close();