using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

void print(string name, Stack stack)
{
    Console.Write($"{name}: ");
    foreach (var i in stack)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine();
}

Stack stack = new Stack();
while (true)
{
    Console.WriteLine("Меню \n\n1.Добавить элемент в коллекцию \n2.Очистить коллекцию \n3.Вернуть элемент находящийся в вершине \n4.Вернуть элемент находящийся в вершине и удалить его \n5.Вернуть массив копий элементов коллекции \n6.Проверить наличие элемента в коллекции \n7.Доп.Задание \n8.Выход");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Console.Write("Введите элемент: ");
        stack.Push(Console.ReadLine());
        print("stack", stack);
    }
    else if (key.Key == ConsoleKey.D2)
    {
        stack.Clear();
        print("stack", stack);
    }
    else if (key.Key == ConsoleKey.D3)
    {
        print("stack", stack);
        Console.WriteLine(stack.Peek());
    }
    else if (key.Key == ConsoleKey.D4)
    {
        print("stack", stack);
        Console.WriteLine(stack.Pop());
        print("stack", stack);
    }
    else if (key.Key == ConsoleKey.D5)
    {
        Array array= stack.ToArray();
        Console.WriteLine(array);
        foreach (object i in array)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
    else if (key.Key == ConsoleKey.D6)
    {
        Console.Write("Введите элемент: ");
        object a = Console.ReadLine();
        if(stack.Contains(a)) 
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
        Console.Write("Введите последовательность: ");
        string str = Console.ReadLine();
        Stack stack1 = new Stack();
        var staples = new Dictionary<char, char>()
        {
            { '[', ']'},
            { '(', ')'},
            { '{', '}'}
        };
        bool Flag = true;
        foreach (char ch in str)
        {
            if (staples.ContainsKey(ch))
            {
                stack1.Push(ch);
            }
            else if (stack1.Count == 0 || staples[Convert.ToChar(stack1.Pop())] != ch)
            {
                Flag = false;
                break;
            }
        }
        if (Flag && stack1.Count == 0)
        {
            Console.WriteLine("Правильно");
        }
        else
        {
            Console.WriteLine("Неправильно");
        }

    }
    else if (key.Key == ConsoleKey.D8)
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
