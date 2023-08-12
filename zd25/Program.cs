// See https://aka.ms/new-console-template for more information

bool Even(int num)
{// фнукция определяет четное число или нет
if (num%2>0)return false;
else return true;
}

Console.WriteLine("Программа, которая покажет количество чётных чисел в массиве,заполненномы случайными положительными трёхзначными числами.");
Console.Write("Введите колличесво элементов маассива:");
int [] mass=new int [Convert.ToInt32(Console.ReadLine())];

Console.Write("Сформированный массив:");
for(int i=0; i<mass.Length; i++)
{
    mass[i]= new Random().Next(100,999);
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