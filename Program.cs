﻿//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i =0; i<size; i++){
        res[i]=new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]}");
        Console.WriteLine();
    }
    return res;
}
int[] array = GetArray(10, 100, 999);
Console.WriteLine();
int qua(int[] array){
    int quaEven =0;
    foreach(int el in array){
        if(el%2==0){
            quaEven+=1;
        }
    }
    return quaEven;
}
Console.WriteLine("Количество чётных элементов:");
Console.WriteLine(qua(array));
Console.WriteLine();
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array1 = GetArray(10, 1, 100);
Console.WriteLine();
int SumEl(int[] array1){
    int sumOdd=0;
    for(int i =0; i<array1.Length; i+=2){
        sumOdd+=array1[i];
    }
    return sumOdd;
}
Console.WriteLine("Сумма элементов на нечётных позициях:");
Console.WriteLine(SumEl(array1));
Console.WriteLine();

