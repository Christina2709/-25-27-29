/*Задача 25: Напишите цикл, который принимает на вход два
числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("Задача №25");
Console.WriteLine("Введите число A: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = int.Parse(Console.ReadLine());

int Exponentiation (int NumA, int DegreeB)
{
   int result = 1;
for (int i = 1; i<=DegreeB; i++)
{
    result = result * NumA;
}
    return result;
}
Console.WriteLine($"Число A в степени числа B:{Exponentiation(NumberA, NumberB)}");

/*Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Задача №27");
Console.WriteLine("Введите число A: ");
int NumberA = int.Parse(Console.ReadLine());

int Summ (int NumA)
{
   int result = 0;
for (int i = 0; i<NumA; NumA/=10)
{
    result = result + NumA%10;
}
    return result;
}
Console.WriteLine($"Сумма цифр в числе:{Summ(NumberA)}");


/*Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Задача №29");
Console.WriteLine("Введите массив из восьми элементов: ");
int[] Array = new int[8];

void FillArray (int[] collection)
{
     int length = collection.Length;
     for (int i = 0; i < length; i ++)
{
     collection[i] = new Random().Next(1, 8);
}
}

void PrintArray (int[] col)
{
     int count = col.Length;
     for (int position = 0; position < count; position ++)
{
Console.WriteLine(col[position]);
}
}
FillArray(Array);
PrintArray(Array);