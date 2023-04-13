int m=3;
int n = 4;
int max=9;
int min=1;

// int [,] GetRandomMatrix (int rows, int col, int min,int max){

//     Random rnd = new Random();

//     int [,] arr = new int [rows,col];

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {

//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j]= rnd.Next(min,max+1);
//         }
//     }
//     return arr;
// }


void PrintArrMatrix(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
            
        }
        Console.WriteLine();
    }
}


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int [,] GetRandomMatrix48 (int rows, int col){

    Random rnd = new Random();

    int [,] arr = new int [rows,col];

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]= i+j;
        }
    }
    return arr;
}

PrintArrMatrix(GetRandomMatrix48(4,3));