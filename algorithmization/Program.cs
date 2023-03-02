/*рассматриваем организация институт (несколько классов)
обьекты
1 основные работники(преподователи): фио, предметы, история работы
2 вспомогательные работники:
3 управляющий персонал: приказы(касаются остальных, или всех)
4 студенты: фио, оценки

Интерфейс:
1 студенты с долгами (фио, предмет, преподователь(фио))
2 преподователь долг (список студентов и предметы)
3 приказы для студентов, для преподователей, для вспомогательного состава, общие(фио и должность того кто выдал)
4 выдать по предователю список дисциплин который он ведет
5 для каждого предодователя выдать общий стаж, и стаж на последнем месте
6 выход
условие (наследование)
организовать ввод всего или файл */


string[][] decree = new string[0][];
Student[] students = new Student[0];
Teacher[] teachers = new Teacher[0];
Support[] supps = new Support[0];
ManagingStaff[] ManSt = new ManagingStaff[0];

while (true)
{
    Console.Clear();
    Console.WriteLine("1.Добавить лицо\n2.Выборка\n3.Добавить указ\n0.Выход");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    Console.Clear();
    // 1.добавление объекта
    if (key.Key == ConsoleKey.D1)
    {
        while (true)
        {
            Console.WriteLine("1.Добавить преподователя\n2.Добавить вспомогательного работника\n3.Добавить управляющий персонал\n4.Добавить студента\n0.В меню");
            ConsoleKeyInfo key1;
            key1 = Console.ReadKey();
            // Добавление преgодователя 
            if (key1.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Array.Resize(ref teachers, teachers.Length + 1);
                teachers[teachers.Length - 1] = new Teacher();
                Console.Write("Введите ФИО преподователя: ");
                teachers[teachers.Length - 1].name = Console.ReadLine();
                Console.Write("Введите дату рождения преподователя: ");
                teachers[teachers.Length - 1].date = Console.ReadLine();
                Console.Write("Введите количество дисциплин: ");
                int k = int.Parse(Console.ReadLine());
                Array.Resize(ref teachers[teachers.Length - 1].disciplines, teachers[teachers.Length - 1].disciplines.Length + k);
                for (int i = 0; i < k; i++)
                {
                    Console.Write("Введите дисциплину: ");
                    teachers[teachers.Length - 1].disciplines[i] = Console.ReadLine();
                }
                Console.Write("Введите количество мест работы: ");
                k = int.Parse(Console.ReadLine());
                Array.Resize(ref teachers[teachers.Length - 1].PlacesOfWork, teachers[teachers.Length - 1].PlacesOfWork.Length + k);
                for (int i = 0; i < k; i++)
                {
                    Array.Resize(ref teachers[teachers.Length - 1].PlacesOfWork[i], 2);
                    Console.Write("Введите место работы: ");
                    teachers[teachers.Length - 1].PlacesOfWork[i][0] = Console.ReadLine();
                    Console.Write("Введите стаж: ");
                    teachers[teachers.Length - 1].PlacesOfWork[i][1] = Console.ReadLine();
                }

            }
            // Добавление вспомогательного работника
            if (key1.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Array.Resize(ref supps, supps.Length + 1);
                supps[supps.Length - 1] = new Support();
                Console.Write("Введите ФИО вспомогательного работника: ");
                supps[supps.Length - 1].name = Console.ReadLine();
                Console.Write("Введите дату рождения вспомогательного работника: ");
                supps[supps.Length - 1].date = Console.ReadLine();
            }
            // Добавление управляющего персонала
            if (key1.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Array.Resize(ref ManSt, ManSt.Length + 1);
                ManSt[ManSt.Length - 1] = new ManagingStaff();
                Console.Write("Введите ФИО упрявляющего персонала: ");
                ManSt[ManSt.Length - 1].name = Console.ReadLine();
                Console.Write("Введите дату рождения упрявляющего персонала: ");
                ManSt[ManSt.Length - 1].date = Console.ReadLine();
            }
            // Добавление студента
            if (key1.Key == ConsoleKey.D4)
            {
                Console.Clear();
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = new Student();
                Console.Write("Введите ФИО студента: ");
                students[students.Length - 1].name = Console.ReadLine();
                Console.Write("Введите дату рождения студента: ");
                students[students.Length - 1].date = Console.ReadLine();
                Console.Write("Введите количество оценок студента: ");
                int k = int.Parse(Console.ReadLine());
                Array.Resize(ref students[students.Length - 1].AcademicPerformance, students[students.Length - 1].AcademicPerformance.Length + k);
                for (int i = 0; i < k; i++)
                {
                    Array.Resize(ref students[students.Length - 1].AcademicPerformance[i], 3);
                    Console.Write("Введите ФИО преподователя: ");
                    students[students.Length - 1].AcademicPerformance[i][0] = Console.ReadLine();
                    Console.Write("Введите дисциплину: ");
                    students[students.Length - 1].AcademicPerformance[i][1] = Console.ReadLine();
                    Console.Write("Введите оценку: ");
                    students[students.Length - 1].AcademicPerformance[i][2] = Console.ReadLine();
                }
            }
            // 0.Выход
            Console.Clear();
            if (key1.Key == ConsoleKey.D0)
            {
                break;
            }
            Console.Clear();
        }
    }
    // 2.Выборки
    if (key.Key == ConsoleKey.D2)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.Студенты с долгами\n2.Список должников у преподователя\n3.Приказы\n4.Список дисциплин у преподователя\n5.Стаж преподователя\n0.В меню");
            ConsoleKeyInfo key1;
            key1 = Console.ReadKey();
            // 1.Студенты с долгами 
            if (key1.Key == ConsoleKey.D1)
            {
                Console.Clear();
                foreach (Student stud in students)
                {
                    foreach (string[] mark in stud.AcademicPerformance)
                    {
                        if (int.Parse(mark[2]) <= 2)
                        {
                            Console.WriteLine($"Студент: {stud.name}\n\tФИО преподователя: {mark[0]}\n\tДисциплина: {mark[1]}\n\tОценка: {mark[2]}");
                        }
                    }
                }
                Console.ReadKey();
            }
            // 2.Список должников у преподователя
            if (key1.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.Write("Введите ФИО преподователя: ");
                string? TeacherName = Console.ReadLine();
                foreach (Student stud in students)
                {
                    foreach (string[] mark in stud.AcademicPerformance)
                    {
                        if (int.Parse(mark[2]) <= 2 && TeacherName == mark[0])
                        {
                            Console.WriteLine($"Студент: {stud.name}\n\tДисциплина: {mark[1]}\n\tОценка: {mark[2]}");
                        }
                    }
                }
                Console.ReadKey();

            }
            // 3.Приказы
            if (key1.Key == ConsoleKey.D3)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1.Для студентов\n2.Для преподователей\n3.Для вспомогательного состава\n4.Общие\n5.Все\n0.Назад");
                    ConsoleKeyInfo key2_3;
                    key2_3 = Console.ReadKey();
                    Console.Clear();
                    // 1.Для студентов
                    if (key2_3.Key == ConsoleKey.D1)
                    {
                        foreach (string[] decr in decree)
                        {
                            if (decr[2] == "st")
                            {
                                Console.WriteLine($"Указ: {decr[1]}\n\tКем выдан: {decr[0]}");
                            }
                        }
                        Console.ReadKey();
                    }
                    // 2.Для преподователей
                    if (key2_3.Key == ConsoleKey.D2)
                    {
                        foreach (string[] decr in decree)
                        {
                            if (decr[2] == "t")
                            {
                                Console.WriteLine($"Указ: {decr[1]}\n\tКем выдан: {decr[0]}");
                            }
                        }
                        Console.ReadKey();
                    }
                    // 3.Для вспомогательного состава
                    if (key2_3.Key == ConsoleKey.D3)
                    {
                        foreach (string[] decr in decree)
                        {
                            if (decr[2] == "sup")
                            {
                                Console.WriteLine($"Указ: {decr[1]}\n\tКем выдан: {decr[0]}");
                            }
                        }
                        Console.ReadKey();
                    }
                    // 4.Общие
                    if (key2_3.Key == ConsoleKey.D4)
                    {
                        foreach (string[] decr in decree)
                        {
                            if (decr[2] == "a")
                            {
                                Console.WriteLine($"Указ: {decr[1]}\n\tКем выдан: {decr[0]}");
                            }
                        }
                        Console.ReadKey();
                    }
                    //5.Все
                    if (key2_3.Key == ConsoleKey.D5)
                    {
                        foreach (string[] decr in decree)
                        {
                            Console.WriteLine($"Указ: {decr[1]}\n\tКем выдан: {decr[0]}\n\tКому: {decr[2]}");
                        }
                        Console.ReadKey();
                    }
                    // 0.Назад
                    Console.Clear();
                    if (key2_3.Key == ConsoleKey.D0)
                    {
                        break;
                    }
                    Console.Clear();
                }

            }
            // 4.Список дисциплин у преподователя
            if (key1.Key == ConsoleKey.D4)
            {
                Console.Clear();
                Console.Write("Введите ФИО преподователя: ");
                string? teacher = Console.ReadLine();
                foreach (Teacher c in teachers)
                {
                    if (c.name == teacher)
                    {
                        foreach (string discipline in c.disciplines)
                        {
                            Console.WriteLine(discipline);
                        }
                    }
                }
                Console.WriteLine("Нажмите любую клавишу для возвращения");
                Console.ReadKey();
            }
            //5.Стаж преподователя
            if (key1.Key == ConsoleKey.D5)
            {
                Console.Clear();
                Console.Write("Введите ФИО преподователя: ");
                string? teacherName = Console.ReadLine();
                int WorkExperience = 0;
                foreach (Teacher teacher in teachers)
                {
                    if (teacher.name == teacherName)
                    {
                        foreach (string[] Work in teacher.PlacesOfWork)
                        {
                            WorkExperience += int.Parse(Work[1]);
                        }
                    }
                }
                Console.WriteLine($"\tСтаж преподователя: {WorkExperience}");
                Console.WriteLine("Нажмите любую клавишу для возвращения");
                Console.ReadKey();
            }
            // 0.В меню
            if (key1.Key == ConsoleKey.D0)
            {
                break;
            }
            Console.Clear();
        }
    }
    // 3.Добавление приказов
    if (key.Key == ConsoleKey.D3)
    {
        Array.Resize(ref decree, decree.Length + 1);
        Array.Resize(ref decree[decree.Length - 1], 3);
        Console.Write("Введите ФИО: ");
        decree[decree.Length - 1][0] = Console.ReadLine();
        Console.Write("Введите указ: ");
        decree[decree.Length - 1][1] = Console.ReadLine();
        Console.Write("Введите кому(a-все, st-студенты, t-преподователи, sup-вспомогательный персонал): ");
        decree[decree.Length - 1][2] = Console.ReadLine();
    }
    Console.Clear() ;
    // 0.Выход
    if (key.Key == ConsoleKey.D0)
    {
        break;
    }
}


// Общий класс
class Person
{
    public string? name;
    public string? date;
}

// Класс студентов
class Student : Person
{
    public string[][] AcademicPerformance = new string[0][];
}

// Класс преподователей
class Teacher : Person
{
    public string[] disciplines = new string[0];
    public string[][] PlacesOfWork = new string[0][];
}

// Класс вспомогательных работников
class Support : Person
{

}

// Класс управляющего персонала
class ManagingStaff : Person
{

}
