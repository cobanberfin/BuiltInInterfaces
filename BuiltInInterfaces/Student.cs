using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BuiltInInterfaces
{
    class Student :IComparable<Student>
    {
        public int Id { get; set; }

        public int Age { get; set; }
        public string Name { get; set; }

        public int CompareTo( Student other)//jenerık lıste sort metodunu nasıl yazardık
        {
            if (this.Age > other.Age)
            {
                return 1;
            }
            else if (this.Age < other.Age)
            {
                return -1;
            }
            return 0;
        }
    }
}
