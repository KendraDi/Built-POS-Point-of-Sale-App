using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminalK.DiamondFebruary2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t                  GG           GG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t                GG           GG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t               GG           GG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t                     GG          GG ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t             CCCCCCCCCCCCCCCCCCCCCCCCC");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t            CCCCCCC           CCCCCCCCCCCCC");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t           CCCCCCCC              CC      CC ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t            CCCCCCC           CCCCCCCCCCCCC ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t             CCCCCCCCCcccCCCCCCCCCCCcC");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n                         K&K Sole Tique");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            List<Product> shoppingCart = new List<Product>();

            bool run = true;
            while (run == true)
            {           
                List<Product> shoeList = new List<Product>();
                shoeList.Add(new Product("Cole Haan", "Flats", "Leopard Multi Print", 140));
                shoeList.Add(new Product("Manolo", "Heels", "Glitter Rhinestone", 240));
                shoeList.Add(new Product("Cole Haan", "Boots", "Stretchy Leather Toe Tip", 340));
                shoeList.Add(new Product("Louboutin", "Wedges", "Open-Toe", 150));
                shoeList.Add(new Product("Nike", "Comfort", "Running Shoes", 160));
                shoeList.Add(new Product("Steve Madden", "Flats", "Penny Loafer", 75));
                shoeList.Add(new Product("Giuseppe", "Heels", "Sling-back Platform", 100));
                shoeList.Add(new Product("Steve Madden", "Boots", "Stretchy", 140));
                shoeList.Add(new Product("Via Spiga", "Wedges", "Peep-Toe", 85));
                shoeList.Add(new Product("Addidas", "Comfort", "Track Shoes", 65));
                shoeList.Add(new Product("Michael Kors", "Boots", "Lace-up", 140));
                shoeList.Add(new Product("Kenneth Cole", "Wedges", "Wrap-Around", 85));

                for (int i = 0; i < shoeList.Count; i++)

                {
                    Console.WriteLine($"{i + 1}:  {shoeList[i].Name}  {shoeList[i].Description}  {shoeList[i].Category}");

                }
                Console.WriteLine("=======================================");
                Console.WriteLine("Please select your shoe choice");

                int userSelection = int.Parse(Console.ReadLine());
         
                shoppingCart.Add(shoeList[userSelection - 1]);

                Console.WriteLine("Great! You have selected: " + shoeList[userSelection - 1].Name + " " + shoeList[userSelection - 1].Description);
                Console.WriteLine("What a bargain! The price of your selection is: {0:C2}", shoeList[userSelection - 1].Price);
  
                Console.WriteLine("Would you like to continue your shopping experience (y/n)?");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "n")
                {
                    run = false;

                    double subtotal = 0;
                    double tax;
                    double grandTotal;
                    double userChange;
   
                    for (int i = 0; i < shoppingCart.Count; i++)
                    {
                        subtotal = shoppingCart[i].Price + subtotal;

                    }
                    tax = subtotal * 0.06;

                    grandTotal = subtotal + tax;

                    Console.WriteLine("Your subtotal is: {0:C2}", subtotal);
                    Console.WriteLine("=====================================");
                    Console.WriteLine("Drumroll...your grand total including tax is: {0:C2}", grandTotal);
                    Console.WriteLine("Since you are paying with cash, please enter the amount. Please include the decimal.");
                    double userPayment = double.Parse(Console.ReadLine());
                    userChange = userPayment - grandTotal;
                    Console.WriteLine("Thank you for your payment. Your change is: {0:C2}", userChange);
                    Console.WriteLine("Here is your receipt. Please come shop with us again!");
  
                    for (int i = 0; i < shoppingCart.Count; i++)
                    {

                        Console.WriteLine("Items ordered: {0}, {1}", shoppingCart[i].Name, shoppingCart[i].Price);

                    }

                    Console.WriteLine($"Subtotal: {subtotal,0:C2}");
                    Console.WriteLine("Tax: {0:C2}", tax);
                    Console.WriteLine("Grandtotal: {0:C2}", grandTotal);
                    Console.WriteLine("Amount Paid: {0:C2}", userPayment);
                    Console.WriteLine("Change Rendered: {0:C2}", userChange);

                }

            }


        }
    }

}




