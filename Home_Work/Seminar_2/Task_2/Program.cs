

 Console.WriteLine("ВВедите число");
int number = int.Parse(Console.ReadLine());
int array = number;


{
    for (int i = 0; i <= number; i++)
    {
        int minPosition = i;
       
        if (minPosition < 0)
            Console.Read();
            Console.WriteLine("третьей цифры нет");
            

        if (minPosition >= 2)
            Console.Read();
            break;
            Console.WriteLine(number);
    }       
}
