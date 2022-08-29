// Задача 19.
// Напишите программу которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)    num *= -1;
if (num >= 10000 && num <= 99999)
{
    int pal_om = num;
    int a1 = pal_om % 10;
    int a2 = pal_om / 10 % 10;
    int a3 = pal_om / 100 % 10;
    int a4 = pal_om / 1000 % 10;
    int a5 = pal_om / 10000 % 10;
    pal_om = a1*10000 + a2*1000 + a3*100 + a4*10 + a5;

    if(num == pal_om) 
    {
        Console.WriteLine("Заданное число ЯВЛЯЕТСЯ ПАЛИНДРОМОМ.");
    }
    else Console.WriteLine("Заданное число НЕ ЯВЛЯЕТСЯ ПАЛИНДРОМОМ.");
}
else Console.WriteLine("Некорректное значение. Введите пятизначное число.");