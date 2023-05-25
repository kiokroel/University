using System.Linq;


Console.WriteLine("Введите количество элементов ");
int n = int.Parse(Console.ReadLine());
List<int> nums = new List<int>();
for (int i = 0; i < n; i++)
{
    nums.Add(int.Parse(Console.ReadLine()));
}

var pos = from num in nums
          where num > 0
          select num;

var not_null = from num in nums
               where num != 0
               select num;

var chet = from num in nums
           where num % 2 == 0
           select num;

Console.WriteLine($"Сумма положительных: {pos.Sum()}");
Console.WriteLine($"Произведение не нулевых: {not_null.Aggregate((int x, int y) => x * y)}");
Console.WriteLine($"Количество четных: {chet.Count()}");
Console.WriteLine("................................");
int chet_count = chet.Count();

int nech_count = 0;
while (nech_count < nums.Count()) 
{
    if (nums[nech_count] % 2 == 1)
    {
        nums.RemoveAt(nech_count);
    }
    else
    {
        nech_count++;
    }
}

Console.WriteLine($"Сумма положительных: {pos.Sum()}");
Console.WriteLine($"Произведение не нулевых: {not_null.Aggregate((int x, int y) => x * y)}");
Console.WriteLine($"Количество четных: {chet.Count()}");
