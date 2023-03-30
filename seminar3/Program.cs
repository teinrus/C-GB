// Console.WriteLine("Vvedite chislo 1");
// int input1 =int.Parse(Console.ReadLine());

// if (input1==1){
//     Console.WriteLine($"в четверте {input1} X<0 Y<0 ");
// }else if (input1==2){
//     Console.WriteLine($"в четверте {input1} X<0 Y>0 ");
// }else if (input1==3){
//     Console.WriteLine($"в четверте {input1} X>0 Y<0 ");
// }else if (input1==4){
//     Console.WriteLine($"в четверте {input1} X>0 Y>0 ");
// }else{
//     Console.WriteLine($" {input1} в не четверте ");
// }
// System.Console.WriteLine();

// Console.WriteLine("Vvedite chislo 1");
// double input1 =double.Parse(Console.ReadLine());

// if (input1<100){
//     Console.WriteLine($"{input1+(input1*0.05)}");
// }else if (input1>=100 && input1<200 ){
//     Console.WriteLine($"{input1+(input1*0.07)}");
// }
// else if (input1>=200){
//     Console.WriteLine($"{input1+(input1*0.1)}");
// }
// Console.WriteLine("Vvedite chislo x1");
// double inputX1 =double.Parse(Console.ReadLine());
// Console.WriteLine("Vvedite chislo y1");
// double inputY1 =double.Parse(Console.ReadLine());
// Console.WriteLine("Vvedite chislo x2");
// double inputX2 =double.Parse(Console.ReadLine());
// Console.WriteLine("Vvedite chislo y2");
// double inputY2 =double.Parse(Console.ReadLine());

//  Console.WriteLine($"{ Math.Sqrt(Math.Pow(inputX2 -inputX1, 2) + Math.Pow(inputY2 - inputY1, 2)) } ");

Console.WriteLine("Vvedite chislo 1");
int input1 =int.Parse(Console.ReadLine());

for (int i = 1; i <= input1; i++)
{
    Console.Write($" {i*i}");
}