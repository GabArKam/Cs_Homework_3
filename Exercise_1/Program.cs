// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 9999 || x > 99999) Console.WriteLine("Введено некорректное число");
else if (x / 10000 == x % 10 && x / 1000 % 10 == x / 10 % 10) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не являяется палиндромом");
