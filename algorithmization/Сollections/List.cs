using System.Collections;

void print(string name, List<string> list)
{
    Console.WriteLine($"{name}:");
    foreach (var i in list)
    {
        Console.Write($"{i}  ");
    }
    Console.WriteLine();
}
List<string> list = new List<string>();
while (true)
{
    Console.WriteLine("���� \n\n1.�������� ������� � ��������� \n2.�������� � ������ �������� �� ��������� c \n3.�������� ��������� ������ \n4.������ ������� ��������� ������� \n5.��������� ������� ��������� �� �������� \n6.���������� \n7.�������� ��������� \n8.���������� ��������, ���������� � ��������� \n9.������� ����� ��������� \n10.�����");
    string key = Console.ReadLine();
    if (key == "1")
    {
        Console.WriteLine("������� �������");
        list.Add(Console.ReadLine());
        print("list", list);
    }
    else if (key == "2")
    {
        List<string> c = new List<string>();
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
        Console.WriteLine("������ ��������: " + list.BinarySearch(Console.ReadLine()));
    }
    else if (key == "4")
    {
        Console.WriteLine(list.IndexOf(Console.ReadLine()));
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