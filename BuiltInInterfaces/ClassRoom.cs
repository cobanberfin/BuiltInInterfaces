using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BuiltInInterfaces
{
    class ClassRoom :IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();

        public void AddStudents(Student student)
        {
            students.Add(student);
        }
        //amacım icerdekı studentı dısarı döndurmek
        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var item in students)
            {
                yield return item;    //itemı döndur dısrdan forech kullanılıyorsa kaldııgn yerden devam et .nerde kaldıgını tut yıeld

            }
        }

        public void SortStudent()
        {
            students.Sort();
            //foreach (var item in students)
            //{
            //    Console.WriteLine($"{item.Name} {item.Age}");
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
