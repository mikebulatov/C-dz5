
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Задача 36. Программа находит сумму элементов, стоящих на нечётных позициях одномерного массива, заполненный случайными числами.");
Console.Write("Введите колличесво элементов маассива:");
int [] mass=new int [Convert.ToInt32(Console.ReadLine())];

Console.Write("Сформированный массив:");
for(int i=0; i<mass.Length; i++)
{
    mass[i]= new Random().Next(0,10);
    Console.Write(mass[i]);
    Console.Write(" ");
}

Console.WriteLine();
int CountEven =0;
for(int i=1; i<mass.Length; i=i+2) CountEven=CountEven+mass[i];

Console.WriteLine($"Сумма элеменов массива стоящих на четных позициях:{CountEven}");