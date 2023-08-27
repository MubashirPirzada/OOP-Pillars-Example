using OOP_Pillars_Example;

public class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("Web 3.0 By Zeeshan Usmani", 1500);
        ShoppingCartItem shoppingCartItem = new ShoppingCartItem(product, 2);
        Order obj = new Order();
        obj.AddItem(shoppingCartItem);
        Console.WriteLine("Calculate Total OrderPrice ,{0}", obj.CalculateTotalOrderPrice());
        Console.ReadLine();
    }
}
