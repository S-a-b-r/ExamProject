using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash.S
{
    class DryCarWash:Service
    {
        public DryCarWash(Employee employee, Client client, DateTime time) : base(employee, client, time)
        {
            Price = 250;
        }

        public void Message()
        {
            Console.WriteLine("Была выполнена услуга 'Сухая мойка'");
        }
    }
}
