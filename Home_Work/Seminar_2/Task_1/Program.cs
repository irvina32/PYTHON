/*// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());
Console.WriteLine(number);


int firstNumber = 0;
int secondNumder = 0;


firstNumber = number / 10;

Console.Write(firstNumber % 10);*/
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
int index = int.Parse(Console.ReadLine());
int array = n;

//int index = n;
//int n = array.Lenght;
//int array = index; //int.Parse(Console.ReadLine());
//int number = array;
//int[] array = index; //int[] array = index; 
//int number = array[n];
//int n = Array.Length;
int findindex = 2;

int currend_index = 0;//int currend_index = 0;
int currend_n = 0;
while (currend_index < findindex)
{
    if (currend_index == findindex)

    {
          Console.WriteLine(currend_n);
          //break;
    }
    currend_index++;  
}

