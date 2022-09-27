// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

string Num(int a)
{
 if( a == 1 ) return "1";
 else return Num(a - 1) + a;
}
Console.WriteLine(Num(a)); 
