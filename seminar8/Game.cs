using System;
namespace Happy
{
    class Game
    {
        

        List<Question> questions = new();

        public Game()
        {
            for (int i = 0; i < 15; i++)
                questions.Add(new Question(new List<string> {
                "Что растёт в огороде?",
                "Лук",
                "Пистолет",
                "Пулемёт",
                "Ракета"
              }, 1));

        }

        public void Run()
        {
             int record = 0;
            while (true)
            {
                int coins = 0;

                bool fiftyFifty = true;
                bool life = true;

                int sum = 0;
                int ind = 0;
               


                Console.WriteLine("Добро пожаловать в игру. Рекорд : {0}", record);
                foreach (var q in questions)
                {
                    Console.WriteLine("Ваша жизнь {0}.Подсказка {1}", life, fiftyFifty);
                    q.Output();

                    int ans = int.Parse(Console.ReadLine());

                    if (ans == 5 && fiftyFifty)
                    {
                        fiftyFifty = false;
                        q.Output50();
                        ans = int.Parse(Console.ReadLine());

                    }
                    if (ans == 5 && !fiftyFifty)
                    {
                        if (!life)
                        {
                            Console.WriteLine("Игра окончена!  Вы снова ввели неправильно У вас {0} очков!", coins);
                            System.Console.WriteLine();
                            break;
                        }

                        Console.WriteLine("Подсказки нет, пробуй ввсети еще раз");
                        ans = int.Parse(Console.ReadLine());
                        if (ans == 5)
                        {
                            life = false;
                            Console.WriteLine("Вы снова ввели неправильно! У вас {0} очков!У вас последняя жизнь", coins);
                            continue;
                        }

                    }

                    if (ans == q.TrueAns)
                    {
                        ind++;
                        coins += (int)Math.Pow(2, ind);
                        Console.WriteLine("Вы правы! У вас {0} очков!", coins);
                    }
                    else
                    {
                        if (life)
                        {
                            life = false;
                            Console.WriteLine("Вы не правы! У вас {0} очков!У вас последняя жизнь", coins);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                for (int i = 1; i < ind/5*5; i++)
                {
                    sum+= (int)Math.Pow(2, ind);
                }
                Console.WriteLine("Игра окончена! У вас {0} очков!",sum);
                System.Console.WriteLine();
                if (record < sum)
                    record = sum;
                
                


            }

        }
    }

}