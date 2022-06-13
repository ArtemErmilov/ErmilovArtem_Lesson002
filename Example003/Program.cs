//Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string aString = Console.ReadLine();
int aInt = int.Parse(aString);

if (aInt < 100)
{
    Console.WriteLine($"Вы ввели число {aInt}, у которого нет 3-й цифры ");
}

else

{
    int contri = 10;
    int begin = aInt;
    double summ = 0;
    int div = 1;
    double x = 10;

    while (begin != 0) 
    {
        begin = aInt / contri;
        contri = contri * 10;
        summ++;
        
    }

    

    int sumWh1 = 0;
    int c1 = aInt;
    int c2 = 0;

    while (sumWh1 < 3)
    {
        div = Convert.ToInt32(Math.Pow(x, summ - 1));
        c2 = c1 / div;
        c1 = c1 - (c2 * div);

        sumWh1++;
        summ--;

    }


    Console.WriteLine($"В числе {aInt} 3-я цифра равняется {c2}");
}