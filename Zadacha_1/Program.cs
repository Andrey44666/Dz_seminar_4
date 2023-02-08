// // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter first number: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int numB = int.Parse(Console.ReadLine());

int Number (int numA, int numB)
{
    int res = 1;
    for (int i = 1; i <= numB; i++)
    {
    res *= numA;
    }
    return res;
}
System.Console.WriteLine(Number (numA,numB));