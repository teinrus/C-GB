// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//         result[i] = rnd.Next(0, 10);

//     return result;
// }

// int[]arr=GetArray(13);
// Console.WriteLine($"{String.Join(",",arr)}");
// Array.Reverse(arr);
// Console.WriteLine($"{String.Join(",",arr)}");

// int[] MyRevers(int[] array)
// {
//     int [] result = new int[array.Length];

//     for (int i = 0; i < array.Length; i++)
//         result[i]=array[array.Length-1-i];

//     return result;
// }
// Console.WriteLine($"{String.Join(",",MyRevers(arr))}");

// void MyRever1(int[] array)
// {

//     for (int i = 0; i < array.Length/2; i++){
//         int temp=array[i];
//         array[i]=array[array.Length-1-i];
//         array[array.Length-1-i]=temp;
//     }


// }
// MyRever1(arr);
// Console.WriteLine($"{String.Join(",",arr)}");

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// bool Treug(int input1,int input2,int input3)
// {


//     if ((input1 + input2) > input3 && (input1 + input3) > input2 && (input3 + input2) > input1)
//     {
//                 return true;
//     }
//     else
//     {
//         return false;

//     }
// }
// Console.Write("Vvedite chislo 1 ");
// int input1 = int.Parse(Console.ReadLine());

// Console.Write("Vvedite chislo 2 ");
// int input2 = int.Parse(Console.ReadLine());

// Console.Write("Vvedite chislo 3 ");
// int input3 = int.Parse(Console.ReadLine());

// Console.WriteLine(Treug(input1,input2,input3) ? "не является": "не является");

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.Write("Vvedite chislo 1 ");
// int input1 = int.Parse(Console.ReadLine());
// Console.Write("sis ");
// int sis = int.Parse(Console.ReadLine());

// string DecToBin(int dec, int sis)
//     {
//         var otv = string.Empty;
//         while (dec > 0)
//         {
//             otv = (dec % sis) + otv;
//             dec /= sis;
//         }
//         return otv;
//     }

// Console.WriteLine(DecToBin(input1,sis));