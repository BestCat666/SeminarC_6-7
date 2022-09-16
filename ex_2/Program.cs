// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника 
//меньше суммы двух других сторон.
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите тертье число: ");
int num3 = int.Parse(Console.ReadLine());
int TrangleMethod (int number1, int number2, int number3)
{
if(number2 < number1 + number3);
{
if(number3 < number1 + number2);
{
if (number3 < number1 + number2);
{
Console.WriteLine ($"да");
}
else
{
Console.WriteLine ($"нет");   
}
}
return number1;
}
}
TrangleMethod(num1,num2,num3);