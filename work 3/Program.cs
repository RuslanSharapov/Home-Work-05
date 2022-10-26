// Написать программу копирования массива

int[] array = new int[10];
Console.Write("Original array: ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int arrayCopy;
Console.Write("Copy array: ");

for (int i = 0; i < array.Length; i++)
{
    arrayCopy = array[i];
    Console.Write($"{arrayCopy} ");
}
