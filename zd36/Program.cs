

Console.WriteLine("Задача 36. Программа находит сумму элементов, стоящих на нечётных позициях одномерного массива, заполненный случайными числами.");
Console.Write("Введите колличесво элементов маассива:");
int [] mass=new int [Convert.ToInt32(Console.ReadLine())];

Console.Write("Сформированный массив:");
for(int i=0; i<mass.Length; i++)
{
    mass[i]= new Random().Next();
    Console.Write(mass[i]);
    Console.Write(" ");
}

Console.WriteLine();
int CountEven =0;
for(int i=0; i<mass.Length; i++)
{
if (Even(mass[i]))CountEven++;
}
Console.WriteLine($"Число четных элеменов массива:{CountEven}");