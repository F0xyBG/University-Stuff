using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_2___Specialties
{
    public class Specialty
    {
        public string Name { get; set; }
        public int CourseYear { get; set; }
        public Subject[] CommonSubjects { get; set; }
        public Subject[] Electives { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Specialty(string name, int courseYear, Subject[] commonSubjects, Subject[] electives)
        {
            Name = name;
            CourseYear = courseYear;
            CommonSubjects = commonSubjects;
            Electives = electives;
        }

        public Student AddStudent(string name, string fn, Subject[] electives)
        {
            Student student = new Student(name, fn);
            foreach (var subject in CommonSubjects)
            {
                student.AddSubject(subject);
            }
            foreach (var subject in electives)
            {
                student.AddSubject(subject);
            }
            Students.Add(student);
            return student;
        }

        public Student AddStudent(Student student, Subject[] electives)
        {
            foreach (var subject in CommonSubjects)
            {
                student.AddSubject(subject);
            }
            foreach (var subject in electives)
            {
                student.AddSubject(subject);
            }
            Students.Add(student);
            return student;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Specialty: {Name}");
            Console.WriteLine("Common Subjects:");
            foreach (var subject in CommonSubjects)
            {
                Console.WriteLine($"- {subject.Name}");
            }
            Console.WriteLine("Elective Subjects:");
            foreach (var subject in Electives)
            {
                Console.WriteLine($"- {subject.Name}");
            }
            Console.WriteLine($"Number of Students: {Students.Count}");
        }

        public Student[] GetStudentsBySubject(Subject subject)
        {
            return Students.Where(s => s.Subjects.Contains(subject)).ToArray();
        }

        public double GetAvgScore(Subject subject)
        {
            var grades = Students.Where(s => s.Grades.ContainsKey(subject)).Select(s => s.Grades[subject]);
            return grades.Any() ? grades.Average() : 0;
        }

        public double GetAvgScore()
        {
            var grades = Students.SelectMany(s => s.Grades.Values);
            return grades.Any() ? Math.Round(grades.Average(), 2) : 0;
        }

        public struct StudentAvgScore
        {
            public int Place;
            public Student Student;
            public double AvgScore;
        }

        public StudentAvgScore[] GetTopStudents(int n)
        {
            var studentScores = Students.Select(s => new StudentAvgScore
            {
                Student = s,
                AvgScore = Math.Round(s.GetAverageGrade(), 2)
            }).OrderByDescending(s => s.AvgScore).ThenBy(s => s.Student.Name).ToList();

            List<StudentAvgScore> topStudents = new List<StudentAvgScore>();
            int place = 1;
            for (int i = 0; i < studentScores.Count; i++)
            {
                if (i > 0 && studentScores[i].AvgScore < studentScores[i - 1].AvgScore)
                {
                    place = i + 1;
                }
                if (place > n) break;
                var temp = studentScores[i];
                temp.Place = place;
                studentScores[i] = temp;
                topStudents.Add(studentScores[i]);
            }

            return topStudents.ToArray();
        }
    }
}