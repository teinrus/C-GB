
// Console.WriteLine("Vvedite chislo");
// string input = Console.ReadLine();

// int number = Convert.ToInt32(input);
// Console.WriteLine($"sqr {number**number}");


// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.WriteLine("Vvedite chislo 1");
// string input1 = Console.ReadLine();
// Console.WriteLine("Vvedite chislo 2");
// string input2 = Console.ReadLine();

// if ((Convert.ToInt32(input2)*Convert.ToInt32(input2))== Convert.ToInt32(input1)){
//     Console.WriteLine("да");
// }
// else 
// {
//     Console.WriteLine("нет");
// }



// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Vvedite chislo day");
string input1 = Console.ReadLine();
switch (Convert.ToInt32(input1)){
    case 1:
        Console.WriteLine("понедельник");
        break; 
    case 2:
        Console.WriteLine("вторник");
        break; 
    case 3:
        Console.WriteLine("среда");
        break; 
    case 4:
        Console.WriteLine("четверг");
        break; 
    case 5:
        Console.WriteLine("пятница");
        break; 
    case 6:
        Console.WriteLine("суббота");
        break; 
    case 7:
        Console.WriteLine("воскресенье");
        break;    
}
