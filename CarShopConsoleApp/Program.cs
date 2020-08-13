using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program
    {
        static Store CarStore = new Store();
        static void Main(string[] args)
        {

            Console.Out.WriteLine("Welcome to the car store, first create some cars and add them to your inventory.");
            
            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("You chose" + action);

                switch (action)
                {
                    case 1:
                        Console.Out.WriteLine("You chose to add a new car to the store:");

                        String carMake = " ";
                        String carModel = " ";
                        Decimal carPrice = 0;

                        Console.Out.Write("What is the car make? Ford, GM, Toyota, etc.");
                        carMake = Console.ReadLine();

                        Console.Out.Write("What is the car model? Corvette, Focus, Ranger");
                        carModel = Console.ReadLine();

                        Console.Out.Write("What is the car price? Only numbers please");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car();
                        newCar.Make = carMake;
                        newCar.Model = carModel;
                        newCar.Price = carPrice;
                        CarStore.CarList.Add(newCar);

                        printStoreInventory(CarStore);
                        break;

                    //add to cart

                    case 2:
                        Console.WriteLine("You chose to add a car to your shopping cart");
                        printStoreInventory(CarStore);
                        Console.WriteLine("Which item would you like to buy(number)");
                        int carChosen = int.Parse(Console.ReadLine());
                        CarStore.ShoppingList.Add(CarStore.CarList[carChosen]);

                        printShoppingCart(CarStore);

                        break;
                    //checkout

                    case 3:
                        printShoppingCart(CarStore);
                        Console.WriteLine("The total cost is ${0} ", CarStore.checkout());
                        break;

                    default:
                        break;

                }


                action = chooseAction();
            }
        }

        static public void printShoppingCart(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in your shopping cart: ");
            int i = 0;
            foreach (var c in carStore.ShoppingList)
            {
                Console.Out.WriteLine(String.Format(c.Display));
                i++;
            }
        }

        private static void printStoreInventory(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in the store inventory: ");
            int i = 0;
            foreach (var c in carStore.CarList)
            {
                Console.Out.WriteLine(String.Format(c.Display));
                i++;
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action: (0) to quite (1) add car (2) add item to cart (3) checkout");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
