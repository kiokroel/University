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
    Console.WriteLine("Ìåíþ \n\n1.Äîáàâèòü ýëåìåíò â êîëëåêöèþ \n2.Äîáàâèòü â ñïèñîê ýëåìåíòû èç êîëëåêöèè c \n3.Àëãîðèòì äâîè÷íîãî ïîèñêà \n4.Ñêîïèðîâàòü ñîäåðæèìîå êîëëåêöèè â ìàññèâ array \n5.Èçìåíåíèå ïîðÿäêà ýëåìåíòîâ íà îáðàòíûé \n6.Ñîðòèðîâêà \n7.Î÷èùåíèå êîëëåêöèè \n8.Êîëè÷åñòâî îáúåêòîâ, õðàíÿùèõñÿ â êîëëåêöèè \n9.Óäàëèòü ÷àñòü êîëëåêöèè \n10.Èíäåêñ ïåðâîãî âõîæäåíèÿ îáúåêòà \n11.Âûõîä");
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
        Console.WriteLine("Ââåäèòå ýëåìåíòû êîëëåêöèè c");
        while (true)
        {
            c.Add(Console.ReadLine());
            Console.WriteLine("1.Ïðîäîëæèòü \n2.Âûõîä ");
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
                Console.WriteLine("Íåèçâåñòíàÿ êîìàíäà");
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
        Console.WriteLine("Óêàæèòå ýëåìåíò");
        Console.WriteLine("Èíäåêñ ýëåìåíòà - " + list.BinarySearch(Console.ReadLine()));
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
        Console.WriteLine("Ââåäèòå íà÷àëüíûé èíäåêñ è êîëè÷åñòâî ýëåìåíòîâ êîòîðûå âû õîòèòå óäàëèòü");
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
        Console.WriteLine("Íåèçâåñòíàÿ êîìàíäà");
    }
    Console.WriteLine("Íàæìèòå ëþáóþ êëàâèøó");
    Console.ReadKey();
    Console.Clear();
}
