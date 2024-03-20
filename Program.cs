using System;

namespace groups_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация объекта класса "Student".
            Student TestStudent1 = new Student();
            TestStudent1.Name = "TestStudent1Name";
            TestStudent1.Surname = "TestStudent1Surname";
            TestStudent1.Patronymic = "TestStudent1Patronymic";
            TestStudent1.Age = 99;

            Console.WriteLine("Student initialized!\n");
            TestStudent1.PrintInfo();
        }
    }
}
