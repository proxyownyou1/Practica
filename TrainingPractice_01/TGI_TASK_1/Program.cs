using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGI_TASK_1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Random random = new Random();
            Console.Write("Введите начальное количество золота: ");
            int gold = Convert.ToInt32(Console.ReadLine());

            int Crystals = random.Next(1, 100);
            Console.WriteLine("Стоимость одного кристала {0}", Crystals);

            int amCrystal = gold / Crystals;
            Console.WriteLine("Ваше золото конвектировалось в {0} кристалов. \n ", amCrystal);
            int ostGold = gold - (amCrystal *Crystals);
            Console.WriteLine("Золота осталось: {0}", ostGold);
            
        }
    }
}
