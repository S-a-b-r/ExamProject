using System;
using ExamProject.CarWash;
using ExamProject.CarWash.S;

namespace ExamProject
{
    class Program
    {
        static int CountClientOnInterval(Client[] Base, DateTime Start, DateTime Finish )
        {
            var start = Start.ToBinary();
            var finish = Finish.ToBinary();
            int count = 0;
            for(int i = 0; i< Base.Length; i++)
            {
                var time = Base[i].TimeVisit.ToBinary();
                if (time >= start && time <= finish)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Client[] clientBase = { new Client("Самый старый человек", "male", 99, new DateTime(2020, 7, 24)),
            new Client("Старый человек", "male", 70, new DateTime(2020, 7, 25)),
            new Client("Молодая девушка", "female", 20, new DateTime(2020, 7, 25)),
            new Client("Молодой парень", "male", 20, new DateTime(2020, 7,26)),
            new Client("Женщина, с купленной одной услугой", "female", 30, new DateTime(2020, 7, 26)),
            new Client("Женщина с двумя купленными услугами", "female", 40, new DateTime(2020, 7, 27)),
            };
            for(int i = 0; i<clientBase.Length; i++)
            {
                Console.WriteLine(clientBase[i].FIO);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Employee stuff1 = new Employee("Васильев Иван Анатолич");
            DryCarWash serv0 = new DryCarWash(stuff1, clientBase[4], new DateTime());
            serv0.Do();
            FullWash serv1 = new FullWash(stuff1, clientBase[5], new DateTime());
            serv1.Do();
            serv1.Do();

            Array.Sort(clientBase);

            for (int i = 0; i < clientBase.Length; i++)
            {
                Console.WriteLine(clientBase[i].FIO);
            }

            Console.WriteLine("Посетителей в интервале " + CountClientOnInterval(clientBase, new DateTime(2020, 7, 26), new DateTime(2020, 7, 26)));

            int n = 10;//Сколько услуг нужно выполнить
            var rnd = new Random();
            var clienTest = new Client("Иванов Иван Иваныч", "male", 22, new DateTime(2020, 8, 30));
            var employeeTest = new Employee("Васильев Василий Васильевич");
            for(int i = 0; i < n; i++)
            {
                int numWash = rnd.Next(0, 4);
                if(numWash ==0)
                {
                    var service = new DryCarWash(employeeTest, clienTest, clienTest.TimeVisit);
                    service.Do();
                    service.Message();
                }
                else if(numWash == 1)
                {
                    var service = new FullWash(employeeTest, clienTest, clienTest.TimeVisit);
                    service.Do();
                    service.Message();
                }
                else if (numWash == 2)
                {
                    var service = new ManualWash(employeeTest, clienTest, clienTest.TimeVisit);
                    service.Do();
                    service.Message();
                }
                else if (numWash == 3)
                {
                    var service = new SelfServiceWash(employeeTest, clienTest, clienTest.TimeVisit);
                    service.Do();
                    service.Message();
                }
            }


            Console.WriteLine();
            employeeTest.PrintWork();
            Console.WriteLine();
            stuff1.PrintWork();
            Console.WriteLine();
            clienTest.printSpendMoney();
            
            Console.ReadLine();
        }
    }
}
