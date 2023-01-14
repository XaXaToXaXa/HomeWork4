// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество случайных чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное чисело в массиве");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное возможное чисело в массиве");
int min = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size);
Console.WriteLine("[{0}]", string.Join(", ", array));

int[] GetArray(int arr_size)
{
    int[] result = new int[arr_size];
    for (int i = 0; i < arr_size; i++)
    {
        result[i] = new Random().Next(min - 1, max + 1);
        //result[i] = new Random().Next(100); 
    }

    return result;
}
