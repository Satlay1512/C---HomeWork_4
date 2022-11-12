// Задача 3: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max+1);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write($" => {intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i] }");
    }
}

int len = 8;
int min = 0;
int max = 9;
int[] array = CreateArray(len, min, max);
printArray(array);
