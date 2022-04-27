//Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.

void FillArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 34);
    }
}

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] mass = new int[8];
FillArray(mass);
PrintArray(mass);
