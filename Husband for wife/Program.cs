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

                var _money = programmer.GetMoney();
                var _food = wife.GetFood();
                var _sex = wife.GetSex();

                Console.WriteLine($"количество долларов заработанных Мужем: {_money}");
                Console.WriteLine("\n\n");
                Console.WriteLine($"количество раз приготовления Женой еды: {_food}");
                Console.WriteLine($"количество раз исполнения Женой супр. обязанностей: {_sex}");
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }

            Console.ReadLine();
        }
    }
}
