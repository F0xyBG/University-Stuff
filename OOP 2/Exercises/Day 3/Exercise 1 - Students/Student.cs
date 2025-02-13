using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_1___Students
{
    public class Student
    {
        public string Name;
        public List<Subject> Subjects = new List<Subject>();
        public Dictionary<Subject, double> Grades = new Dictionary<Subject, double>();
        public string FacultyNumber;

        public Student(string name, string facultyNumber)
        {
            Name = name;
            FacultyNumber = facultyNumber;
        }

        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }

        public void AddGrade(Subject subject, double grade)
        {
            if(grade >= 2 && grade <= 6)
            {
                Grades.Add(subject, grade);
            } else throw new ArgumentException("Grade must be between 2 and 6");
        }

        public int GetSubjectCount()
        {
            return Subjects.Count;
        }

        public List<string> GetSubjects()
        {
            List<string> subjects = new List<string>();
            foreach (Subject subject in Subjects)
            {
                subjects.Add(subject.Name);
            }
            return subjects;
        }

        public double GetSubjectGrade(Subject subject)
        {
            return Grades[subject];
        }

        public double GetAverageGrade()
        {
            double sum = 0;
            foreach (int grade in Grades.Values)
            {
                sum += grade;
            }
            return sum / Grades.Count;
        }

        public string GetStudentInfo()
        {
            string info = $"Name: {Name}\nFaculty Number: {FacultyNumber}\nSubjects: ";

            if (Subjects.Count == 0)
            {
                info += "No subjects available";
                return info;
            }
            foreach (Subject subject in Subjects)
            {
                info += $"{subject.Name}, ";
            }

            info = info.Remove(info.Length - 2);
            info += "\n Grades:";

            if (Grades.Count == 0)
            {
                info += "No grades available";
                return info;
            }
            foreach (KeyValuePair<Subject, double> grade in Grades)
            {
                info += $"{grade.Key.Name} - {grade.Value}, ";
            }
            info = info.Remove(info.Length - 2);
            info += $"\nAverage grade: {GetAverageGrade()}";
            return info;
        }

    }
}