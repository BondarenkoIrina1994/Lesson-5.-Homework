// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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
double ElementCorrectnes(string str)
{
while (true)
{
Console.WriteLine(str);
string num=Console.ReadLine();
    if (double.TryParse(num, out double number) == false)
        Console.WriteLine("Вы ввели не число. Для корректной работы программы введите число!!!");
    else
    return number;
}
}
void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)  
        Console.Write($"Массив имеет вид [{array[i]} ");
        else 
            if (i < array.Length-1)
             Console.Write($"{array[i]} ");
             else 
             Console.Write($"{array[i]}]");
    }
    Console.WriteLine();
}
double MaxElement (double [] array)
{
    double max=array[0];
    for (int i=1; i<array.Length; i++)
    if (max<array[i])
        max=array[i];
    return max;
}
double MinElement (double [] array)
{
    double min=array[0];
    for (int i=1; i<array.Length; i++)
    if (min>array[i])
        min=array[i];
    return min;
}
double [] Array (int length )
{
    double [] arr_=new double [length];
    for (int i=0;i<length;i++)
    arr_[i]=ElementCorrectnes($"Введите {i+1}-й элемент массима");
    return arr_;
}
int length =CheckingForCorrectnes("Введите размерность массива : ");
double [] array_=Array(length);
printArray(array_);
double difference=MaxElement(array_)-MinElement (array_);
Console.WriteLine($"Разность между max и min элементами массива равна {difference}");