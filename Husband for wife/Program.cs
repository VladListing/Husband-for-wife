using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husband_for_wife
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Husband
                Programmer programmer = new Programmer();

                //Wife 
                Wife wife = new Wife(programmer);
                programmer.EarnMoney();
                var money = programmer.GetMoney();
                var food = wife.GetFood();
                var sex = wife.GetSex();

                Console.WriteLine($"количество долларов заработанных Мужем: {money}");
                Console.WriteLine("\n\n");
                Console.WriteLine($"количество раз приготовления Женой еды: {food}");
                Console.WriteLine($"количество раз исполнения Женой супр. обязанностей: {sex}");
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }

            Console.ReadLine();
        }
    }
}
