Console.WriteLine("Введите кол-во вершин:");
int n = int.Parse(Console.ReadLine());

double[,] graphs = new double[n,n];

for(int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        graphs[i,j] = double.Parse(Console.ReadLine());
        if (graphs[i, j] == 0)
        {
            graphs[i, j] = double.PositiveInfinity;
        }
    }
}

for (int i = 0;i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i != j)
        {
            for (int k = 0; k < n; k++)
            {
                if (k != j)
                {
                    graphs[j, k] = Math.Min(graphs[j, i] + graphs[i, k], graphs[j, k]);
                }
            }
        }
        
    }
}
for(int i = 0; i < n;i++)
{
    for(int j = 0; j < n; j++) 
    {
        Console.Write(graphs[i,j] + " ");
    }
    Console.WriteLine();
}
