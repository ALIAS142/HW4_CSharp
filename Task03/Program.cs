// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] array = {1, 2, 3, 4, 5, 6, 7, 8};
void FillArray (int[]array)
{


int n = array.Length;

int i = 0;

for( ; i < n; i++)
{
    int number = new Random().Next(0, 8);
    Console.WriteLine(number);
}


}

void PrintArray (int[]array)
{

}

FillArray(array);
PrintArray(array);