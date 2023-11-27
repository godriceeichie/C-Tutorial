using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;

public class CustomerProgram
{
    public List<Dictionary<string, string>> addCustomers()
    {
        List<Dictionary<string, string>> dictList = new List<Dictionary<string, string>>();

        Dictionary<string, string> customer1 = new Dictionary<string, string>();
        customer1.Add("id", "1");
        customer1.Add("name", "Alice");
        customer1.Add("totalAmountSpent", "150");
        customer1.Add("totalProductsPurchased", "5");


        Dictionary<string, string> customer2 = new Dictionary<string, string>();
        customer2.Add("id", "2");
        customer2.Add("name", "Bob");
        customer2.Add("totalAmountSpent", "100");
        customer2.Add("totalProductsPurchased", "3");

        Dictionary<string, string> customer3 = new Dictionary<string, string>();
        customer3.Add("id", "3");
        customer3.Add("name", "Charlie");
        customer3.Add("totalAmountSpent", "300");
        customer3.Add("totalProductsPurchased", "8");

        dictList.Add(customer1);
        dictList.Add(customer2);
        dictList.Add(customer3);

        


        return dictList;
    }

    public void output()
    {
        List<Dictionary<string, string>> Customers = addCustomers();
        foreach (var item in Customers)
        {
            string productsPurchased = item["totalProductsPurchased"];
            string totalAmount = item["totalAmountSpent"];

            int discount = 0;

            int productsPurchasedCount = Convert.ToInt32(productsPurchased);
            int totalAmountSpent = Convert.ToInt32(totalAmount);
            if (productsPurchasedCount > 4 && totalAmountSpent > 200)
            {
                discount = (int)(0.1 * totalAmountSpent) + 25;
            }
            else if (productsPurchasedCount > 4)
            {
                discount = (int)(0.1 * totalAmountSpent);
            }
            else if (totalAmountSpent > 200)
            {
                discount = 25;
            }

            item.Add("discountApplied", Convert.ToString(discount));
        }
        foreach (var customer in Customers)
        {
            Console.WriteLine("----------------------------");
            foreach (var item in customer)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }


        }
       
    }

    public static void Main(string[] args)
    {
        var mainCustomer = new CustomerProgram();
        mainCustomer.output();

        //    foreach (var item in mainCustomer.addCustomers())
        //    {
        //        string productsPurchased = item["totalProductsPurchased"];
        //        string totalAmount = item["totalAmountSpent"];
        //        int discount = 0;
        //        if (Convert.ToInt32(productsPurchased) > 4)
        //        {
        //            discount = (10 / 100) * Convert.ToInt32(totalAmount);
        //            item.Add("discountApplied", Convert.ToString(discount));
        //        }
        //        else if (Convert.ToInt32(totalAmount) > 100)
        //        {
        //            discount = 25;
        //            item.Add("discountApplied", Convert.ToString(discount));
        //        }
        //        else if (Convert.ToInt32(productsPurchased) > 4 && Convert.ToInt32(totalAmount) > 100)
        //        {
        //            discount = ((10 / 100) * Convert.ToInt32(totalAmount)) + 25;
        //            item.Add("discountApplied", Convert.ToString(discount));
        //        }
        //        else
        //        {
        //            item.Add("discountApplied", "0");
        //        }
        //    }
        //    foreach (var customer in mainCustomer.addCustomers())
        //    {
        //        foreach (var item in customer)
        //        {
        //            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        //            Console.WriteLine("----------------------------");
        //        }
        //    }
    }


}