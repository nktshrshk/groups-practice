using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groups_practice
{
    public class Student
    {
        public string Name;
        public string Surname;
        public string Patronymic;
        public int Age;
        public void PrintInfo()
        {
            Console.WriteLine($"This student's full name is:\n{Name} {Surname} {Patronymic}\n\nTheir age:\n{Age}");
        }

        public void PrintInfoForClassroom()
        {
            Console.WriteLine($"A student: {Name} {Surname} {Patronymic}");
        }
    }
}