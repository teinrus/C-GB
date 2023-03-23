// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Vvedite chislo 1");

string input1 =Console.ReadLine();

Console.WriteLine("Vvedite chislo 2");

string input2 =Console.ReadLine();

if (Convert.ToInt32(input1)>Convert.ToInt32(input2)){
    Console.WriteLine($"input1: {input1} больше чем input2: {input2}");
}else{
    Console.WriteLine($"input2: {input2} больше чем input1: {input1}");
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Vvedite chisla cherez probel");

string input1 =Console.ReadLine();
string[] subs = input1.Split(' ');

int max=Convert.ToInt32(subs[0]);

foreach (var item in subs)
{
    if (Convert.ToInt32(item)>max){
        max = Convert.ToInt32(item);
    }
}

Console.WriteLine($"max chislo: {max}");

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Vvedite chislo");

string input1 =Console.ReadLine();

if ((Convert.ToInt32(input1))%2==0){
        Console.WriteLine($"chislo: {input1} chetnoe");
}else {
    Console.WriteLine($"chislo: {input1} ne chetnoe");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Vvedite chislo cherez probel");

string input1 =Console.ReadLine();
string otvet="";

for (int i = 0; i < Convert.ToInt32(input1)+1; i++)
{
    if (i%2==0){
        otvet+=Convert.ToString(i)+' ';
    }
}

Console.WriteLine($"chislo: {input1} soderget: {otvet} chetnih chisel");

