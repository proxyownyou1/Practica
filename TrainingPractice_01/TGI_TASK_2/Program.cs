using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGI_TASK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ex = "";
            while (ex != "exit")
            {
                Console.WriteLine("Программа,выполняется до тех пор, пока не будет введено слово exit. ");
                ex = Console.ReadLine();
            }

        }
    }
}
