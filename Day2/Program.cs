using Day2;
using System.Formats.Asn1;
using System.Text;

string path = Path.Combine(AppContext.BaseDirectory, "input.txt");
string[] input = File.ReadAllLines(path, Encoding.UTF8);

var result = Helper.Splitter(input, 'x');
Console.WriteLine(Helper.CalculateSurfaceArea(result));
Console.WriteLine(Helper.CalculateRibbon(result));
