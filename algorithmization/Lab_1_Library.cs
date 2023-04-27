book[] library = new book[0];
book[] data = new book[0];
while (true)
{
    Console.WriteLine("1.Добавить книгу \n2.Выборка \n9.Выход");
    string n = Console.ReadLine();
    Console.Clear();
    if (n == "1")
    {
        Console.WriteLine("1.Добавить информацию о книге \n2.Добавить дату выдачи,сдачи");
        string nn = Console.ReadLine();
        if (nn == "1")
        {
            Console.Clear();
            Array.Resize(ref library, library.Length + 1);
            Console.WriteLine("Введите ФИО автора: ");
            library[library.Length - 1] = new book();
            library[library.Length - 1].author = Console.ReadLine();
            Console.WriteLine("Введите название книги: ");
            library[library.Length - 1].name = Console.ReadLine();
            Console.WriteLine("Введите ID: ");
            library[library.Length - 1].id = int.Parse(Console.ReadLine());
            Console.WriteLine("Год издания: ");
            library[library.Length - 1].data_publication = int.Parse(Console.ReadLine());
            Console.WriteLine("Издательство: ");
            library[library.Length - 1].publication = Console.ReadLine();
            Console.WriteLine("Жанр: ");
            library[library.Length - 1].genre = Console.ReadLine();
            Console.Clear();
        }
        else if (nn == "2")
        {
            Console.Clear();
            Console.WriteLine("Введите ID: ");
            int id = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].id == id && data[i].d_delivery == null)
                {
                    k++;
                    Console.WriteLine("Дата сдачи (дд.мм.гггг): ");
                    data[data.Length - 1].d_delivery = Console.ReadLine();
                    Console.Clear();
                }
            }
            if (k == 0)
            {
                Array.Resize(ref data, data.Length + 1);
                data[data.Length - 1] = new book();
                data[data.Length - 1].id = id;
                Console.WriteLine("Дата выдачи (дд.мм.гггг): ");
                data[data.Length - 1].d_issue = Console.ReadLine();
                Console.WriteLine("Дата сдачи (дд.мм.гггг): ");
                data[data.Length - 1].d_delivery = Console.ReadLine();
                Console.Clear();
            }
        }

    }

    else if (n == "2")
    {
        while (true)
        {

            Console.WriteLine("1.По издательству \n2.По автору \n3.Книги на руках \n4.Книги на руках в интервале \n9.Выход в меню");
            string n2 = Console.ReadLine();
            if (n2 == "1")
            {
                Console.Clear();
                Console.WriteLine("Введите издательство: ");
                string n3 = Console.ReadLine();
                int k = 0;
                for (int i = 0; i < library.Length; i++)
                {
                    if (library[i].publication == n3)
                    {
                        k++;
                        Console.WriteLine($"ФИО автора: {library[i].author} \nНазвание книги: {library[i].name} \nID: {library[i].id} \nГод издания: {library[i].data_publication} \nИздательство: {library[i].publication} \nЖанр: {library[i].genre}");
                        for (int j = 0; j < data.Length; j++)
                        {
                            if (library[i].id == data[j].id)
                            {
                                Console.WriteLine($"Дата выдачи: {data[j].d_issue} Дата сдачи: {data[j].d_delivery}");
                            }
                        }
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("Нет такого издательства. Поробуйте снова:");
                }
            }
            else if (n2 == "2")
            {
                Console.Clear();
                Console.WriteLine("Введите ФИО автора: ");
                string n3 = Console.ReadLine();
                int k = 0;
                for (int i = 0; i < library.Length; i++)
                {
                    if (library[i].author == n3)
                    {
                        k++;
                        Console.WriteLine($"ФИО автора: {library[i].author} \nНазвание книги: {library[i].name} \nID: {library[i].id} \n Год издания: {library[i].data_publication} \nИздательство: {library[i].publication} \nЖанр: {library[i].genre}");
                    }
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (library[i].id == data[j].id)
                        {
                            Console.WriteLine($"Дата выдачи: {data[j].d_issue} Дата сдачи: {data[j].d_delivery}");
                        }
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("Нет книг такого автора");
                }
            }
            else if (n2 == "3")
            {
                Console.Clear();
                int k = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    if ((data[i].d_issue != "") && (data[i].d_delivery == ""))
                    {
                        k++;
                        for (int j = 0; j < library.Length; j++)
                        {
                            if (data[i].id == library[j].id)
                            {
                                Console.WriteLine($"ФИО автора: {library[i].author} \nНазвание книги: {library[i].name} \nID: {library[i].id} \n Год издания: {library[i].data_publication} \nИздательство: {library[i].publication} \nЖанр: {library[i].genre}");
                            }
                        }
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("Нет книг на руках");
                }
            }
            else if (n2 == "4")
            {
                Console.Clear();
                Console.WriteLine("Введите начало в формате дд.мм.гггг: ");
                DateTime start = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите конец в формате дд.мм.гггг: ");
                DateTime end = DateTime.Parse(Console.ReadLine());
                int k = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    DateTime d_issue = DateTime.Parse(data[i].d_issue);
                    if (data[i].d_delivery != "")
                    {
                        DateTime d_delivery = DateTime.Parse(data[i].d_delivery);
                        if ((d_issue <= end) && (d_delivery > end))
                        {
                            k++;
                            Console.WriteLine($"ФИО автора: {library[i].author} \nНазвание книги: {library[i].name} \nID: {library[i].id} \nГод издания: {library[i].data_publication} \nИздательство: {library[i].publication} \nЖанр: {library[i].genre}");
                        }
                    }
                    else
                    {
                        if (d_issue <= end)
                        {
                            k++;
                            Console.WriteLine($"ФИО автора: {library[i].author} \nНазвание книги: {library[i].name} \nID: {library[i].id} \nГод издания: {library[i].data_publication} \nИздательство: {library[i].publication} \nЖанр: {library[i].genre}");
                        }
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("В данный период не было книг на руках");
                }
            }
            else if (n2 == "9")
            {
                Console.Clear();
                break;
            }
        }
    }
    else if (n == "9")
    {
        break;
    }
}
public class book
{
    public string? author { get; set; } = "";
    public string? name { get; set; }
    public int id { get; set; }
    public int? data_publication { get; set; }
    public string? publication { get; set; }
    public string? genre { get; set; }
    public string? d_issue { get; set; }
    public string? d_delivery = null;
}
