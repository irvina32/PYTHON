// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//int weekDay = int.Parse(Console.ReadLine());
/*return DateTime.WeekDay;

int number = int.Parse(Console.ReadLine());
int number1 = понедельник;
//int number1 = int.Parse(Console.ReadLine());
int number2 = вторник;
//int number2 = int.Parse(Console.ReadLine());
int number3 = среда;
//int number3 = int.Parse(Console.ReadLine());
int number4 = четверг;
//int number4 = int.Parse(Console.ReadLine());
int number5 = пятница;
//int number5 = int.Parse(Console.ReadLine());
int number6 = суббота;
//int number6 = int.Parse(Console.ReadLine());
int number7 = воскресенье;
//int number7 = int.Parse(Console.ReadLine());
Console.Write("Введи цифру, обозначающую день недели: ");

if (number == 6 || number == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (number < 1 || number > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("этот день не выходной");*/


  Console.Write("Введи цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());


void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) 
  Console.WriteLine("этот день выходной");
  
  else Console.WriteLine("этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);

