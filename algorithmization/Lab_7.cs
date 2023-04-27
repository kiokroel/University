Storage<int> intValues = new Storage<int>();
Storage<string> stringValues = new Storage<string>();


//Пример работы методов

intValues.AddValue(1234);
stringValues.AddValue("1234");

intValues.AddValue(1111);
stringValues.AddValue("qwerty");

Console.WriteLine(intValues.GetValue(0));
Console.WriteLine(stringValues.GetValue(0));
Console.WriteLine(intValues.GetValue(1));
Console.WriteLine(stringValues.GetValue(1));

intValues.RemoveValue(0);
stringValues.RemoveValue(0);

Console.WriteLine(intValues.GetValue(0));
Console.WriteLine(stringValues.GetValue(0));


class Storage<T>
{
    List<T> values = new List<T>();

    public void AddValue(T value)
    {
        if (values != null)
        {
            values.Add(value);
        }
        else
        {
            Console.WriteLine("Данный массив пустой");
        }
    }

    public void RemoveValue(int n)
    {
        if (values != null)
        {
            values.RemoveAt(n);
        }
        else
        {
            Console.WriteLine("Данный массив пустой");
        }
    }

    public void RemoveValue(T value)
    {
        if (values != null)
        {
            values.Remove(value);
        }
        else
        {
            Console.WriteLine("Данный массив пустой");
        }
    }

    public T GetValue(int n)
    {
        return values[n];
    }
}

