// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); 2, 4 -> 16

System.Console.Write("Enter number A:  ");
int numA = int.Parse(Console.ReadLine());

System.Console.Write("Enter number B:  ");
int numB = int.Parse(Console.ReadLine());

int power = numA;

if (numB <= 0)
{
    System.Console.WriteLine("Error");
}
else
if (numB == 2)
{
    
     int result = numA*numA;
     System.Console.WriteLine(result);
}

else

{
//    System.Console.WriteLine(power);
}

 for (int i = 1; i < numB; i++)
{
    power = power * numA;

}


System.Console.WriteLine(power);



 

    
