using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash.S
{
    class ManualWash:Service
    {
        public ManualWash(Employee employee, Client client, DateTime time) : base(employee, client, time)
        {
            Price = 200;
        }

        public void Message()
        {
            Console.WriteLine("Была выполнена услуга 'Ручная мойка'");
        }
    }
}
