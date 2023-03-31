using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGI_TASK_4
{

   
        internal class Program
        {
            static void Main(string[] args)
            {
                int healthPlayer = 200;
                int healthBoss = 300;

                Random rnd = new Random();
                int hod = rnd.Next(1, 3);  // Определяет кто ходит первый. Если 1 то Игрок, если 2 то Босс.

                int zaklinanie1 = 60;
                int zaklinanie2 = 55;
                int zaklinanie3 = 75;
                int zaklinanie4 = 100;
                int zaklinanie5 = 120;


                Console.WriteLine("Теневой маг против Босса, у вас 200 едениц жизни и есть 5 заклинаний:" + Environment.NewLine +
                                  "1. Crystal Nova - Обдаёт выбранную область морозным ветром, который наносит врагам урон " + Environment.NewLine +
                                  "2. Frostbite - Заковывает противника в лёд, нанося ему  урон" + Environment.NewLine +
                                  "3. Arcane Aura - Под снежным покровом восстанавливает здоровье герою" + Environment.NewLine +
                                  "4. Shadowraze - Герой опустошает участок земли прямо перед собой, нанося урон всем врагам в зоне действия." + Environment.NewLine +
                                  "5. Requiem of Souls - Герой выпускает собранные души в волнах демонической энергии и наносит значительный урон. ");
                Console.WriteLine("");
                Console.WriteLine("Ваш противник - Босс. Он имеет 300 едениц здоровья!" + Environment.NewLine +
                                  "Атаки Босса наносят от 35 до 90 урона за 1 ход. ");

                Console.WriteLine("Начало игры! ");

                Console.WriteLine(" ");
                if (hod == 1)
                    Console.WriteLine("Первым хоодит Теневой маг!");
                else
                    Console.WriteLine("Первым ходит Босс!");
                while (healthPlayer > 0 && healthBoss > 0)
                {
                    if (hod == 1)
                    {
                        Console.WriteLine("Делайте ход, выберите атаку, напишите номер заклинания которым хотите атаковать Босса!");
                        int vibar = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(" ");
                        switch (vibar)
                        {
                            case 1:
                                Console.WriteLine("Вы выбрали 'Crystal Nova' и успешно наносите 60 урона Боссу! ");
                                healthBoss -= zaklinanie1;
                                break;

                            case 2:
                                Console.WriteLine("Вы выбрали 'Frostbite' и нанесли 55 урона Боссу  ");
                                healthBoss -= zaklinanie2;
                                break;

                            case 3:
                                Console.WriteLine("Вы выбрали 'Arcane Aura' и восстановили здоровье герою размером в 75 единиц.  ");
                                healthPlayer += zaklinanie3;
                                break;

                            case 4:
                                Console.WriteLine("Вы выбрали 'Shadowraze' и  успешно нанесли 100 урона Боссу  ");
                                healthBoss -= zaklinanie4;
                                break;

                            case 5:
                                Console.WriteLine("Вы выбрали 'Requiem of Souls' и нанесли 120 урона Боссу  ");
                                healthBoss -= zaklinanie5;
                                break;


                            default:
                                Console.WriteLine("Пожалуйста, используйте только предоставленные закленания.");
                                break;
                        }

                        hod = 2;
                    }
                    else
                    {
                        Console.WriteLine("Босс начинает атаку!");
                        int attackBoss = rnd.Next(35, 90);
                        Console.WriteLine($"Сформировал атаку мощностью {attackBoss}!");
                        healthPlayer -= attackBoss;
                        hod = 1;
                    }

                    Console.WriteLine($"На данный момент у Героя {healthPlayer} едениц здоровья. В то время как у Босса {healthBoss} здоровья!");
                    Console.WriteLine(" ");

                }

                Console.WriteLine("-------------------------------------------------------------------");

                if (healthBoss <= 0)
                {
                    Console.WriteLine($"Победа Героя! Босс проиграл!");
                }
                else if (healthPlayer <= 0)
                {
                    Console.WriteLine($"Босс победил Героя!");

                }

            }
        }
    }
