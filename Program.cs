internal class HashSetClass
{
    static Dictionary<string, int> products = new Dictionary<string, int>();
    static Dictionary<string, int> MarketProgram(string product, int price)
    {
        if (products.ContainsKey(product))
        {
            products[product] += price;
        }
        else
        {
            products.Add(product, price);
        }
        return products;
    }
    static void PrintProducts()
    {
        foreach (KeyValuePair<string, int> kvp in products)
        {
            Console.WriteLine("Product: " + kvp.Key);
            Console.WriteLine("Price: " + kvp.Value);
            Console.WriteLine("---------------------");
        }
    }
    private static void Main()
    {
        bool tryAgain = true;
        do
        {
            Console.WriteLine("Enter your product");
            string product = Console.ReadLine();
            Console.WriteLine("Enter product quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            HashSetClass.MarketProgram(product.Trim(), quantity);

            Console.WriteLine("Are you done (Yes or No)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes" || answer.ToLower() == "y")
            {
                HashSetClass.PrintProducts();
                tryAgain = false;

            }
            else if (answer.ToLower() == "no" || answer.ToLower() == "n")
            {
                tryAgain = true;
            }
            else
            {
                Console.WriteLine("Invalid Answer");
            }
        } while (tryAgain);

     

    }
}