using System;
using ExamProject.CarWash;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Client person1 = new Client("Am A A", "male", 18, new DateTime());
            person1.FIO = "ALEX MOROZOV HA";
            Console.WriteLine(person1.FIO);
            Console.ReadLine();
        }
    }
}
