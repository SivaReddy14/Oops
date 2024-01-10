using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsStudent
{
   public  class Person
    {
        public string Name { get; set; }
        public string ClassAndSection { get; set; }
    }

    
    class Student : Person { }

  
    class Teacher : Person { }

    
    class Subject
    {
        public string Name { get; set; }
        public string SubjectCode { get; set; }
        public Teacher AssignedTeacher { get; set; }
    }

 
    class SchoolFactory
    {
        public static Student CreateStudent(string name, string classAndSection)
        {
            return new Student { Name = name, ClassAndSection = classAndSection };
        }

        public static Teacher CreateTeacher(string name, string classAndSection)
        {
            return new Teacher { Name = name, ClassAndSection = classAndSection };
        }

        public static Subject CreateSubject(string name, string subjectCode, Teacher teacher)
        {
            return new Subject { Name = name, SubjectCode = subjectCode, AssignedTeacher = teacher };
        }
    }

    class Program
    {
        static void Main()
        {
           
            var student = SchoolFactory.CreateStudent("Siva", "Class MCA");
            var teacher = SchoolFactory.CreateTeacher("Mr.Reddy", "Class MBA");
            var subject = SchoolFactory.CreateSubject("COMPUTERS", "COM100", teacher);
            var student1 = SchoolFactory.CreateStudent("Nanda", "Class EEE");
            var teacher1 = SchoolFactory.CreateTeacher("Mr.Siva Reddy", "Class CSE");
            var subject1 = SchoolFactory.CreateSubject("SOCIAL", "ACC101", teacher1);


            
            var studentsList = new List<Student> { student };
            var teachersList = new List<Teacher> { teacher };
            var subjectsList = new List<Subject> { subject };
            var studentsList1 = new List<Student> { student1 };
            var teachersList1 = new List<Teacher> { teacher1 };
            var subjectsList1 = new List<Subject> { subject1 };


           
            Console.WriteLine("Students:");
            foreach (var s in studentsList)
            {
                Console.WriteLine($"{s.Name} - {s.ClassAndSection}");
            }
            
            foreach (var s in studentsList1)
            {
                Console.WriteLine($"{s.Name} - {s.ClassAndSection}");
            }


            Console.WriteLine("\nTeachers:");
            foreach (var t in teachersList)
            {
                Console.WriteLine($"{t.Name} - {t.ClassAndSection}");
            }
            foreach (var t in teachersList1)
            {
                Console.WriteLine($"{t.Name} - {t.ClassAndSection}");
            }

            Console.WriteLine("\nSubjects:");
            foreach (var sub in subjectsList)
            {
                Console.WriteLine($"{sub.Name} - {sub.SubjectCode} - Taught by: {sub.AssignedTeacher.Name}");
            }
            foreach (var sub in subjectsList1)
            {
                Console.WriteLine($"{sub.Name} - {sub.SubjectCode} - Taught by: {sub.AssignedTeacher.Name}");
            }
        }
    }
}