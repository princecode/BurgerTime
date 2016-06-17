using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerTime
{
    class Program
    {
        static void Main(string[] args)
        {

            // Order a burger

            //This creates the Welcome and menu

            Console.WriteLine("Welcome to BurgerTime! Please Press <ENTER> to start your order.");

            Console.ReadKey();

            Console.WriteLine("Would you like a burger or a BURGER?!"); 

             string burgOrd = Console.ReadLine();


            while (!burgOrd == "burger" && "BURGER")
            {
                Console.WriteLine("You selceted a" + burgOrd + " . Please press <ENTER> to continue.");
                    

            }
            else
            {
                Console.WriteLine("Yeeaaah, we don't sell" + burgOrd + " . Please stick to the menu!!");

            }
           

            Console.ReadKey();

            






            // "Want Fries?" Y/N?           
            // If Y: order fries (maybe include actual options)
            //If N "want drink?" Y/N?        
            // pay cashier
            //return burger.Contains(burger);  <---- Might be able to use to print order and cost



            Console.ReadKey();


        }
    }
}
