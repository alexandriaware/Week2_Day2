﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops
            //For loops

            //for(int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.Write(counter);
            //}

            //string greeting = "My name is Little Bill";
            //string[] words = greeting.Split();

            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}


            ////Do it!
            //string weekdays = "Monday Tuesday Wednesday Thursday";
            //string[] days = weekdays.Split();

            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}


            //string beginning = "Once upon a time";
            //string[] storyWords = beginning.Split();

            //Array.Reverse(storyWords);

            //for(int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}


            //foreach loop
            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            //foreach (string month in months)
            //{
            //    Console.WriteLine(month);
            //}



            //string[] bands = { "Imagine Dragons", "Ed Sheeran", "Fall Out Boy", "Florence and The Machine", "HaleStorm" };

            //foreach(string artist in bands)
            //{
            //    Console.WriteLine(artist);
            //}


            ////Do it!
            //string[] menu = { "Ramen", "Peanut Butter", "Strawberries", "Brie", "Veggies" };

            //foreach(string food in menu)
            //{
            //    Console.WriteLine(food);
            //}



            //int[] numbers = { 3, 5, 7, 11, 13, 31 };

            //foreach(int luck in numbers)
            //{
            //    Console.WriteLine("Your Lucky Number is: " + luck);
            //}


            //int counter = 0;
            //while(counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //    Console.WriteLine("\a");
            //}


            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}



            //Console.WriteLine("Do you want to play the game? (YES/NO)");
            //string playAgain = Console.ReadLine();
            //while(playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine();
            //}


            //Console.WriteLine("Would you like to check the patient in for their appointment? (YES/NO)");
            //string answer = Console.ReadLine().ToUpper();
            //while(answer == "NO" || answer == "YES")
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    Console.WriteLine("Please enter your full name.");
            //    answer = Console.ReadLine();
            //    Console.WriteLine("Please enter your 6-digit patient ID");
            //    answer = Console.ReadLine();
            //    Console.WriteLine("Please enter your appointment time");
            //    answer = Console.ReadLine();
            //    Console.WriteLine("Would you like to check in another patient?");
            //    answer = Console.ReadLine().ToUpper();

            //}

            string playAgain;
            do
            {
                Console.WriteLine("Great game!");
                Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine().ToUpper();
            }
            while (playAgain == "YES");

            Console.WriteLine("Thanks for playing the game.");
            
        }
    }
}
