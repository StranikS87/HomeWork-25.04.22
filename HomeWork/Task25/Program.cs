//Задача 25: Напишите цикл, который принимает на вход 
//два числа(A и B) и возводит число A в натуральную 
//степень B.


Console.WriteLine("Введите число А: ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numB = int.Parse(Console.ReadLine());
int result = 1;

for( int i = 1; i <= numB; i++)
{
    result = result * numA;
}
Console.WriteLine($"Возведение числа {numA} в степнь {numB} равно: {result}");

