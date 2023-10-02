using System;
using System.Collections.Generic;
using System.Data;
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
        int Fizzbuzz(int n, int i)
        {
            if (i == 5*n)
            {
                Console.WriteLine("fizzbuz");
            }

        }
        public void Run()
        {

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

            if (toast == "toast")
            {
                Console.WriteLine("EGG");
            }
            else if (pancakes == "pancakes")
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
                                                                                                     