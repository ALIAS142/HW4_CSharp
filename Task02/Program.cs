// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.Write("Enter number A:  ");
int numA = Convert.ToInt32(Console.ReadLine());



// if (numA > 9 & numA <= 99)
// {
//     int result = numA/10 + numA%10;
//     System.Console.WriteLine(result);
// }

// if (numA > 99 & numA < 999)
// {
//     int numB = numA/100;
//     int numC = numA%100;
//     int result2 = numB + numC/10 + numC%10;
//      System.Console.WriteLine(result2);
// }
// else 
// {

// }

int SumNumber(int numA)
{
    
 int counter = Convert.ToString(numA).Length;
 int advance = 0;
 int result3 = 0;
// Добавили для отрицательных чисел
 numA = Math.Abs(numA);   
 

for (int i = 0; i < counter; i++)
{
advance = numA - numA % 10;
result3 = (result3) + (numA - advance);
numA = numA / 10;
}
return result3;
}

int sumNumber = SumNumber(numA);
Console.WriteLine(sumNumber);
