using CarClassLibrary;
using System;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

            int action = chooseAction();
            
             while(action != 0)
            {
                Console.WriteLine("You typed {0}", action);

                switch(action)
                {
                    case 1:
                        Console.WriteLine("You choose to add a new car to the inventory");
                        string carMake = "";
                        string carModel = "";
                        string carColor = "";
                        bool Isnew ;
                        decimal carPrice = 0;


                        Console.WriteLine("What is the car make? ford, benz, toyota");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? venza,amg,ranger");           
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the car color? black, red, Oxblood");
                        carColor = Console.ReadLine();

                        Console.WriteLine("Is the Car New? Please enter true or false :");   
                        Isnew = Convert.ToBoolean(Console.ReadLine());

                        Console.WriteLine("What is the car price? ");
                        while (carPrice <= 0 || carPrice > 'a' && carPrice < 'z')
                        {
                            try
                            {
                                carPrice = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: {0}", ex.Message);
                                Console.WriteLine("What is the car price? ");
                            }
                        }

                     
                        Car newCar = new Car(carMake, carModel,carColor,Isnew,carPrice);

                        s.CarList.Add(newCar); 
                        printInventory(s);
                        break;

                    case 2:
                        Console.WriteLine("You have choosen to add a car to your shopping cart!");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to buy? (number) ");
                        int carChoosen;
                        try
                        {
                            carChoosen = int.Parse(Console.ReadLine());
                            
                            s.ShoppingList.Add(s.CarList[carChoosen]);
                        }
                        catch(ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("*************************************");
                            Console.WriteLine("Error: Selected Number outside cars listed number");
                            Console.WriteLine("*************************************");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("*************************************");
                            Console.WriteLine("Error: {0}", ex);
                            Console.WriteLine("*************************************");
                        }

                        printShoppingCart(s);

                        break;

                    case 3:
                        printShoppingCart(s);
                        Console.WriteLine("The total cost of your item is: $" + s.CheckOut());
                        break;

                    default:
                        break;

                }

                action = chooseAction();
            }
        }

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("Cars you have choosen to buy!");
            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("Car: #" + i + " " + s.ShoppingList[i]);
            }

        }

        private static void printInventory(Store s)
        {
            for(int i = 0; i < s.CarList.Count; i++)
            {
                Console.WriteLine("Car: #Number - " + i + " " + s.CarList[i]);
            }
        }

        public static int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) add to cart (3) checkout");
            try
            {
                choice = int.Parse(Console.ReadLine());
                if(choice > 3)
                {
                    Console.WriteLine("Please, input number within specified options");
                    return chooseAction();
                }
                return choice;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The Error is: {0}", ex);            
            }
            Console.ReadLine();
            return 0;
            
        }
    }
}
