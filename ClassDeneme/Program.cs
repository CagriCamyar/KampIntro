using System;

namespace ClassDeneme
{

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Gömlek";
            product1.ProductColour = "Beyaz";
            product1.ProductSize = "Large";
            product1.ProductPrice = 350;
            product1.ProductDiscount = 0;

            Product product2 = new Product();
            product2.ProductName = "Şort";
            product2.ProductColour = "Turuncu";
            product2.ProductSize = "Xlarge";
            product2.ProductPrice = 90;
            product2.ProductDiscount = 10;

            Product product3 = new Product();
            product3.ProductName = "Pantolon";
            product3.ProductColour = "Laciver";
            product3.ProductSize = "Medium";
            product3.ProductPrice = 500;
            product3.ProductDiscount = 20;

            Product product4 = new Product();
            product4.ProductName = "Ceket";
            product4.ProductColour = "Kahverengi";
            product4.ProductSize = "Small";
            product4.ProductPrice = 999;
            product4.ProductDiscount = 15;

            Product product5 = new Product();
            product5.ProductName = "Tişört";
            product5.ProductColour = "Siyah";
            product5.ProductSize = "XSmall";
            product5.ProductPrice = 150;
            product5.ProductDiscount = 30;

            Product[] products = new Product[] { product1, product2, product3, product4, product5 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + " : " + products[i].ProductColour + " : " + products[i].ProductSize + " : " + products[i].ProductPrice + " : " + products[i].ProductDiscount);
            }

            Console.WriteLine();

            foreach (Product product in products)
            {

                Console.WriteLine(product.ProductName + " : " + product.ProductColour + " : " + product.ProductSize + " : " + product.ProductPrice + " : " + product.ProductDiscount);


            }

        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public string ProductColour { get; set; }
        public string ProductSize { get; set; }
        public double ProductPrice { get; set; }
        public double ProductDiscount { get; set; }

    }
}