// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

void DigitSum(int number)
{
    int sum = 0;
    int number2 = number;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.ForegroundColor = ConsoleColor.Cyan; 
    Console.WriteLine($"The summary of all digits in {number2} is {sum}.");
    Console.ResetColor();
}

Console.WriteLine("Please enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
DigitSum(number);