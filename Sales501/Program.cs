using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cart cart = new Cart();
            string answer = "";
            DateTime date = new DateTime(2018, 10, 31);

            Console.WriteLine("What is your customer ID?");
            cart.customerID = Console.ReadLine();
            do
            {
                Console.WriteLine("Add Item (A) or Return Item(R)");
                string input = Console.ReadLine();
                if(input == "A" || input == "a")
                {
                    Console.WriteLine("What is the name of the product?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the cost of the product?");
                    double cost = Convert.ToDouble(Console.ReadLine());
                    Item newItem = new Item(cost, name);
                    cart.addItem(newItem);
                }else if (input == "R" || input == "r")
                {
                    Console.WriteLine("What is the name of the product?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the cost of the product?");
                    double cost = Convert.ToDouble(Console.ReadLine());
                    Item newItem = new Item(cost, name);
                    cart.itemReturn(newItem, date.Month);
                }
                Console.WriteLine("Would you like to add or return another item? Y or N");
                answer = Console.ReadLine();
            } while (answer == "Y" || answer == "Y");

            Console.WriteLine(cart.customerID, "'s total comes to $", cart.totalCost);

            string pay = "";
            do
            {
                Console.WriteLine("Pay now? Y or N");
                pay = Console.ReadLine();
                if(pay == "Y"||pay == "y")
                {
                    cart.pay();
                }
            } while (pay != "Y" || pay != "y");

            if(date.Day == 31)
            {
                Console.WriteLine("Rebate Check Sent: $", cart.rebateAmount, " Sent to ", cart.customerID);
            }
        }
    }
}
