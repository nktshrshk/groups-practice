using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groups_practice
{
    class Classroom
    {
        public string Name;
        public Student Student;
        public Teacher Teacher;

        public void PrintInfo()
        {
            Console.WriteLine($"This is {Name} classroom. It contains:");
            Teacher.PrintInfoForClassroom();
            Student.PrintInfoForClassroom();
        }
    }
}
