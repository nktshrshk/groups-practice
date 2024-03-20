using System;

namespace groups_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n--------------------------------------------------------------------------------");

            // Инициализация объекта класса "Student".
            Student TestStudent1 = new Student();
            TestStudent1.Name = "TestStudent1Name";
            TestStudent1.Surname = "TestStudent1Surname";
            TestStudent1.Patronymic = "TestStudent1Patronymic";
            TestStudent1.Age = 99;

            Console.WriteLine("Student initialized!\n");
            TestStudent1.PrintInfo();

            Console.WriteLine("\n--------------------------------------------------------------------------------");

            // Инициализация объекта класса "Teacher".
            Teacher TestTeacher1 = new Teacher();
            TestTeacher1.Name = "TestTeacher1Name";
            TestTeacher1.Surname = "TestTeacher1Surname";
            TestTeacher1.Patronymic = "TestTeacher1Patronymic";
            TestTeacher1.Age = 88;

            Console.WriteLine("Teacher initialized!\n");
            TestTeacher1.PrintInfo();

            Console.WriteLine("\n--------------------------------------------------------------------------------");

            // Инициализация объекта класса "Classroom".
            Classroom TestClassroom1 = new Classroom();
            TestClassroom1.Name = "TestClassroom1Name";
            TestClassroom1.Student = TestStudent1;
            TestClassroom1.Teacher = TestTeacher1;

            Console.WriteLine("Classroom initialized!\n");
            TestClassroom1.PrintInfo();

            Console.WriteLine("\n--------------------------------------------------------------------------------\n");
        }
    }
}
