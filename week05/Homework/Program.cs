class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment(
            "Lwande Dana",
            "Fractions",
            "7.3",
            "8-19");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment(
            "Lwande Dana",
            "European History",
            "The Causes of World War II");

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}