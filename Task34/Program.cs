// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int CheckingForCorrectnes(string str)
{
while (true)
{
Console.WriteLine(str);
string num=Console.ReadLine();
    if (int .TryParse(num, out int number) == false)
        Console.WriteLine("Вы ввели не число. Для корректной работы программы введите число!!!");
    else
    return number;
}
}
int[] ArrayRandom(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for ( int i = 0 ; i< length ; i ++)
        arr[i] = rnd.Next(100,1000);
    return arr;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)  
        Console.Write($"Массив имеет вид [{array[i]}, ");
        else 
            if (i < array.Length-1)
             Console.Write($"{array[i]}, ");
             else 
             Console.Write($"{array[i]}]");
    }
    Console.WriteLine();
}
int EvenElements (int [] array)
{
    int result=0;
    for (int i=0; i<array.Length; i++)
    if (array[i]%2==0)
        result=result+1;
    return result;
}
int length =CheckingForCorrectnes("Введите размерность массива : ");
int []arr_=ArrayRandom(length);
printArray(arr_);
int even=EvenElements (arr_);
Console.WriteLine($"Количество чётных чисел в массиве равно {even}");
