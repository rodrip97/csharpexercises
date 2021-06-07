using System;


namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            System.Random rando = new System.Random();
            int randoN = rando.Next(1,10);
            bool answer = false; //This chekcs if answer is correct or not, as it stands it is false

            while (answer == false)
             { 

            Console.WriteLine("Please guess a number between 1 and 10");
                string result_value = Console.ReadLine();
                result = Convert.ToInt32(result_value); // added the variable string_result to stop endless loop

            if (result == Convert.ToInt32(randoN))
            {
                Console.WriteLine("Hey, You got it right");
                answer = true;
            }

            else
            {
                Console.WriteLine("Nope, Try again");
                answer = false;
            }
                if (answer == true)
                {
                    break;
                }

            }
        }
    }
}
