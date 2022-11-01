

Console.WriteLine("введите  число");
string num = Console.ReadLine();
string rev = string.Concat(num.Reverse());

if (num == rev){

Console.WriteLine( "Число палиндром");}

else
{
    Console.WriteLine("Число не палиндром");
}
// Console.WriteLine(num == rev ? "палиндром" : "не палиндром");






// Console.WriteLine("Введите число");
// int n = int.Parse(Console.ReadLine());

// int temp = n;
// int rev = 0;
// int coef = 0;

// while (n > 0)

//      coef = n % 10;
//      rev = rev * 10 + coef;
//      n = (n / 10) / 10;

//     if (temp == rev){

//     Console.WriteLine("Это число палиндром");}

//         else
        
//     {
//     Console.WriteLine("это число не палиндром");
    
//     }

// Console.WriteLine();

// while (FirstN > 0){
//     temp = FirstN;
//     FirstN = SecondN;
//     SecondN = temp;

//     FirstN ++;
//     SecondN --;

//     if (FirstN == SecondN)
//     Console.WriteLine("это число палиндром");
    
//     else
//     Console.WriteLine("это число не палинтром");}




// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.


// System.Console.WriteLine("Ввод координат точки 1: ");
// int x1 = int.Parse(Console.ReadLine());
// int y1 = int.Parse(Console.ReadLine());
// int z1 = int.Parse(Console.ReadLine());
// // int [] array1 = new int[] {x1,y1,z1};

// System.Console.WriteLine("Ввод координат точки 2:  ");
// int x2 = int.Parse(Console.ReadLine());
// int y2 = int.Parse(Console.ReadLine());
// int z2 = int.Parse(Console.ReadLine());
// // int [] array2 = new int[] {x2,y2,z2};


// double result = Math.Sqrt(Math.Pow (x1 - x2,2) + 
//                 Math.Pow (y1 - y2,2) + 
//                 Math.Pow (z1 - z2,2) );

// System.Console.WriteLine($"Result is {result}");




// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("ВВедите число: ");

// int n = int.Parse(Console.ReadLine());


// for (int i = 1; i <= n; i++)

// {
//     Console.WriteLine(Math.Pow(i,3));
// }






