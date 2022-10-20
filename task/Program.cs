// Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа 
//в промежутке от M до N с помощью рекурсии.
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N с помощью рекурсии.


string task64 = "Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.";
string task66 = "Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.";
Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());
switch (task)
{
    case 64:
        var data64 = CheckData(task64);
        int data1 = Convert.ToInt32(data64.newStart);
        int data2 = Convert.ToInt32(data64.newEnd);
        Task64(data1, data2);
        break;
    case 66:
        var data66 = CheckData(task66);
        int m66 = Convert.ToInt32(data66.newStart);
        int n66 = Convert.ToInt32(data66.newEnd);
        int result = GetSum(m66,n66,m66);
        Console.WriteLine($"Сумма чисел от {m66} до {n66} равна {result}");
        break;

    default:
        Console.WriteLine("Неправильный ввод");
        break;
}
(int m, int n) Begin(string taskNumber)
{
    Console.Clear();
    Console.WriteLine(taskNumber);
    Console.Write("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return (m, n);
}
void Task64(int start, int end)
{
    if (start % 2 == 0)
    {
        Console.Write(start + ", ");
        start = start + 2;
    }
    else
    {
        start = start + 1;
        Task64(start, end);
    }

    if (start <= end)
    {
        Task64(start, end);
    }
}
(int newStart,int newEnd) CheckData(string task){
    var dataTask = Begin(task);
    int start1 = Convert.ToInt32(dataTask.m);
    int end1 = Convert.ToInt32(dataTask.n);
    if(start1 > end1){
        int temp = end1;
        end1 = start1;
        start1 = end1;
        return (start1,end1);
    } else return (start1,end1);
}
int GetSum(int start, int end, int sum)
{   if (start < end)
    {
        start++;
        sum = sum + start;
        return GetSum(start, end, sum);
        
    } else  return sum;
    
}