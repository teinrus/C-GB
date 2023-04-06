// int size = 12;
// int[] nums = GetArray(size);
// Console.WriteLine(string.Join("; ", nums));

// int[] GetArray(int size)
// {
//     int[] result = new int [size];
//     Random rnd = new Random();
//     for(int i = 0; i < size; i++)
//         result[i] = rnd.Next(-9, 10);

//     return result;
// }

// int SumNumPlus(int[] array)
// {
// int result = 0;
// for(int i = 0; i < size; i++)
//     {
//         if(array[i] > 0)
//         {
//             result = result + array[i];
//         }
//     }
//     return result;
// }

// int SumNumMin(int[] array)
// {
// int result = 0;
// for(int i = 0; i < size; i++)
//     {
//         if(array[i] < 0)
//         {
//             result = result + array[i];
//         }
//     }
//     return result;
// }

// Console.WriteLine($"Сумма положительных чисел: {SumNumPlus(nums)}");
// Console.WriteLine($"Сумма отрицательных чисел: {SumNumMin(nums)}");

// Задача 35: Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// int size = 12;
// int[] nums = GetArray(size);
// Console.WriteLine(string.Join("; ", nums));

// int[] GetArray(int size)
// {
//     int[] result = new int [size];
//     Random rnd = new Random();
//     for(int i = 0; i < size; i++)
//         result[i] = rnd.Next(0, 200);

//     return result;
// }

// int Count (int[] array)
// {
// int count = 0;
// for(int i = 0; i < size; i++)
//     {
//         if(nums[i]>=10 && nums[i]<=99  )
//         {
//             count++;
//         } 
//     }
//     return count;
// }
// Console.WriteLine(string.Join("; ", Count(nums)));



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// 0 10

int size = 11;
int[] nums = GetArray(size);
Console.WriteLine(string.Join("; ", nums));

int[] GetArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        result[i] = rnd.Next(0, 10);

    return result;
}

int[] Proizved(int[] array)
{
 int size =array.Length / 2== 0 ? array.Length / 2:(array.Length / 2)+1;
 int [] mult = new int[size];
    
    for (int i = 0; i < size; i++){
        mult[i] = array[i] * array[array.Length - 1 - i];
    }
        
    if (array.Length % 2 == 1) mult[size-1] = array[array.Length / 2];

    return mult;
}

Console.WriteLine(string.Join(", ", Proizved(nums)));