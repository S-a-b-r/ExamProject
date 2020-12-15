using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash
{
    class Employee
    {
        public int WorkDone;
        public string FIO;
        public Employee(string fio)
        {
            FIO = fio;
        }
        public void PrintWork()
        {
            Console.WriteLine(FIO+" выполнил "+ WorkDone + " услуг");
        }
    }
}
