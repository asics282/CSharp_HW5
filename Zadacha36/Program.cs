// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[8];

void FillRandomArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
}
void Print (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 1))
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }   
    }
}
FillRandomArray(array);
void SumOddArray (int [] array)
{
    int SumOdd = 0;
    for (int i = 1; i < array.Length; i = i + 2) // цикл для нечетных индексов массива
    {
    SumOdd = SumOdd + array[i];
    }
    Console.Write(SumOdd);
}
Console.Write("["); Print(array); Console.Write("] -> "); SumOddArray(array);