using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Salesman S1 = new Salesman();
            S1.Name = "Teo";
            S1.Age = 30;

            Salesman S2 = new Salesman();
            S2.Name = "Nata";
            S2.Age = 25;

            Salesman S3 = new Salesman();
            S3.Name = "Edi";
            S3.Age = 31;

            Salesman S4 = new Salesman();
            S4.Name = "Valen";
            S4.Age = 20;


            Product Pro1 = new Product();
            Pro1.Name = "Polo";
            Pro1.Price = 120;

            Product Pro2 = new Product();
            Pro2.Name = "Jean";
            Pro2.Price = 100;

            Product Pro3 = new Product();
            Pro3.Name = "Shoes";
            Pro3.Price = 150;

            Product Pro4 = new Product();
            Pro4.Name = "T-Shirt";
            Pro4.Price = 80;

            Product Pro5 = new Product();
            Pro5.Name = "Dress";
            Pro5.Price = 200;

            Product Pro6 = new Product();
            Pro6.Name = "sunglasses";
            Pro6.Price = 50;

            Sale sale1 = new Sale();
            sale1.Product = "Jean";
            sale1.Seller = "TEO";
            sale1.comments = "Jean for Women Color Gray";

            Sale sale2 = new Sale();
            sale2.Product = "Polo";
            sale2.Seller = "Nata";
            sale2.comments = "Polo siza M";

            Sale sale3 = new Sale();
            sale3.Product = "Shoes";
            sale3.Seller = "Valen";
            sale3.comments = "Shoes siza 39";

            Sale sale4 = new Sale();
            sale4.Product = "Dress";
            sale4.Seller = "Edi";
            sale4.comments = "Dress for women color RED";            

            int GetsumSale(int sale1, int sale2, int sale3)
            {
                int endsale = ( sale1 + sale2 + sale3);
                return endsale;
            }

            Console.WriteLine("Sales total amount: " + GetsumSale(Pro1.Price,Pro2.Price,Pro3.Price));


            
        }
    }
}
