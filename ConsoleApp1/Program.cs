using System;
class Product
{
    internal int productId;
    internal string productName;
    internal double price;
    internal string color;

    internal void display()
    {
        Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        Console.ReadLine();
    }
    internal Product()
    {
        Console.WriteLine("empty object initialization");
        Console.ReadLine();
    }
    internal Product(int productId, string productName, double price, string color)
    {
        Console.WriteLine("object initialization");
        Console.ReadLine();
        this.productId = productId;
        this.productName = productName;
        this.price = price;
        this.color = color;
    }
}
class productModel
{

    static void Main(string[] args)
        {
        Product product1;
        product1 = new Product();
        product1.productId = 1654;
        product1.productName = "mobile";
        product1.price = 51000;
        product1.color = "black";

        product1.display();
        Product product2;
        product2 = new Product(1234, "laptop", 63000, "blue");
        product2.display();

        product1 = new Product(16654, "mobile", 51000, "black");
        product1.display();


    }
    }
