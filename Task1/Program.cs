// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int num = 0;
int temp = 0;
int revNum  = 0;
int rem = 0;
Console.WriteLine("Введите число");
num = Convert.ToInt32(Console.ReadLine());
temp = num;
while (num>0) {
    rem = num % 10;
    revNum =revNum * 10 + rem ;
    num = num /10 ;
    }
if (revNum == temp)
Console.WriteLine($"Число {temp} - палиндромом");
else Console.WriteLine($"Число {temp} - не палиндромом");