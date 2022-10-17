// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[8];

void FillRandomArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
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
void EvenNumbersArray(int[] array)
{int evenNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
     
    if (array[i]%2 == 0)
    { 
        evenNumbers = evenNumbers + 1;
    }
}
Console.WriteLine(evenNumbers);
}
FillRandomArray(array);
Console.Write("["); Print(array); Console.Write("] -> "); EvenNumbersArray(array);