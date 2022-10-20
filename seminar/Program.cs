// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от 1 до N с помощью рекурсии
using System.Globalization;

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
FollowNumbers(1,n);

void FollowNumbers(int start, int end){
    Console.Write(start +", ");
    start ++;
    if (start <= end){
        FollowNumbers(start,end);
    }
}



