using System;

class Program
{
    static string[] fio = new string[100];  // массив ФИО
    static string[] position = new string[100];  // массив должностей
    static int count = 0;  // количество записей в массивах

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить досье");
            Console.WriteLine("2. Вывести все досье");
            Console.WriteLine("3. Удалить досье");
            Console.WriteLine("4. Поиск по фамилии");
            Console.WriteLine("5. Выход");

            Console.Write("Введите номер пункта меню: ");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    AddDossier();
                    break;
                case 2:
                    ShowAllDossiers();
                    break;
                case 3:
                    DeleteDossier();
                    break;
                case 4:
                    SearchByLastName();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Некорректный ввод");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddDossier()
    {
        Console.Write("Введите ФИО: ");
        string fioItem = Console.ReadLine();

        Console.Write("Введите должность: ");
        string positionItem = Console.ReadLine();

        fio[count] = fioItem;
        position[count] = positionItem;
        count++;

        Console.WriteLine("Досье успешно добавлено");
    }

    static void ShowAllDossiers()
    {
        Console.WriteLine("Список досье:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("{0}. {1} - {2}", i + 1, fio[i], position[i]);
        }
    }

    static void DeleteDossier()
    {
        Console.Write("Введите номер досье для удаления: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < count)
        {
            for (int i = index; i < count - 1; i++)
            {
                fio[i] = fio[i + 1];
                position[i] = position[i + 1];
            }

            count--;
            Console.WriteLine("Досье успешно удалено");
        }
        else
        {
            Console.WriteLine("Некорректный номер досье");
        }
    }

    static void SearchByLastName()
    {
        Console.Write("Введите фамилию для поиска: ");
        string lastName = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < count; i++)
        {
            if (fio[i].ToLower().StartsWith(lastName.ToLower()))
            {
                Console.WriteLine("{0}. {1} - {2}", i + 1, fio[i], position[i]);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Досье не найдено");
        }
    }
}
