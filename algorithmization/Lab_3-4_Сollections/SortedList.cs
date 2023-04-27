using System.Collections;

void print(string name, SortedList list)
{
    ICollection с = list.Keys;
    Console.WriteLine(name + ":");
    foreach (string str in с)
    {
        Console.WriteLine(str + ": " + list[str]);
    }
}

SortedList list = new SortedList();
while (true)
{
    Console.WriteLine("Меню \n\n1.Добавить элемент в коллекцию \n2.Проверка на наличие ключа \n3.Проверка на наличие значения\n4.Ключ по индексу \n5.Значение по индексу \n6.Индекс ключа \n7.Индекс значения\n8.Смена значения по индексу \n9.Удалить элемент по ключу \n10.Очищение коллекции \n11.Выход");
    string key = Console.ReadLine();
    if (key == "1")
    {
        Console.WriteLine("Введите ключ и значение");
        list.Add(Console.ReadLine(), Console.ReadLine());
        print("list", list);
    }
    else if (key == "2")
    {
        Console.WriteLine("Введите ключ");
        if (list.ContainsKey(Console.ReadLine()))
        {
            Console.WriteLine("Ключ принадлежит коллекции");
        }
        else
        {
            Console.WriteLine("Ключ не принадлежит коллекции");
        }
    }
    else if (key == "3")
    {
        Console.WriteLine("Введите значение");
        if (list.ContainsValue(Console.ReadLine()))
        {
            Console.WriteLine("Значение принадлежит коллекции");
        }
        else
        {
            Console.WriteLine("Значение не принадлежит коллекции");
        }
    }
    else if (key == "4")
    {
        Console.WriteLine("Введите индекс");
        Console.WriteLine(list.GetKey(int.Parse(Console.ReadLine())));
        print("list", list);
    }
    else if (key == "5")
    {
        Console.WriteLine("Введите индекс");
        Console.WriteLine(list.GetByIndex(int.Parse(Console.ReadLine())));
        print("list", list);
    }
    else if (key == "6")
    {
        Console.WriteLine("Введите ключ");
        Console.WriteLine(list.IndexOfKey(Console.ReadLine()));
        print("list", list);
    }
    else if (key == "7")
    {
        Console.WriteLine("Введите значение");
        Console.WriteLine(list.IndexOfValue(Console.ReadLine()));
        print("list", list);
    }
    else if (key == "8")
    {
        Console.WriteLine("Введите индекс");
        list.SetByIndex(int.Parse(Console.ReadLine()), Console.ReadLine());
        print("list", list);
    }
    else if (key == "9")
    {
        Console.WriteLine("Введите ключ");
        list.Remove(Console.ReadLine());
        print("list", list);
    }
    else if (key == "10")
    {
        list.Clear();
        print("list", list);
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
