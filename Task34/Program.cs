// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int max, int min)
{
    int[] array = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000 );    
    }        
return array;
}

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      quantity++;
    }
  }
  return quantity;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length) Console.Write($"{array[i]},");
        else Console.Write(array[i]);

    }
    Console.WriteLine("]");
    }
  
    
int[] arr = CreateArrayRndInt(10, 100, 1000);
PrintArray(arr);
int quantity = QuantityPositive(arr);
Console.Write($"Количество четных чисел = {quantity}");

