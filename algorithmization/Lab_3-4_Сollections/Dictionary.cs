void print(string name, Dictionary<string, string> dictionary)
{
    Console.WriteLine($"{name}: ");
    foreach (var i in dictionary)
    {
        Console.WriteLine(string.Format($"{i.Key,10}:{i.Value} "));
    }
    Console.WriteLine();
}

Dictionary<string, string> dictionary = new Dictionary<string, string>();
while (true)
{
    Console.WriteLine("Меню \n\n1.Добавить ключ и значение \n2.Удалить ключ \n3.Получить коллекцию ключей \n4.Получить коллекцию значений \n5.Проверить наличие ключа \n6.Проверить наличие значения \n7.Выход");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.Write("Введите ключ: ");
        string key_dict = Console.ReadLine();
        Console.Write("Введите значение: ");
        string value = Console.ReadLine();
        dictionary.Add(key_dict, value);
        print("dictionary", dictionary);
    }
    else if (key.Key == ConsoleKey.D2)
    {
        Console.Write("Введите ключ: ");
        string key_dict = Console.ReadLine();
        if (dictionary.Remove(key_dict))
        {
            Console.WriteLine("Ключ удален");
        }
        else
        {
            Console.WriteLine("Ключ отсутствует");
        }
        print("dictionary", dictionary);
    }
    else if (key.Key == ConsoleKey.D3)
    {
        Dictionary<string, string>.KeyCollection keys = dictionary.Keys;
        foreach(string key_dict in keys)
        {
            Console.Write($"{key_dict}, ");
        }
        print("dictionary", dictionary);
    }
    else if (key.Key == ConsoleKey.D4)
    {
        Dictionary<string, string>.ValueCollection values = dictionary.Values;
        foreach (string value in values)
        {
            Console.Write($"{value}, ");
        }
        print("dictionary", dictionary);
    }
    else if (key.Key == ConsoleKey.D5)
    {
        Console.Write("Введите ключ: ");
        string key_dict= Console.ReadLine();
        if (dictionary.ContainsKey(key_dict))
        {
            Console.WriteLine("Ключ существует");
        }
        else
        {
            Console.WriteLine("Ключ не существует");
        }
        print("dictionary", dictionary);
    }
    else if (key.Key == ConsoleKey.D6)
    {
        Console.Write("Введите значение: ");
        string value_dict = Console.ReadLine();
        if (dictionary.ContainsKey(value_dict))
        {
            Console.WriteLine("Значение содержится");
        }
        else
        {
            Console.WriteLine("Значение не содержится");
        }
        print("dictionary", dictionary);
    }
    else if (key.Key == ConsoleKey.D7)
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
