// прогр. котор. приним. 2 числа и выводит. является ли 1 число кратно 2(/на 2)? если не кратно, 
//то программа выводит остаток.

Console.WriteLine("First Number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Second Number: ");
int b = int.Parse(Console.ReadLine());
int result = a % b;

if (result == 0){
    Console.WriteLine("успешно разделили a на  b");
}

   else
    {
       Console.WriteLine(result); 
    }
