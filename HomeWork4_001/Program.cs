// Задача 1: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Prompt(string msg)
{
    Console.Write(msg);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}


int NaturalPower(int intBase, int intPower)
{
    if (intPower == 0) return 1;

    else return intBase * NaturalPower(intBase, intPower-1); // небольшая рекурсия
}

int A = Prompt("Введите число A:");
int B = Prompt("Введите степень числа:");
System.Console.Write("Степень равна:  ");
System.Console.WriteLine(NaturalPower(A, B));
