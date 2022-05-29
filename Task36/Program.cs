// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
        arr[i] = rnd.Next(-100,101);
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
int SumOfOddElements (int [] array)
{
    int result=0;
    for (int i=0; i<array.Length; i++)
    if (i%2>0)
        result=array[i]+result;
    return result;
}
int length =CheckingForCorrectnes("Введите размерность массива : ");
int []arr_=ArrayRandom(length);
printArray(arr_);
int sum=SumOfOddElements(arr_);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях, равна {sum}");
