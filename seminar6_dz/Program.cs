class Program
{
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
    static void Mchisla(){
            Console.Write("Vvedite chislo chres probel ");
            string input= Console.ReadLine();
            string[] arr = input.Split(' ');
            int result = 0;
            foreach (var item in arr)
            {
                if (Convert.ToInt32(item)>0){
                    result++;
                }

            }
            Console.WriteLine(result);
        }

// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    static void urovnenie(){
        Console.Write("Vvedite chislo chres probel ");

        string [] input= Console.ReadLine().Split(' ');
        
        double b1 = Convert.ToInt32(input[0]);
        double k1 = Convert.ToInt32(input[1]);
        double b2 = Convert.ToInt32(input[2]);
        double k2 = Convert.ToInt32(input[3]);

        double x = (-b2 + b1)/(-k1 + k2);
        double y = k2 * x + b2;

        Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
        }
    static void Main(string[] args)
    {
        Mchisla();
        urovnenie();


        
    }
}



// 1, -7, 567, 89, 223-> 3

