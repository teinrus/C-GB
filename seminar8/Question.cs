using System;
using System.Linq;
namespace Happy
{
    public class Question
    {
        public string Quest;
        public List <string> Ans;
        public int TrueAns;

        public Question(List<string> str, int answer)
        {
            Quest = str[0];
            Ans = str.Skip(1).ToList(); 
            TrueAns = answer;       
        }

        public void Output()
        {
            Console.WriteLine(Quest);
            for(int i = 0; i < 4; i++)
                Console.WriteLine("{0}. {1}", i+1, Ans[i]);
        }
        public void Output50()
        {
            Random rnd = new Random ();
            
        while(true){
            int temp =rnd.Next(0,4);
            if (temp!=TrueAns && TrueAns>temp && (temp+1)!=TrueAns){
                Console.WriteLine(Quest);
                Console.WriteLine("{0}. {1}", temp+1, Ans[temp]);
                Console.WriteLine("{0}. {1}", TrueAns, Ans[TrueAns-1]);
                break;
            }
            if (temp!=TrueAns && TrueAns<temp) {
                Console.WriteLine(Quest);
                Console.WriteLine("{0}. {1}", TrueAns, Ans[TrueAns-1]);
                Console.WriteLine("{0}. {1}", temp+1, Ans[temp]);
                break;
    
            }
            
        }
            
            
        }
     
    }
}