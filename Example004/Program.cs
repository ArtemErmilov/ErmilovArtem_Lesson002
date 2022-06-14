// адача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели в виде числа от 1 до 7: ");
string aString = Console.ReadLine();
int aInt = int.Parse(aString);

while (0<aInt&&aInt>7)
{
    Console.Write("Вы ввели не то число,  введите число от 1 до 7 заново: ");
    string a1String = Console.ReadLine();
    int a1Int = int.Parse(a1String);
    aInt=a1Int;
}

if (aInt<=5)
{
  Console.WriteLine($"День недели под номером {aInt} НЕ является выходным. ");  
}
else
{
    Console.WriteLine($"День недели под номером {aInt} является выходным. ");
}


