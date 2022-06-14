// ДЗ 2.
//Задача 1: 
//Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите 3-х значное число: ");
string aString = Console.ReadLine();
int aInt = int.Parse(aString);

while (aInt <100 || aInt>=1000)
{
    Console.Write("Вы ввели не 3-х значное число, введите его заново: ");
    string a1String = Console.ReadLine();
    int a1Int = int.Parse(a1String);
    aInt=a1Int;
}

int result = (aInt/10)%10 ;

Console.WriteLine($"Второе число из {aInt} равняется  {result} ");