using System.Collections;

void print(string name, List<string> list)
{
    Console.WriteLine($"{name}:");
    foreach (var i in list)
    {
        Console.Write($"{i}  ");
    }
    Console.WriteLine();
}
List<string> list = new List<string>();
while (true)
{
    Console.WriteLine("Меню \n\n1.Добавить элемент в коллекцию \n2.Добавить в список элементы из коллекции c \n3.Алгоритм двоичного поиска \n4.Индекс первого вхождения объекта \n5.Изменение порядка элементов на обратный \n6.Сортировка \n7.Очищение коллекции \n8.Количество объектов, хранящихся в коллекции \n9.Удалить часть коллекции \n10.Выход");
    string key = Console.ReadLine();
    if (key == "1")
    {
        Console.WriteLine("Введите элемент");
        list.Add(Console.ReadLine());
        print("list", list);
    }
    else if (key == "2")
    {
        List<string> c = new List<string>();
        string key_2;
        Console.WriteLine("Введите элементы коллекции c");
        while (true)
        {
            c.Add(Console.ReadLine());
            Console.WriteLine("1.Продолжить \n2.Выход");
            key_2 = Console.ReadLine();
            if (key_2 == "1")
            {

            }
            else if (key_2 == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("Неизвестная команда");
                break;
            }
            Console.Clear();
        }
        list.AddRange(c);
        Console.Clear();
        print("c", c);
        print("list", list);
    }
    else if (key == "3")
    {
        Console.WriteLine("Укажите элемент");
        Console.WriteLine("Индекс элемента: " + list.BinarySearch(Console.ReadLine()));
    }
    else if (key == "4")
    {
        Console.WriteLine(list.IndexOf(Console.ReadLine()));
    }
    else if (key == "5")
    {
        list.Reverse();
        print("list", list);
    }
    else if (key == "6")
    {
        list.Sort();
        print("list", list);
    }
    else if (key == "7")
    {
        list.Clear();
        print("list", list);
    }
    else if (key == "8")
    {
        Console.WriteLine(list.Count);
    }
    else if (key == "9")
    {
        Console.WriteLine("Введите начальный индекс и количество элементов которые вы хотите удалить");
        list.RemoveRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        print("list", list);
    }
    else if (key == "10")
    {
        break;
    }
    else
    {
        Console.WriteLine("Неизвестная команда");
    }
    Console.WriteLine("Нажмите любую клавишу");
    Console.ReadKey();
    Console.Clear();
}