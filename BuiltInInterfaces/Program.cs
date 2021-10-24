using System;

namespace BuiltInInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassRoom classroom = new ClassRoom();
            classroom.AddStudents(new Student { Id = 1, Age = 18, Name = "ayse" });
            classroom.AddStudents(new Student { Id = 2, Age = 41, Name = "Türkay" });
            classroom.AddStudents(new Student { Id = 3, Age = 23, Name = "ahmet" });
            classroom.AddStudents(new Student { Id = 4, Age = 23, Name = "Berfin" });

            classroom.SortStudent();


            foreach (var student in classroom) //instınta forech ıle donuyorum Ienumrableıle
            {
                Console.WriteLine($"{student.Name} {student.Age}");
            }





        }
    }
}
