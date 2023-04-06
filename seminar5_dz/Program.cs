// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = 10;
int[] nums = GetArray(size);
Console.WriteLine(string.Join("; ", nums));

int[] GetArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        result[i] = rnd.Next(100, 999);

    return result;
}
int CountChet(int[] array)
{
    int count=0;
    for (int i = 0; i < size; i++){
       if (array[i]%2==0){
        count++;
       }
    }
    return count;
}
Console.WriteLine(CountChet(nums));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int NeChetPosition(int[] array)
{
    int sum=0;
    for (int i = 1; i < size; i+=2){
        sum+=array[i];
    }
    return sum;
}
Console.WriteLine(NeChetPosition(nums));


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
float[] numsF = GetArrayF(size);
Console.WriteLine(string.Join("; ", numsF));

float[] GetArrayF(int size)
{
    float[] result = new float[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        result[i] = rnd.Next(0, 100);

    return result;
}

float VechChisla(float[] array)
{
    float max=array[0];
    float min=array[0];
    for (int i = 1; i < size; i+=2){
       if (array[i]>max){
        max=array[i];
       }
       if (array[i]<min){
        min=array[i];
       }
    }
    return (max-min);
}
Console.WriteLine(VechChisla(numsF));