using Day2;
using System.Formats.Asn1;
using System.Text;

string path = Path.Combine(AppContext.BaseDirectory, "input.txt");
string[] input = File.ReadAllLines(path, Encoding.UTF8);

var result = Helper.Splitter(input, 'x');
Console.WriteLine(Helper.CalculateSurfaceArea(result));
Console.WriteLine(Helper.CalculateRibbon(result));


//int neededWrapAll = 0;
//for (int i = 0; i < input.Length; i++)
//{
//    string[] stringDimensions = input[i].Split("x");
//    int[] intDimensions = new int[3];
//    int volume = 0;

//    for (int j = 0; j < stringDimensions.Length; j++)
//    {
//        int dimension = int.Parse(stringDimensions[j]);
//        intDimensions[j] = dimension;
//    }
//    int[] area = new int[3];
//    area[0] = (2 * intDimensions[0] * intDimensions[1]);
//    area[1] = (2 * intDimensions[0] * intDimensions[2]);
//    area[2] = (2 * intDimensions[1] * intDimensions[2]);

//    volume = area[0] + area[1] + area[2];

//    int minimum = area.Min() / 2;
//    int neededWrapEach = volume + minimum;

//    neededWrapAll += neededWrapEach;
//}

//Console.WriteLine(neededWrapAll);


