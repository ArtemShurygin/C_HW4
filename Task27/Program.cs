//Задача 27: Напишите программу,
//которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

int sum = 0;
Console.WriteLine("Введите число:");
int in_num = Convert.ToInt32( Console.ReadLine());
while (in_num >= 1 | in_num <= -1)
    {
    sum += (in_num % 10);
    in_num /= 10;
    }       
Console.WriteLine("Сумма цифр введенного числа ровна: " + Math.Abs(sum));
