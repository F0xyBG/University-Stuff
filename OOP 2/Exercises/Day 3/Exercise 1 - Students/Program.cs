namespace Exercise_1___Students;

class Program
{
    static void Main(string[] args)
    {
        // Create subjects
        Subject math = new Subject("Math");
        Subject physics = new Subject("Physics");
        Subject chemistry = new Subject("Chemistry");

        // Create students
        Student student1 = new Student("Alice", "2401322016");
        Student student2 = new Student("Bob", "2401322016");

        // Add subjects to students
        student1.AddSubject(math);
        student1.AddSubject(physics);
        student2.AddSubject(chemistry);
        student2.AddSubject(math);

        // Add grades to students
        student1.AddGrade(math, 6);
        student1.AddGrade(physics, 5.25);
        student2.AddGrade(chemistry, 5);
        student2.AddGrade(math, 2);

        // Demonstrate methods
        Console.WriteLine("Student 1 Info:");
        Console.WriteLine(student1.GetStudentInfo());
        Console.WriteLine();

        Console.WriteLine("Student 2 Info:");
        Console.WriteLine(student2.GetStudentInfo());
        Console.WriteLine();

        Console.WriteLine("Student 1 Subject Count: " + student1.GetSubjectCount());
        Console.WriteLine("Student 2 Subject Count: " + student2.GetSubjectCount());
        Console.WriteLine();

        Console.WriteLine("Student 1 Subjects: " + string.Join(", ", student1.GetSubjects()));
        Console.WriteLine("Student 2 Subjects: " + string.Join(", ", student2.GetSubjects()));
        Console.WriteLine();

        Console.WriteLine("Student 1 Math Grade: " + student1.GetSubjectGrade(math));
        Console.WriteLine("Student 2 Chemistry Grade: " + student2.GetSubjectGrade(chemistry));
        Console.WriteLine();

        Console.WriteLine("Student 1 Average Grade: " + student1.GetAverageGrade());
        Console.WriteLine("Student 2 Average Grade: " + student2.GetAverageGrade());
    }
}
