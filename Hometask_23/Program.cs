// Задача 23.
// Напишите программу которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число\tЗначение в кубе");
if (num > 0)
{
    for(int i =1; i<=num;i++)
    {
            Console.WriteLine($"{i}\t{i*i*i}");
    }
}
else Console.WriteLine("Введено некорректное значение.");