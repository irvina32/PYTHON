// прогр., которая выводит случайцное трехзначное число и удаляет вторую цифру из него.

int number = new Random().Next(100, 999);

Console.WriteLine(number);

int FirstN = 0;
//int SecondN = 0;
int ThirdN = 0;

FirstN = number / 100;
ThirdN = number % 10;

Console.Write(FirstN * 10 + ThirdN);

//int number = new Random().Next(100, 999);
//int result = ((number / 10) * 10) + number % 10;
// Console.WriteLine(number);
// Console.WriteLine(result);
//System.Console.WriteLine($"Was {number}, Now {result});  - "Was" + number + "..." + result