using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProject
{
    class Client:IComparable
    {
        public DateTime TimeVisit;
        public string Sex;
        private string fio;
        public int Age;
        public int SpendMoney = 0;
        public int ByuService = 0;
        public string FIO
        {
            get
            {
                if (Sex == "male" || Sex == "Male")
                {
                    return "Уважаемый "+ fio;
                }
                return "Уважаемая " + fio;
            }
            set {
                fio = value;
            }
        }

        public Client( string fullname, string sex, int age, DateTime timeVisit)
        {
            TimeVisit = timeVisit;
            Sex = sex;
            FIO = fullname;
            Age = age;
        }

        public void printSpendMoney()
        {
            Console.WriteLine(fio + " потратил " + SpendMoney);
        }

        public int CompareTo(object client2)
        {
            Client client3 = (Client)client2;
            if (this.ByuService > client3.ByuService)
            {
                return -1;
            }
            else if (this.ByuService == client3.ByuService)
            {
                if (this.Age > client3.Age)
                {
                    return -1;
                }
                else if (this.Age == client3.Age)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }
        }
        
    }
}
