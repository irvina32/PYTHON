// See https://aka.ms/new-console-template for more information
// прогр., которая приним. число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("ВВедите число");

int number1 = int.Parse(Console.ReadLine());

if (number1 % 7 == 0 && (number1 % 23 == 0))
{
    Console.WriteLine("кратно 7 и 23"); 
}
 
        else
{
    Console.WriteLine("не кратно");
}