/* 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] initArray(int length)
{
    Random rnd = new Random();
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int CheckArray(int[] arr)
{
    int result = 0;
    foreach(var item in arr)
    {
        result += 1 - item % 2;
        if(!Convert.ToBoolean(item % 2))
            System.Console.Write("чет ");
        else
            System.Console.Write("неч ");
    }
    System.Console.WriteLine("");
    return result;
}
void PrintArray(int[] arr)
{
    foreach(var item in arr)
        System.Console.Write($"{item} ");
    System.Console.WriteLine("");
}

System.Console.Write("Введите размер массива");
int lengthArray = int.Parse(System.Console.ReadLine());
int[] arr = initArray(lengthArray);
System.Console.WriteLine("");
PrintArray(arr);
int result = CheckArray(arr);
System.Console.WriteLine("");
System.Console.WriteLine($"Количество четных чисел в массиве {result}");

