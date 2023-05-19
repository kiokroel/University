while (true)
{
    Console.WriteLine("Меню\n\n1.Сумма\n2.Разница \n3.Произведение\n4.Деление\n0.Выход");
    Operation oper = new Operation();
    oper.MyEvent += DisplayMessage;
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    Console.Write("Введите первое число: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int y = int.Parse(Console.ReadLine());
    Console.Clear();
    if (key.Key == ConsoleKey.D1)
    {
        oper.Sum(x, y);
    }
    if (key.Key == ConsoleKey.D2)
    {
        oper.Sub(x, y);
    }
    if (key.Key == ConsoleKey.D3)
    {
        oper.Mult(x, y);
    }
    if (key.Key == ConsoleKey.D4)
    {
        oper.Div(x, y);
    }
    if (key.Key == ConsoleKey.D0)
    {
        break;
    }
    Console.WriteLine();
    Console.Write("Нажмите любую клавишу...");
    Console.ReadKey();
    Console.Clear();
}


void DisplayMessage(string message) => Console.WriteLine(message);
delegate void EventDelegate(string message);
class Operation
{
    public delegate void EventDelegate(string message);
    public event EventDelegate? MyEvent;
    public void Sum(int x, int y)
    {
        int sum = x + y;
        MyEvent?.Invoke($"Сумма: {sum}") ;
    }
    public void Sub(int x, int y)
    {
        int sub = x - y;
        MyEvent?.Invoke($"Разница: {sub}");
    }
    public void Div(int x, int y)
    {
        if(y == 0)
        {
            MyEvent?.Invoke("Деление на 0");
            return;
        }
        int div = x / y;
        MyEvent?.Invoke($"Частное: {div}");
    }
    public void Mult(int x, int y)
    {
        int mult = x * y;
        MyEvent?.Invoke($"Произведение: {mult}");
    }
}
