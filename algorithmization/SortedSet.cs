void print(string name, SortedSet<string> sortedset)
{
    Console.Write($"{name}: ");
    foreach (var i in sortedset)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine();
}

SortedSet<string> sortedset = new SortedSet<string>();
while (true)
{
    Console.WriteLine("Меню \n\n1.Добавить элемент \n2.Очистить коллекцию \n3.Удалить элемент \n4.Минимальный элемент \n5.Максимальный элемент \n6.Вернуть массив копий элементов коллекции \n7.Проверить наличие элемента в коллекции \n8.Выход");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.Write("Введите элемент: ");
        string str = Console.ReadLine();
        sortedset.Add(str);
        print("SotedSet", sortedset);
    }
    else if (key.Key == ConsoleKey.D2)
    {
        sortedset.Clear();
        print("SortedSet", sortedset);
    }
    else if (key.Key == ConsoleKey.D3)
    {
        Console.Write("Введите элемент: ");
        string str = Console.ReadLine();
        sortedset.Remove(str);
        print("SortedSet", sortedset);
    }
    else if (key.Key == ConsoleKey.D4)
    {
        Console.WriteLine(sortedset.Min());
        print("SortedSet", sortedset);
    }
    else if (key.Key == ConsoleKey.D5)
    {
        Console.WriteLine(sortedset.Max());
        print("SortedSet", sortedset);
    }
    else if (key.Key == ConsoleKey.D6)
    {
        string[] array = new string[sortedset.Count()];
        sortedset.CopyTo(array);
        Console.Write("Array: ");
        foreach (string i in array)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
        print("SortedSet", sortedset);
    }
    else if (key.Key == ConsoleKey.D7)
    {
        Console.Write("Введите элемент: ");
        string str = Console.ReadLine();
        if (sortedset.Contains(str))
        {
            Console.WriteLine("Элемент содержится в коллекции");
        }
        else
        {
            Console.WriteLine("Элемент не содержится в коллекции");
        }
        print("SortedSet", sortedset);
    }
    else if (key.Key == ConsoleKey.D8)
    {
        break;
    }
    else
    {
        Console.WriteLine("Неизвестная команда");
    }
    Console.WriteLine("\nНажмите любую клавишу");
    Console.ReadKey();
    Console.Clear();
}