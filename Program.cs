// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х

/*int number = new Random().Next(100,1000);
int result = (number%100)/10;
Console.WriteLine($"Вторая цифра {result} числа {number}");*/
 


// Задача 2: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Берем числа до 100000

/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res1 = (number%100)%10;
int res2 = (number%100)/10;
int res3 = (number/100)%10;

if (number >= 100 && number <= 999)
{    
    Console.WriteLine($"Третья цифра {res1} числа {number}");
}
else if (number >= 1000 && number <= 9999)
{
    Console.WriteLine($"Третья цифра {res2} числа {number}");
}
else if (number >= 10000 && number <= 99999)
{
    Console.WriteLine($"Третья цифра {res3} числа {number}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}*/


// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

/*Console.WriteLine("Введите цифру, обзначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if ( day >= 1 && day <= 5){
    Console.WriteLine("Этот день не является выходным");
}
else if(day >= 6 && day <= 7)
{
    Console.WriteLine("Этот день выходной");
}
    else
{
    Console.WriteLine("Не существует такого дня недели");
}*/

