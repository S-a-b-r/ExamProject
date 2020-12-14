using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash.S
{
    class SelfServiceWash:Service
    {
        public SelfServiceWash(Employee employee, Client client, DateTime time) : base(employee,client,time)
        {
            Price = 100;
        }

        public void Message()
        {
            Console.WriteLine("Была выполнена услуга 'Мойка самообслуживания'");
        }
    }
}
