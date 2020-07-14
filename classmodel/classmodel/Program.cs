using System;

class Product
{
    internal int productId;
    internal string productName;
    internal double price;
    internal string color;

    internal void Display()
    {
        Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        Console.ReadLine();
    }
}
class ProductModel
{

      static void Main(string[] args)
      {
        Product product1;
   
        product1 = new Product();
        product1.productId = 1654;
        product1.productName = "mobile";
        product1.price = 51000;
        product1.color = "black";
        product1.Display();
    }
}
