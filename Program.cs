// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

namespace Workshop_Week_4;

public class Program
{
    public static void Main (string[] args)
    {
        Student student1 = new Student(23,"Suman Tamang",21);
        Student student2 = new Student(24, "Suman Tamang", 26);

        Console.WriteLine("--- Student 1 Details ---");
        Console.WriteLine($"ID: {student1.studentId}");
        Console.WriteLine($"Name: {student1.name}");
        Console.WriteLine($"GPA: {student1.age}");

        Console.WriteLine("\n--- Student 2 Details ---");
        Console.WriteLine($"ID: {student2.studentId}");
        Console.WriteLine($"Name: {student2.name}"); 
        Console.WriteLine($"GPA: {student2.age}");

        Console.WriteLine($"\nUniversity Name : {Student.collegeName}");


        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.PrintWelcome());
        Console.WriteLine(calculator.Add(12, 31));
        Console.WriteLine(calculator.Multiply(12, 312));


        ParameterDemo para = new ParameterDemo();

        int orginalNumber = 10;
        Console.WriteLine($"\n After Using Ref Orginal Value {para.Increase(ref orginalNumber)}");

        Console.WriteLine($"Full Name returned (out parameter): {para.GetFullName(out string fullName)}");

        int sum1 = para.SumAll(1, 4, 3, 4, 5);
        Console.WriteLine($"Sum of (1, 4, 3, 4, 5): {sum1}");

        int sum2 = para.SumAll(1, 4, 3, 4, 5);
        Console.WriteLine($"Sum of (1, 4, 3, 4, 5): {sum2}");

        int sum3 = para.SumAll(1, 5, 3, 4, 5);
        Console.WriteLine($"Sum of (1, 5, 3, 4, 5): {sum3}");


        Player player = new Player();

        Player player1 = new Player(12,"suman",12);


    }
}