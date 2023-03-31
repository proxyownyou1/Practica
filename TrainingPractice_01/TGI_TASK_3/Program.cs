using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGI_TASK_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Придумайте пароль: ");
            string password = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Введите пароль: ");
                string vvod = Console.ReadLine();
                if (!vvod.Equals(password))
                {
                    Console.WriteLine("Пароль не верен! \n Попыток осталось: {0}/3", i);
                }
                else
                {
                    Console.WriteLine("Пароль верен! Секретное сообщение получено.");
                    break;
                }
            }
        }
    }
}
