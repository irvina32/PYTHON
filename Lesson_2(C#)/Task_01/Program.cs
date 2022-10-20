// прогр., кот.вывoдит случ. число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Random rnd = new Random()    - та же функция, что и в строке 4.

int number = new Random().Next(10, 99);

System.Console.WriteLine(number);

int firstNumber = 0;
int secondNumder = 0;

firstNumber = number/10;
secondNumder = number % 10;

if (firstNumber > secondNumder){
        System.Console.WriteLine(firstNumber);
} else {
        System.Console.WriteLine(secondNumder);
}


