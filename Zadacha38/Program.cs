// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[8];

void FillRandomArray (double[] array) // метод создания массива вещественных чисел в диапозоне [0; 10]
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 10;
    }
}
void Print (double[] array) // метод для печати массива вещественных чисел в диапозоне [0; 10]
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 7))
        {
            Console.Write("{0,0:F2}", array[i]);
        }
        if (i < (array.Length - 1))
        {
            Console.Write("{0,5:F2}", array[i]);
        }
        else
        {
            Console.Write("{0,5:F2}", array[i]);
        }   
    }
}
FillRandomArray(array);
Console.Write("["); Print(array); Console.Write("] -> ");
void DefRandomArray (double[] array) // метод (будь он не ладен) для определения Max и Min значений массива и нахождения разницы между ними
{double minValue = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minValue)
    {
        minValue = array[i];
    }
}
double maxValue = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxValue)
    {
        maxValue = array[i];
    }
}
Console.WriteLine("{0,0:F2}", maxValue - minValue);
}
DefRandomArray(array);