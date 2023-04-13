
string[] Parser(string primer, string[] otvet)
{
    int i = 0;

    foreach (var item in primer)
    {
        

        if (otvet[2] == null)
        {

            if (item == '+')
            {
                otvet[3] = "+";
                i++;
                continue;
            }

            if (item == '-')
            {
                otvet[3] = "-";
                i++;
                continue;
            }
            if (item == '/')
            {
                otvet[3] = "/";
                i++;
                continue;
            }
            if (item == '*')
            {
                otvet[3] = "*";
                i++;
                continue;
            }

            otvet[i] += item;

        }
        else
        {
            otvet[0] = otvet[2];
            otvet[3] = Convert.ToString(item); ;
            otvet[2] = null;
            otvet[1] = null;
            i++;

        }

    }
    return otvet;
}

string[] Deistvie(string[] arr)
{
    switch (arr[3])
    {
        case "+":
            double temp = Convert.ToDouble(arr[0]) + Convert.ToDouble(arr[1]);
            arr[2] = Convert.ToString(temp);
            break;
        case "-":
            temp = Convert.ToDouble(arr[0]) - Convert.ToDouble(arr[1]);
            arr[2] = Convert.ToString(temp);
            break;
        case "*":
            temp = Convert.ToDouble(arr[0]) * Convert.ToDouble(arr[1]);
            arr[2] = Convert.ToString(temp);
            break;
        case "/":
            temp = Convert.ToDouble(arr[0]) / Convert.ToDouble(arr[1]);
            arr[2] = Convert.ToString(temp);
            break;
    }
    return arr;


}


string[] otvet = new string[4];


while (true)
{
    System.Console.WriteLine("введите пример ");
    string primer = Console.ReadLine();

    while (true)
    {
        Deistvie(Parser(primer, otvet));
        System.Console.WriteLine(otvet[2]);

        System.Console.WriteLine("введите действие и число для обнуления с ");
        primer = Console.ReadLine();

        if (primer == "c")
        {
            System.Console.Clear();
            break;
        }

    }
    


}






