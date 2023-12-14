Console.WriteLine("Введите размерность массива");
int m = Convert.ToInt32 (Console.ReadLine());
int i, min, swap;
Console.WriteLine("Введите элементы масива");
int[] mass = new int[m];

    for (m = 0; m < mass.Length; m++)
    { 
    mass[m] = Convert.ToInt32(Console.ReadLine());
    }

for (i = 1; i < mass.Length - 1; i++)
{
    min = mass[i];
    swap = i;
    for (m = i + 1; m < mass.Length; m++)
    {
        if (m % 2 != 0 || m != 0)
        {
            if (mass[m] < min)
            {
                min = mass[m];
                swap = m;
            }            
        }    
    }
    mass[swap] = mass[i];
    mass[i] = min;
}

Console.WriteLine( "Вывод масива" );
for (m = 0; m < mass.Length; m++)
{
   Console.WriteLine($"{mass[m]}");
}
