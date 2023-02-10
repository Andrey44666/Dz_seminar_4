// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

 Console.WriteLine("Enter number: ");
 int number = int.Parse(Console.ReadLine());

 int SumNumber (int num ) {
   int i = 0;
     while (num > 0)
     {
        i = i + num % 10;
        num = num/10;
     }
     return i;
}

 System.Console.WriteLine(number + " -> " + SumNumber(number));






