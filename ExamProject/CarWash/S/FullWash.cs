using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject.CarWash
{
    class FullWash:Service
    {
        public FullWash(Employee employee, Client client, DateTime time) : base(employee, client, time)
        {
            Price = 400;
        }

        public void Message()
        {
            Console.WriteLine("Была выполнена услуга 'Полная мойка авто'");
        }
    }
}
