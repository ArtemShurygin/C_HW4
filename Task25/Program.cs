//Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите возводимое в степень число A:");
double A = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите степень числа B:");
double B = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("A^B=" + Math.Pow(A, B));

