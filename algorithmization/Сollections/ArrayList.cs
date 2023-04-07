using System.Collections;

void print(string name, ArrayList list)
{
    Console.WriteLine($"{name}:");
    foreach (var i in list)
    {
        Console.Write($"{i}  ");
    }
    Console.WriteLine();
}
ArrayList list = new ArrayList();
while (true)
{
    Console.WriteLine("Меню \n\n1.Добавить элемент в коллекцию \n2.Добавить в список элементы из коллекции c \n3.Алгоритм двоичного поиска \n4.Скопировать содержимое коллекции в массив array \n5.Изменение порядка элементов на обратный \n6.Сортировка \n7.Очищение коллекции \n8.Количество объектов, хранящихся в коллекции \n9.Удалить часть коллекции \n10.Индекс первого вхождения объекта \n11.Выход");
    string key = Console.ReadLine();
    if (key == "1")
    {
        list.Add(Console.ReadLine());
        print("list", list);
    }
    else if (key == "2")
    {
        ArrayList c = new ArrayList();
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
        Console.WriteLine("Индекс элемента - " + list.BinarySearch(Console.ReadLine()));
    }
    else if (key == "4")
    {
        var array = Array.CreateInstance(typeof(string), list.Count);
        list.CopyTo(array);
        print("list", list);
        Console.WriteLine("array");
        foreach (var i in array)
        {
            Console.Write($"{i}  ");
        }
        Console.WriteLine();
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
        Console.WriteLine(list.IndexOf(Console.ReadLine()));
    }
    else if (key == "11")
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
