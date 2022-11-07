// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] array = RandomArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] RandomArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}


// вариант, когда количестов элементов массива вводится с клавиатуры
// Console.Clear();
// Console.WriteLine("Please enter the number of massive elements: "); 
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = RandomArray(number); 

// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] RandomArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(1, 100);
//     }
//     return result;
// }