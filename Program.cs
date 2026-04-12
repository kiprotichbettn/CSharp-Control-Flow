

string[] subjects = { "Math", "Programming", "AI", "Databases", "Networking" };

Console.WriteLine("=== Subject Difficulty Check ===\n");

for (int i = 0; i < subjects.Length; i++)
{
    string subject = subjects[i];

    if (subject == "AI" || subject == "Programming")
    {
        Console.WriteLine($"{subject} - Advanced");
    }
    else if (subject == "Math" || subject == "Databases")
    {
        Console.WriteLine($"{subject} - Intermediate");
    }
    else
    {
        Console.WriteLine($"{subject} - Beginner");
    }
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();