using CarClassLibrary;
using System;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

            int action = chooseAction();
             while(action != 0)
            {
                Console.WriteLine("You typed {0}", action);

                action = chooseAction();
            }
        }

        public static int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) add to cart (3) checkout");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("The Error is: {0}", ex.Message);            
            }
            Console.ReadLine();
            return choice;
        }
    }
}
