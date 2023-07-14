using System.Text;


string path = Path.Combine(AppContext.BaseDirectory, "input.txt");
string input = File.ReadAllText(path, Encoding.UTF8);

input.ToCharArray();

var forwardCount = 0;
var backwardCount = 0;
var index = 1;
var count = 0;

foreach (char c in input)
{
    if (c == '(')
    {
        forwardCount++;
    }
    else if (c == ')')
    {
        backwardCount++;
    }
}

Console.WriteLine(forwardCount - backwardCount);

foreach (char c in input)
{
    if (c == '(')
    {
        count++;
    }
    else if (c == ')')
    {
        count--;
    }
    if (count == -1) 
    {
        Console.WriteLine(index);
    }
    index++;
}