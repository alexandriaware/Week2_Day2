using System;
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


            //Do it!
            string weekdays = "Monday Tuesday Wednesday Thursday";
            string[] days = weekdays.Split();

            for(int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }


            string beginning = "Once upon a time";
            string[] storyWords = beginning.Split();

            Array.Reverse(storyWords);

            for(int i = 0; i < storyWords.Length; i++)
            {
                Console.WriteLine(storyWords[i]);
            }
























            //for(int i = 0; i <= 10; i++)
            //{
            //    //Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    //Console.WriteLine(counter);
            //}


            //string greetings = "My name is Ali";
            //string[] words = greetings.Split();

            //for (int i =0 < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}



        }
    }
}
