using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Slowbat";
            int characterAge = 17;
            string characterThing = "OK I got it";
            string characterGit = "Slowbat200";
            string characterInsta = "slowbat201";
            string phrase = "|Hello I'm " + characterName;

            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine("|I'm " + characterAge + " years old");
            Console.WriteLine("|This is just my nickname\n|My real name is secret");
            Console.WriteLine("|This is my first big project\n|Currently I just want doing easy or medium programs");
            Console.WriteLine("|Okey my first program is Guess the number.");
            Console.WriteLine("|I mind the number and you try to guess my number.");
            Console.WriteLine("|You know the rules so we can start.");
            Console.WriteLine("|'Thinking...'" + characterThing);
            
            Random r = new Random();
            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("|Now you guess number from 0 to 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("|Aiming high, very high: Try again");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("|Too few. Please try again:");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("|Congrats you win");
                    win = true;
                }

                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("|Thanks for playing this nonsense game XD.");
            Console.WriteLine("|I hope you enjoyed this game and bye for now.");
            Console.WriteLine("|Oh I almost forgot, if you want to know source code check my Github:" + characterGit + ".");
            Console.WriteLine("|Or if you want to support me you can follow me in instagram:" + characterInsta + ".");
            Console.ReadKey(true);
            phrase = Console.ReadLine();

        }

    }
}
