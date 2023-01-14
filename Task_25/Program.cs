// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите первое число ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите второе число ");
int rate = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Число {num} возведенное в степень {rate} равно {task(num, rate)}");

int task(int number, int degree)
{
    int result = number;
    for (int i = 1; i < degree; i++)
    {
        result = result * number;
    }
    return result;
}
