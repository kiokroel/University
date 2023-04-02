using System.Collections;
using System.Collections.Generic;

void print(string name, Hashtable ht)
{
    ICollection � = ht.Keys;
    Console.WriteLine(name + ":");
    foreach (string str in �)
    {
        Console.WriteLine(str + ": " + ht[str]);
    }
}

Hashtable ht = new Hashtable();
while (true)
{
    Console.WriteLine("���� \n\n1.�������� ������� � ���-������� \n2.�������� �� ������� ����� \n3.�������� �� ������� �������� \n4.�������� ��������� ������ \n5.�������� ��������� �������� \n6.�������� �������� � ��������� ������ \n7.�������� ����� \n8.�������� ��� ������� \n9.�������� ����� \n10.�����");
    string key = Console.ReadLine();
    if (key == "1")
    {
        Console.WriteLine("������� ���� � ��������");
        ht.Add(Console.ReadLine(), Console.ReadLine());
        print("ht", ht);
    }
    else if (key == "2")
    {
        Console.WriteLine("������� ����");
        if (ht.ContainsKey(Console.ReadLine()))
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
        if (ht.ContainsValue(Console.ReadLine()))
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
        ICollection keys = ht.Keys;
        Console.WriteLine("keys: ");
        foreach (string s in keys)
            Console.WriteLine(s);
    }
    else if (key == "5")
    {
        ICollection values = ht.Values;
        Console.WriteLine("values: ");
        foreach (string s in values)
            Console.WriteLine(s);
    }
    else if (key == "6")
    {
        ht.Remove(Console.ReadLine());
        print("ht", ht);
    }
    else if (key == "7")
    {
        Hashtable ht_copy = new Hashtable();
        ht_copy = (Hashtable)ht.Clone();
        print("ht", ht);
        print("ht_copy", ht_copy);
    }
    else if (key == "8")
    {
        ht.Clear();
        print("ht", ht);
    }
    else if (key == "9")
    {
        Hashtable ht_copy = new Hashtable();
        ht_copy = (Hashtable)ht.Clone();
        print("ht", ht);
        print("ht_copy", ht_copy);
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