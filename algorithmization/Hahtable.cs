using System.Collections;
using System.Collections.Generic;

void print(string name, Hashtable ht)
{
    ICollection с = ht.Keys;
    Console.WriteLine(name + ":");
    foreach (string str in с)
    {
        Console.WriteLine(str + ": " + ht[str]);
    }
}

Hashtable ht = new Hashtable();
while (true)
{
    Console.WriteLine("Меню \n\n1.Добавить элемент в хэш-таблицу \n2.Проверка на наличие ключа \n3.Проверка на наличие значения \n4.Получить коллекцию ключей \n5.Получить коллекцию значений \n6.Удаление элемента с указанным ключом \n7.Неполная копия \n8.Очищение хэш таблицы \n9.Неполная копия \n10.Выход");
    string key = Console.ReadLine();
    if (key == "1")
    {
        Console.WriteLine("Введите ключ и значение");
        ht.Add(Console.ReadLine(), Console.ReadLine());
        print("ht", ht);
    }
    else if (key == "2")
    {
        Console.WriteLine("Введите ключ");
        if (ht.ContainsKey(Console.ReadLine()))
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
        if (ht.ContainsValue(Console.ReadLine()))
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
        ICollection keys = ht.Keys;
        Console.WriteLine("keys: ");
        foreach (string s in keys)
            Console.WriteLine(s);
    }
    else if (key == "5")
    {
        ICollection values = ht.Values;
        Console.WriteLine("values: ");
        foreach (string s in values)
            Console.WriteLine(s);
    }
    else if (key == "6")
    {
        ht.Remove(Console.ReadLine());
        print("ht", ht);
    }
    else if (key == "7")
    {
        Hashtable ht_copy = new Hashtable();
        ht_copy = (Hashtable)ht.Clone();
        print("ht", ht);
        print("ht_copy", ht_copy);
    }
    else if (key == "8")
    {
        ht.Clear();
        print("ht", ht);
    }
    else if (key == "9")
    {
        Hashtable ht_copy = new Hashtable();
        ht_copy = (Hashtable)ht.Clone();
        print("ht", ht);
        print("ht_copy", ht_copy);
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
