//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

Console.WriteLine("Веедите перdое число: ");
int num1 = int.Parse(Console.ReadLine());
int Method(int number)
{
    if(number % 2 != 0)
    {
    number = number % 2;
    Console.WriteLine ($"{number}");
    }
return number;
}
Method(number);

