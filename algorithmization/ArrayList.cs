using System.Collections;

void print(string name, ArrayList list)
{
    Console.WriteLine($"{name}:");
    foreach (var i in list)
    {
        Console.Write($"{i}  ");
    }
    Console.WriteLine();
}
ArrayList list = new ArrayList();
while (true)
{
    Console.WriteLine("���� \n\n1.�������� ������� � ��������� \n2.�������� � ������ �������� �� ��������� c \n3.�������� ��������� ������ \n4.����������� ���������� ��������� � ������ array \n5.��������� ������� ��������� �� �������� \n6.���������� \n7.�������� ��������� \n8.���������� ��������, ���������� � ��������� \n9.������� ����� ��������� \n10.������ ������� ��������� ������� \n11.�����");
    string key = Console.ReadLine();
    if (key == "1")
    {
        list.Add(Console.ReadLine());
        print("list", list);
    }
    else if (key == "2")
    {
        ArrayList c = new ArrayList();
        string key_2;
        Console.WriteLine("������� �������� ��������� c");
        while (true)
        {
            c.Add(Console.ReadLine());
            Console.WriteLine("1.���������� \n2.�����");
            key_2 = Console.ReadLine();
            if (key_2 == "1")
            {

            }
            else if (key_2 == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("����������� �������");
                break;
            }
            Console.Clear();
        }
        list.AddRange(c);
        Console.Clear();
        print("c", c);
        print("list", list);
    }
    else if (key == "3")
    {
        Console.WriteLine("������� �������");
        Console.WriteLine("������ �������� - " + list.BinarySearch(Console.ReadLine()));
    }
    else if (key == "4")
    {
        var array = Array.CreateInstance(typeof(string), list.Count);
        list.CopyTo(array);
        print("list", list);
        Console.WriteLine("array");
        foreach (var i in array)
        {
            Console.Write($"{i}  ");
        }
        Console.WriteLine();
    }
    else if (key == "5")
    {
        list.Reverse();
        print("list", list);
    }
    else if (key == "6")
    {
        list.Sort();
        print("list", list);
    }
    else if (key == "7")
    {
        list.Clear();
        print("list", list);
    }
    else if (key == "8")
    {
        Console.WriteLine(list.Count);
    }
    else if (key == "9")
    {
        Console.WriteLine("������� ��������� ������ � ���������� ��������� ������� �� ������ �������");
        list.RemoveRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        print("list", list);
    }
    else if (key == "10")
    {
        Console.WriteLine(list.IndexOf(Console.ReadLine()));
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