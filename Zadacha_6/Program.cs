/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2==0)
{
    Console.WriteLine("Чётное число, так как при делении получается целое число"); 
}
else
{
    System.Console.WriteLine("Нечётное число ");
}