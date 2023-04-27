while (true)
{
    Console.WriteLine("Меню\n\n1.Сумма\n2.Разница \n3.Произведение\n4.Деление\n0.Выход");

    Operations operation = (x,y) => 0;
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        operation = IMath.Sum;
    }
    if (key.Key == ConsoleKey.D2)
    {
        operation = IMath.Sub;
    }
    if (key.Key == ConsoleKey.D3)
    {
        operation = IMath.Mult;
    }
    if (key.Key == ConsoleKey.D4)
    {
        operation = IMath.Div;
    }
    if (key.Key == ConsoleKey.D0)
    {
        break;
    }
    Console.Write("Введите первое число: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine(operation(x, y));

    Console.WriteLine("Нажмите любую клавишу");
    Console.ReadKey();
    Console.Clear();
}

public interface IMath
{
    static public int Sum(int x, int y) => x + y;
    static public int Sub(int x, int y) => x - y;
    static public int Mult(int x, int y) => x * y;
    static public int Div(int x, int y) => x / y;
}

delegate int Operations(int x, int y);
