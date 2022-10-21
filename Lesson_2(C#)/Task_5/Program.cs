// прогр. которая принимает 2 числа и проверяет является ли 1 число квадратом второго.

int i = int.Parse(Console.ReadLine());
int j = int.Parse(Console.ReadLine());

if (i == Math.Sqrt(j)){      // Math.Pow(i,2) == j;  // i*i = j;
    Console.WriteLine(true);
}else{
    Console.WriteLine(false);
}






//Console.WriteLine("Hello, World!");
//using System;
//Console.WriteLine("Введите первое число");
//int aa = Convert.ToInt32(Console.ReadLine());
//int a = new Random().Next(100,999);

//Console.WriteLine("Введите второе число");
//int bb = Convert.ToInt32(Console.ReadLine());
//if(aa != bb*bb){
//Console.WriteLine("Числа не являются квадратами друг друга");
//}
//else{
//Console.WriteLine("Числа являются квадратами друг друга");
//}
//Console.WriteLine(a.ToString());
