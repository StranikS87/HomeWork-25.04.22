//Задача 27: Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = 0;

for ( int i = 0; i <= number; i++)
{
    result = result + i;
}

Console.WriteLine($"Сумма цифр числа {number} равно: {result}");
