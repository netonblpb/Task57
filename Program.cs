// Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int str = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int col = int.Parse(Console.ReadLine());

Random rnd = new Random();
int[,] startmass = new int[str, col];

for (int i = 0; i < str; i++)
{
    for (int j = 0; j < col; j++)
    {
        startmass[i, j] = rnd.Next(10, 100);
    }
}

void printmass(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

printmass(startmass);

int change = 0;

void minimum(int[,] maxmass)
{
    for (int i = 0; i < maxmass.GetLength(0); i++)
    {
        for (int j = 0; j < maxmass.GetLength(1); j++)
        {
            for (int k = j + 1; k < maxmass.GetLength(1); k++)
            {
                if (maxmass[i, j] < maxmass[i, k])
                {
                    change = maxmass[i, j];
                    maxmass[i, j] = maxmass[i, k];
                    maxmass[i, k] = change;                    
                }                
            }
            Console.Write(maxmass[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
minimum(startmass);
Console.WriteLine();
printmass(startmass);