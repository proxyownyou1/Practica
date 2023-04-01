using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] maze = File.ReadAllLines("map.txt");
        int rows = maze.Length;
        int cols = maze[0].Length;
        int startX = 0;
        int startY = 0;
        int endX = 0;
        int endY = 0;

        // ищем начальное положение игрока и выход из лабиринта
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (maze[i][j] == '@')
                {
                    startX = i;
                    startY = j;
                    // Убираем начальное местоположение игрока из карты
                    maze[i] = maze[i].Remove(j, 1).Insert(j, " ");
                }
                else if (maze[i][j] == 'X')
                {
                    endX = i;
                    endY = j;
                }
            }
        }

        // выводим карту лабиринта
        Console.WriteLine("Карта лабиринта:");
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(maze[i]);
        }
        Console.WriteLine();

        // проходим лабиринт
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Ваше текущее положение: ({0}, {1})", startX, startY);

            // перемещаем игрока в зависимости от ввода пользователя
            Console.Write("Введите команду (w - вверх, s - вниз, a - влево, d - вправо, q - выход): ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();

            int newStartX = startX;
            int newStartY = startY;

            switch (key.KeyChar)
            {
                case 'w':
                    newStartX--;
                    break;
                case 's':
                    newStartX++;
                    break;
                case 'a':
                    newStartY--;
                    break;
                case 'd':
                    newStartY++;
                    break;
                case 'q':
                    exit = true;
                    break;
                default:
                    break;
            }

            // проверяем, можно ли переместиться в указанном направлении
            if (newStartX >= 0 && newStartX < rows && newStartY >= 0 && newStartY < cols && maze[newStartX][newStartY] != '#')
            {
                startX = newStartX;
                startY = newStartY;
            }

            // проверяем, достиг ли игрок выхода из лабиринта
            if (startX == endX && startY == endY)
            {
                Console.WriteLine("Вы победили!");
                exit = true;
            }

            // отображаем карту лабиринта с игроком в текущем положении
            Console.Clear();
            Console.WriteLine("Карта лабиринта:");
            for (int i = 0; i < rows; i++)
            {
                string line = "";
                for (int j = 0; j < cols; j++)
                {
                    if (i == startX && j == startY)
                    {
                        line += "@";
                    }
                    else
                    {
                        line += maze[i][j];
                    }
                }
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Нажмите любую клавишу");
        Console.ReadKey();
    }
}


