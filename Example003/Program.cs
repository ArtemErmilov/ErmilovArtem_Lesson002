//Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    int a_Int = int.Parse(a_String);
    return a_Int;

}



int aInt1 = prompt("Введите число: ");

int aInt= Math.Abs(aInt1);
string numberString = aInt.ToString();
int number = numberString.Length;



if (number < 3)
{
    Console.WriteLine($"Вы ввели число {aInt1}, у которого нет 3-й цифры. ");
}

else

{
    

    int index = number-2;
    int bInt = 0;

    while (index > 0)
    {
        bInt = aInt % 10;
        aInt = aInt / 10;
        index--;
    }

    Console.WriteLine($"В числе {aInt1} 3-я цифра равняется {bInt}");
}