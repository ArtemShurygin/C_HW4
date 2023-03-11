//Задача 29: Напишите программу,
//которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] arr = NewArray();
PrintArr(arr);

int[] NewArray()
    { 
    int[] Arr = new int[8]; 
    for (int i = 0; i < Arr.Length; i++) 
    Arr[i] = new Random().Next(0, 10); 
    return Arr; 
    } 

void PrintArr(int[] Arr)
    { 
    foreach (int i in Arr)
        Console.Write(i + " "); 
    } 