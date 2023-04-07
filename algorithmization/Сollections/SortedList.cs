using System.Collections;

void print(string name, SortedList list)
{
    ICollection � = list.Keys;
    Console.WriteLine(name + ":");
    foreach (string str in �)
    {
        Console.WriteLine(str + ": " + list[str]);
    }
}

SortedList list = new SortedList();
while (true)
{
    Console.WriteLine("���� \n\n1.�������� ������� � ��������� \n2.�������� �� ������� ����� \n3.�������� �� ������� ��������\n4.���� �� ������� \n5.�������� �� ������� \n6.������ ����� \n7.������ ��������\n8.����� �������� �� ������� \n9.������� ������� �� ����� \n10.�������� ��������� \n11.�����");
    string key = Console.ReadLine();
    if (key == "1")
    {
        Console.WriteLine("������� ���� � ��������");
        list.Add(Console.ReadLine(), Console.ReadLine());
        print("list", list);
    }
    else if (key == "2")
    {
        Console.WriteLine("������� ����");
        if (list.ContainsKey(Console.ReadLine()))
        {
            Console.WriteLine("���� ����������� ���������");
        }
        else
        {
            Console.WriteLine("���� �� ����������� ���������");
        }
    }
    else if (key == "3")
    {
        Console.WriteLine("������� ��������");
        if (list.ContainsValue(Console.ReadLine()))
        {
            Console.WriteLine("�������� ����������� ���������");
        }
        else
        {
            Console.WriteLine("�������� �� ����������� ���������");
        }
    }
    else if (key == "4")
    {
        Console.WriteLine("������� ������");
        Console.WriteLine(list.GetKey(int.Parse(Console.ReadLine())));
        print("list", list);
    }
    else if (key == "5")
    {
        Console.WriteLine("������� ������");
        Console.WriteLine(list.GetByIndex(int.Parse(Console.ReadLine())));
        print("list", list);
    }
    else if (key == "6")
    {
        Console.WriteLine("������� ����");
        Console.WriteLine(list.IndexOfKey(Console.ReadLine()));
        print("list", list);
    }
    else if (key == "7")
    {
        Console.WriteLine("������� ��������");
        Console.WriteLine(list.IndexOfValue(Console.ReadLine()));
        print("list", list);
    }
    else if (key == "8")
    {
        Console.WriteLine("������� ������");
        list.SetByIndex(int.Parse(Console.ReadLine()), Console.ReadLine());
        print("list", list);
    }
    else if (key == "9")
    {
        Console.WriteLine("������� ����");
        list.Remove(Console.ReadLine());
        print("list", list);
    }
    else if (key == "10")
    {
        list.Clear();
        print("list", list);
    }
    else if (key == "11")
    {
        break;
    }
    else
    {
        Console.WriteLine("����������� �������");
    }
    Console.WriteLine("������� ����� �������");
    Console.ReadKey();
    Console.Clear();
}