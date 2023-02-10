// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.Write("Enter number A:  ");
int numA = int.Parse(Console.ReadLine());


if (numA > 9 & numA <= 99)
{
    int result = numA/10 + numA%10;
    System.Console.WriteLine(result);
}

if (numA > 99 & numA < 999)
{
    int numB = numA/100;
    int numC = numA%100;
    int result2 = numB + numC/10 + numC%10;
     System.Console.WriteLine(result2);
}

// else{
// System.Console.WriteLine($"countNumbers = {countNumbers(Number)}");
// }

// int countNumbers(int Num)
// {
//     int count = 0;
//     for(; Num > 0; count++)
//     {
//         Num = Num/10;
//     }
//     return count;

// }