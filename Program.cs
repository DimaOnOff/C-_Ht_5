// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] startArray = GetArray(6, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetEvenCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}
//Неудачная попытка решения
//bool Check3elem = false;
//{
//    for (int i = 0; i < array.Length; i++)
//        if (array[i] % 2 == 0)
//		{
//        	Check3elem = true;
//			int count = 0;
//			count++;
//		}
//		return count;
//}
		
//Console.Write (Check3elem ? $"{count}" : "Not 3 intergers");


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

// int[] startArray = GetArray(6, 100, 999);

Console.Clear ();
int[] arrayMy = NewArray(4, 0, 100);//приравняли массив для вывода к Методу NewArray
Console.WriteLine(String.Join(",", arrayMy));
Console.WriteLine($"Sum of odd index = {SumOdd(arrayMy)}");


int[] NewArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size]; //создали массив
    for (int i = 0; i <size; i++) //задали цикл
    {
        result[i] = new Random().Next(minValue, maxValue + 1);//задали присвоение рандомных знаяений для элементов цикла
    }
    return result;
}

int SumOdd(int[] array)
{
    int Sum= 0;
    for (int i = 0; i <array.Length; i++)
    {
        if(i % 2==1)
        Sum +=array[i];
    }
    return Sum;
}


// Console.Clear ();
// startArray = GetArray(6, 0, 999);
// Console.WriteLine(String.Join(" ", startArray));
// Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(startArray)}");


// int GetSumOdd(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1) 
//         sum += array[i];
//     }
//     return sum;
// }


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.Clear ();
double[] startArrayDouble = GetArrayDouble(6, 0, 999);
Console.WriteLine(String.Join(" ", startArrayDouble));
Console.WriteLine($"Разница = {GetDifference(startArrayDouble)}");

double[] GetArrayDouble(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    var randon = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = randon.Next(minValue, maxValue + 1) + randon.NextDouble(); //45 + 45.456854368
    }
    return res;
}

double GetDifference(double[] array)
{
    double min = array [0];
    double max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}
