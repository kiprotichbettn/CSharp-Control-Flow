using System;

string techStream = "AI,Machine Learning,Web Development,Cloud Computing,Cybersecurity";
string[] technologies = techStream.Split(',');

Array.Sort(technologies);

foreach (var tech in technologies)
{
    if (tech.Contains(" "))
    {
        Console.WriteLine($"{tech}\t- Multi-word");
    }
    else
    {
        Console.WriteLine($"{tech}\t- Single-word");
    }
}