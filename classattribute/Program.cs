using System;
class Product
    {
    int productId;
    string productName;
    double price;
    string color;

    void display()
    {
        Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        Console.ReadLine();
    }
        static void Main(string[] args)
        {
        Product product1;
        product1 = new Product();
        product1.productId=1654;
        product1.productName = "mobile";
        product1.price = 51000;
        product1.color = "black";

        product1.display();

        }
    }
class ProductModel
{
    static void Main(string[] args)
    {
        Product product1;
        product1 = new Product();
        product1.productId = 166631;
        product1.productName = "laptop";
        product1.price = 63000;
        product1.color = "silver";

        product1.Display();

    }
}
