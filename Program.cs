string[] students = { "Nickson", "Mary", "John", "Grace", "Alex" };
int[] scores = { 85, 72, 49, 91, 60 };

Console.WriteLine($"=== Student Grade Analyzer ===\n");

for (int i = 0; i < students.Length; i++)
{
    string grade = GetGrade(scores[i]);

    Console.WriteLine($"Student: {students[i]}");
    Console.WriteLine($"Score: {scores[i]}");
    Console.WriteLine($"Grade: {grade}");

    if (scores[i] >= 50)
    {
        Console.WriteLine($"Status: Passed");
    }
    else
    {
        Console.WriteLine($"Status: Failed");
    }

    switch (grade)
    {
        case "A":
            Console.WriteLine($"Comment: Excellent.");
            break;

        case "B":
            Console.WriteLine($"Comment: Good.");
            break;

        case "C":
            Console.WriteLine($"Comment: Need to Improve.");
            break;

        case "D":
            Console.WriteLine($"Comment: Passed.");
            break;

        default:
            Console.WriteLine($"Comment: Retake.");
            break;
    }

    Console.WriteLine($"\n----------------------\n");
}

static string GetGrade(int score)
{
    if (score >= 80)
        return "A";

    else if (score >= 70)
        return "B";

    else if (score >= 60)
        return "C";

    else if (score >= 50)
        return "D";

    else
        return "F";
}