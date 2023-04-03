
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Vvedite chislo 1");
// int input1 =int.Parse(Console.ReadLine());

// if (input1<9999 || input1>100000){

//     Console.WriteLine("chislo 1 ne vernoe");
// }else{
//     if (input1%100==input1/1000){
//         Console.WriteLine("chislo 1 polimorf");
//     }else {
//         Console.WriteLine("chislo 1 ne polimorf");
//     }
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Vvedite chislo x1");
// double inputX1 =double.Parse(Console.ReadLine());
// Console.WriteLine("Vvedite chislo y1");
// double inputY1 =double.Parse(Console.ReadLine());
// Console.WriteLine("Vvedite chislo z1");
// double inputZ1=double.Parse(Console.ReadLine());

// Console.WriteLine("Vvedite chislo x2");
// double inputX2 =double.Parse(Console.ReadLine());
// Console.WriteLine("Vvedite chislo y2");
// double inputY2 =double.Parse(Console.ReadLine());
// Console.WriteLine("Vvedite chislo z2");
// double inputz2 =double.Parse(Console.ReadLine());

//  Console.WriteLine($"{ Math.Sqrt(Math.Pow((inputX2-inputX1), 2)+Math.Pow((inputY2-inputY1), 2) + Math.Pow((inputz2-inputZ1), 2))} ");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Vvedite chislo 1");
// int input1 =int.Parse(Console.ReadLine());

// for (int i = 1; i <= input1; i++)
// {
//     Console.Write($" {Math.Pow(i, 3)},");
// }
