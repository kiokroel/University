
while (true)
{
    Operations Function;
    Console.WriteLine("1.Минимальное число \n2.Максимальное число \n3.Сумма \n4.Произведение \n5.Среднее арифметическое \n6.Выход");

    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        Function = (x, y, z) => Min(x,Min(y,z));
    }
    else if (key.Key == ConsoleKey.D2)
    {
        Function = (x, y, z) => Max(x, Max(y, z));
    }
    else if (key.Key == ConsoleKey.D3)
    {
        Function = (x, y, z) => x + y + z;
    }
    else if (key.Key == ConsoleKey.D4)
    {
        Function = (x, y, z) => x * y * z;
    }
    else if (key.Key == ConsoleKey.D5)
    {
        Function = (x, y, z) => (x + y + z)/3;
    }
    else if (key.Key == ConsoleKey.D6)
    {
        break;
    }
    else
    {
        Console.WriteLine("Неизвестаная команда");
        break;
    }

    Console.Write("Введите первое число: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int y = int.Parse(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int z = int.Parse(Console.ReadLine());
    int res = Function(x, y, z);
    Console.WriteLine($"Результат: {res}");


    Console.Write("\nНажмите любую клавишу...");
    Console.ReadKey();
    Console.Clear();


}

static int Min(int x, int y) => x < y ? x : y;
static int Max(int x, int y) => x < y ? y : x;
delegate int Operations(int x, int y, int z);

