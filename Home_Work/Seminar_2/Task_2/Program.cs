Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
//Console.WriteLine(n);

if(n <= 99)
{   
    Console.WriteLine("третьей цифры нет");   
}

    if (n > 101 && n < 999){

    Console.WriteLine(n % 10);
}

if (n == 100 || n == 1000){

    Console.WriteLine(n % 10);
}

//Console.WriteLine(n1 % 10); //Console.WriteLine((n / 100) % 10);