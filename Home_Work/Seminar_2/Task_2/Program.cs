

/* Console.WriteLine("ВВедите число");
int number = int.Parse(Console.ReadLine());
//int array = number;


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
            Console.Write(number);
    }       
}*/
Console.Write("ВВедите число");
int number = int.Parse(Console.ReadLine());
//int index = 0;

//int number = n;

int digitIndex = 2; // индекс нужной цифры
//int find = digitIndex;

int index = 0;

for (int i = 0; i <= number; i++)

    {
        if  ((number < 2) && (number < digitIndex))
            
            Console.Read();
            Console.WriteLine("третьей цифры нет");
            
    
        //if (digitIndex >= 2)
         //   Console.Read();
            break;
            
    }
;
    //}

Console.WriteLine(number);




/*Console.WriteLine("Введите число ");
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
}*/


