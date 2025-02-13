using System;

namespace Exercise_2___Specialties
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject math = new Subject("Math");
            Subject physics = new Subject("Physics");
            Subject chemistry = new Subject("Chemistry");
            Subject biology = new Subject("Biology");

            Subject[] commonSubjects = { math, physics };
            Subject[] electives = { chemistry, biology };

            Specialty specialty = new Specialty("Computer Science", 1, commonSubjects, electives);

            Student student1 = new Student("Alice", "12345");
            specialty.AddStudent(student1, new Subject[] { chemistry });

            Student student2 = specialty.AddStudent("Bob", "67890", new Subject[] { biology });

            student1.AddGrade(math, 5.5);
            student1.AddGrade(physics, 6.0);
            student1.AddGrade(chemistry, 5.0);

            student2.AddGrade(math, 4.5);
            student2.AddGrade(physics, 5.0);
            student2.AddGrade(biology, 6.0);

            specialty.PrintInfo();

            Console.WriteLine("\nStudents by subject (Math):");
            foreach (var student in specialty.GetStudentsBySubject(math))
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine($"\nAverage score for Math: {specialty.GetAvgScore(math)}");
            Console.WriteLine($"Average score for Specialty: {specialty.GetAvgScore()}");

            Console.WriteLine("\nTop Students:");
            foreach (var topStudent in specialty.GetTopStudents(3))
            {
                Console.WriteLine($"In place {topStudent.Place} is {topStudent.Student.Name} with a score of {topStudent.AvgScore}");
            }
        }
    }
}
