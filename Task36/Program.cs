// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int max, int min)
{
    int[] array = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-10, 100);    
    }        
return array;
}

int QuantityPositive(int[] array){
    int sum = 0;
    for (int i = 0; i<array.Length; i = i + 2){
//     if (array[i] % 2 == 0)
//     {
//       quantity++;
//     }
//   }
sum = sum+array[i]; 
    }
  return sum;
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
  
    
int[] arr = CreateArrayRndInt(10, -10, 100);
PrintArray(arr);
int sum = QuantityPositive(arr);
Console.Write($"Сумма элементов на нечетных индексах = {sum}");