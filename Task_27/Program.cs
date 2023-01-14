// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите первое число ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (num > 9)
{
Console.WriteLine($"Сумма цифр числа {num} равна {Sum(num)}");
}
else
{
   Console.WriteLine($"Введено однохначное число {num}"); 
}
int Sum (int number)
{
    int add = 0;
    int temp = 0;
    while (number > 0)
    {
        temp = number % 10;
        add = add + temp;
        number = number /10;
    }
    return add;
}