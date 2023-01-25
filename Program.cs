// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// Решение 1
/*

double[,] array = GetArray(3, 4);
PrintArray(array);


// -------------------Методы задача 1---------------------------------
double[,] GetArray(int m, int n){
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = Math.Round((new Random().NextDouble()*10),1);
        }
    }
    return result;
}

void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
//Решение 2
/*
double[,] array = GetArray(3, 4,-10,10);
PrintArray(array);


// -------------------Методы задача 1---------------------------------
double[,] GetArray(int m, int n,int minValue, int maxValue){
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = Convert.ToDouble(new Random().Next(minValue, maxValue)) / 10;
        }
    }
    return result;
}

void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/


// Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, 
// а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите число для поиска ");
int numForSearch = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

bool numSearch = false;
foreach (int el in array)
{
    if (numForSearch == el)
    {
        numSearch = true;
        break;
    }
}
if (numSearch)
    Console.WriteLine($"Число {numForSearch} найдено");
else
    Console.WriteLine($"Число {numForSearch} не найдено");


*/

// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    double sumround = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
        sumround = Math.Round (sum / array.GetLength(0),2);
    }
    Console.WriteLine($"Среднее арифметическое столбца {j+1} = {sumround} ");
}


// -------------------Методы задача 2, 3 ---------------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
        
    }

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}