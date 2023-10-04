using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        int lives;
        float Health;
        string jim;
        bool PlayerisAlive = true;
        double time;
        string toast;
        string pancakes;
        string choice = "";
        string playerchoice = "";

        class Playerchoice
        {
            public string name;
        }
        float multiple(float a, float b)
        {
            float result = a * b;
            return result;
        }
        int Greator(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine(a);
                return a;

            }
            else
            {
                Console.WriteLine(b);
                return b;
            }

        }

        int[] numbers = new int[3] {2,3,4};

        






        string Getinput(string prompt, string option1, string option2)
        {
            playerchoice = "";
            while(playerchoice != "1" && playerchoice != "2")
            {
                Console.WriteLine(prompt);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);

                playerchoice = Console.ReadLine();


            }
            return playerchoice;
        }
        void Addintegers(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
        //Reverse array
        void Reversearray(int[] numbers)
        {

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);

            }

        }

    
    void Fizzbuzz(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

        }
        public void Run()
        {
            Reversearray(numbers);
            //Addintegers(numbers);
            Fizzbuzz(15);
            Greator(4, 34);
            int Count = 1;
            Console.WriteLine("test");
            Console.WriteLine("Test2");

            Console.WriteLine("What is name");

            string firstname = Console.ReadLine() + " ";
            string lastname = Console.ReadLine();


            jim = firstname + lastname;

            Console.WriteLine(jim);

            int num1 = 2;
            int num2 = 3;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            //Swap Variables

            int num3 = 2;
            num1 = num2;
            num2 = num3;


            Console.WriteLine(num1);
            Console.WriteLine(num2);

            Console.WriteLine("Type Toast");

            toast = Console.ReadLine();
            pancakes = Console.ReadLine();

            if (toast == "Toast")
            {
                Console.WriteLine("EGG");
            }
            else if (pancakes == "Pancakes")
            {
                Console.WriteLine("Bacon");
            }

            bool Playerhasredkey = true;
            bool Playerhasgreenkey = true;
            bool GameOver = false;
            if (Health <= 0 || GameOver)
            {
                Console.WriteLine("GGGGGGGGGGGGGGGGGggggggggggggggggggggggggggggggggggggggggaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaammmmmmmmmmmmmmmmmmmmmmmmmmeeeeeeeeeeeeee ooooooooooooovvvvvvvvvvvvveeeeeeerrrrrrrr");
            }
            for (int i = 0; i <= 1000; i += 2)
            {
                Console.WriteLine(i);
            }

            while (choice != "1" && choice != "2")
            {
                choice = Console.ReadLine();
                Console.WriteLine("1. Knight");
                Console.WriteLine("2. Arsonist");
                if (choice == "1")
                {
                    Console.WriteLine("Knight is picked");

                }
                else if (choice == "2")
                {
                    Console.WriteLine("Arsonist is picked");
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }


        }
    }
}
                                                                                                     