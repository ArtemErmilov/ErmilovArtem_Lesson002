// ДЗ 2.
// Задача 2: 
//Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int aInt = new Random().Next(100,1000);

int aInt1 = aInt;

int[] array = new int[3];
int index = 2;

while (aInt>0)
{
   array[index] = aInt % 10;
   aInt=aInt/10;
   index--;  
}

int result=array[0]*10+array[2];
//int result = ((aInt/100*10)+aInt%10);

Console.WriteLine($"Из числа {aInt1}  при удалении 2-е цифры получается число  {result} ");
