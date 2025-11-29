using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Samuel Bennett","Multiplication");
        Console.WriteLine(a.GetSummary());

        MathAssignment mathA = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-19");
        Console.WriteLine(mathA.GetSummary());
        Console.WriteLine(mathA.GetHomeworkList());

        WritingAssignment writingA = new WritingAssignment("Mary Waters","European History","The causes of World War II");
        Console.WriteLine(writingA.GetSummary());
        Console.WriteLine(writingA.GetWritingInformation());
    }
}