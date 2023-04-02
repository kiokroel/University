using System.Collections;

void print(string name, Queue queue)
{
    Console.Write($"{name}: ");
    foreach (var i in queue)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine();
}

Queue queue = new Queue();
while (true)
{
    Console.WriteLine("Меню \n\n1.Добавить элемент в конец \n2.Очистить коллекцию \n3.Вернуть элемент из начала очереди \n4.Вернуть элемент из начала очереди и удалить его \n5.Вернуть массив копий элементов коллекции \n6.Проверить наличие элемента в коллекции \n7.Выход");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.Write("Введите элемент: ");
        Object obj = Console.ReadLine();
        queue.Enqueue(obj);
        print("queue", queue);
    }
    else if (key.Key == ConsoleKey.D2)
    {
        queue.Clear();
        print("queue", queue);
    }
    else if (key.Key == ConsoleKey.D3)
    {
        Console.WriteLine(queue.Peek());
        print("queue", queue);
    }
    else if (key.Key == ConsoleKey.D4)
    {
        Console.WriteLine(queue.Dequeue());
        print("queue", queue);
    }
    else if (key.Key == ConsoleKey.D5)
    {
        Array arr = queue.ToArray();
        print("queue", queue);
        Console.Write("Array: ");
        foreach(object i in arr)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
    }
    else if (key.Key == ConsoleKey.D6)
    {
        Console.Write("Введите элемент: ");
        Object obj = Console.ReadLine();
        if (queue.Contains(obj))
        {
            Console.WriteLine("Элемент содержится в коллекции");
        }
        else
        {
            Console.WriteLine("Элемент не содержится в коллекции");
        }
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
