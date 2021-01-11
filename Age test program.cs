using System;

namespace Age_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Okay " + name + ". Are you over 18? Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {             
                Console.WriteLine("You are too young to continue!");
            }
            else if (age > 18)
            {
                Console.WriteLine("You are over 18!");
            }
            else if (age == 18)
            {
                Console.WriteLine("You are exactly 18!");
            }
            else
            {
                Console.WriteLine("Error, error, error");
            }
            
            Console.ReadLine();

        }
    }
}
