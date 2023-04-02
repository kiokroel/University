var myArray = Array.CreateInstance(typeof(int), 5);
for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
    myArray.SetValue(i + 1, i);
void print(string name, Array array)
{
    Console.WriteLine($"{name}:");
    foreach (var i in array)
    {
        Console.Write($"{i}  ");
    }
    Console.WriteLine();
}
while (true)
{
    Console.WriteLine("Меню \n1.Длина массива \n2.Алгоритм двоичного поиска\n3.Поиск по индексу \n4.Копирование массива \n5.Очищение массива \n6.Изменение порядка элементов на обратный \n7.Сортировка \n8.Создание нового массива \nESC - выход");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    Console.WriteLine();
    if (key.Key == ConsoleKey.D1)
    {
        Console.WriteLine("Длина массива - " + myArray.Length);
    }
    else if (key.Key == ConsoleKey.D2)
    {
        Console.WriteLine("Укажите элемент");
        Console.WriteLine("Индекс элемента - " + Array.BinarySearch(myArray, int.Parse(Console.ReadLine())));
    }
    else if (key.Key == ConsoleKey.D3)
    {
        Console.WriteLine("Введите индекс, максимальный - " + (myArray.Length - 1));
        Console.WriteLine("Полученный элемент - " + myArray.GetValue(int.Parse(Console.ReadLine())));
    }
    else if (key.Key == ConsoleKey.D4)
    {
        var myArray_2 = Array.CreateInstance(typeof(int), 5);
        for (int i = 1; i < 6; i++)
            myArray_2.SetValue(i, i - 1);
        Array.Copy(myArray, myArray_2, 5);
        print("myArray", myArray);
        print("myArray_2", myArray_2);
    }
    else if (key.Key == ConsoleKey.D5)
    {
        Array.Clear(myArray);
        print("myArray", myArray);
    }
    else if (key.Key == ConsoleKey.D6)
    {
        Array.Reverse(myArray);
        print("myArray", myArray);
    }
    else if (key.Key == ConsoleKey.D7)
    {
        Array.Sort(myArray);
        print("myArray", myArray);
    }
    else if (key.Key == ConsoleKey.D8)
    {
        Console.WriteLine("Введите размер массива");
        Array myArray_3 = Array.CreateInstance(typeof(int), int.Parse(Console.ReadLine()));
        for (int i = myArray_3.GetLowerBound(0); i <= myArray_3.GetUpperBound(0); i++)
            myArray_3.SetValue(i + 1, i);
        print("myArray_3", myArray_3);
    }
    else if (key.Key == ConsoleKey.Escape)
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
