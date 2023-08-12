
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.");
Console.Write("Введите колличесво элементов маассива:");
float [] mass=new float [Convert.ToInt32(Console.ReadLine())];

Console.Write("Сформированный массив:");
for(int i=0; i<mass.Length; i++)
{
    mass[i]= new Random().Next(0,10);
    mass[i]= mass[i] / new Random().Next(0,10);
    Console.Write(mass[i]);
    Console.Write(" ");
}

Console.WriteLine();
float MaxNum =mass[0];
float MinNum =mass[0];
for(int i=0; i<mass.Length; i++)
{
if (mass[i]>MaxNum) MaxNum=mass[i];
if (mass[i]<MinNum) MinNum=mass[i];
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива.:{MaxNum-MinNum}");