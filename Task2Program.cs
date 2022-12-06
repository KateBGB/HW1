Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
if(a>b)
{
    Console.WriteLine($"Число {a} является большим, число {b} является меньшим");
}
else
{
   Console.WriteLine($"Число {b} является большим, число {a} является меньшим"); 
}
