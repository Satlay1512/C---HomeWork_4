// Задача 2: Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string msg)
{
    Console.Write(msg);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}
int numberDigit(double Digit)
{
    int count = 0;
    while (Digit >= 1)
    {
        Digit = Digit / 10;
        count++;
    }
    return count;
}
int[] GetArr(int count, int Digit)
{
    int[] number = new int[count];
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = (Digit / Convert.ToInt32((Math.Pow(10, count - i - 1)))) % 10;
    }

    return number;
}

void PrintArr(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]:f0} ");
    }
    Console.WriteLine();

}

int Sum(int[] array)
{

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}
int UserAnswer = Prompt("Please type a number =>  ");
int count = numberDigit(UserAnswer);
int[] array = GetArr(count, UserAnswer);
PrintArr(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма цифр числа => {Sum(array)}");