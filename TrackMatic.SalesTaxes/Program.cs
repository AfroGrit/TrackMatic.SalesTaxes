using System;

using System.Collections.Generic;

namespace TrackMatic.SalesTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input 1 
            var ShoppingList = new List<Cart>()

            {
                new Cart(Type.Exempt, "Book", 12.49),
                new Cart(Type.Local, "Music CD", 14.99),
                new Cart(Type.Exempt, "Chocolate", 0.85)
            };

            // Input 2 
            var ShoppingList_2 = new List<Cart>()

            {
                new Cart(Type.Import, "Box of Chocolate", 10.50),
                new Cart(Type.Import, "Bottle of Perfume", 47.50),

            };

            // Input 3 
            var ShoppingList_3 = new List<Cart>()

            {
                new Cart(Type.Import, "Bottle of Perfume", 27.99),
                new Cart(Type.Local, "Bottle of Perfume", 18.99),
                new Cart(Type.Exempt, "Headache Pills", 9.75),
                new Cart(Type.Import, "Chocolates", 11.25)
            };


            //double TotalTax = 0.0;
            //double TotalSales = 0.0;

            Console.WriteLine("Outputs - Input #1 ");
            Console.WriteLine("==============+===============");
            for (int i = 0; i < ShoppingList.Count; ++i)
            {
                ShoppingList[i].PrintItem();
            }

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Sales Taxes: {0, -20}", Math.Round(TotalTax, 2));
            //Console.WriteLine("Sales Total: {0, -20}", Math.Round(TotalSales, 2));
            //Console.WriteLine("------------------------------\n");



            //double TotalTax = 0.0;
            //double TotalSales = 0.0;

            //Console.WriteLine("Outputs - Input #1 ");
            //Console.WriteLine("==============+===============");
            //for (int i = 0; i < ShoppingList.Count; ++i)
            //{
            //    Console.WriteLine("Item ~ {0, -5} {1, -10}: {2}",
            //        i,
            //        ShoppingList[i].Name,
            //        ShoppingList[i].Amount);

            //    TotalTax += ShoppingList[i].Amount * ShoppingList[i].GetTaxRate();
            //    TotalSales += ShoppingList[i].Amount;

            //}

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Sales Taxes: {0, -20}", Math.Round(TotalTax, 2));
            //Console.WriteLine("Sales Total: {0, -20}", Math.Round(TotalSales, 2));
            //Console.WriteLine("------------------------------\n");

            //Console.WriteLine("Outputs - Input #2 ");
            //Console.WriteLine("==============+===============");
            //for (int i = 0; i < ShoppingList_2.Count; ++i)
            //{
            //    Console.WriteLine("Item ~ {0, -5} {1, -10}: {2}", 
            //        i,
            //        ShoppingList_2[i].Name,
            //        ShoppingList_2[i].Amount);             

            //    TotalTax += ShoppingList_2[i].Amount * ShoppingList_2[i].GetTaxRate();
            //    TotalSales += ShoppingList_2[i].Amount;

            //}

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Sales Taxes: {0, -20}", Math.Round(TotalTax, 2));
            //Console.WriteLine("Sales Total: {0, -20}", Math.Round(TotalSales, 2));
            //Console.WriteLine("------------------------------\n");

            //Console.WriteLine("Outputs - Input #3 ");
            //Console.WriteLine("==============+===============");
            //for (int i = 0; i < ShoppingList_3.Count; ++i)
            //{
            //    Console.WriteLine("Item ~ {0, -5} {1, -10}: {2}",
            //        i,
            //        ShoppingList_3[i].Name,
            //        ShoppingList_3[i].Amount);

            //    TotalTax += ShoppingList_3[i].Amount * ShoppingList_3[i].GetTaxRate();
            //    TotalSales += ShoppingList_3[i].Amount;

            //}

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Sales Taxes: {0, -20}", Math.Round(TotalTax, 2));
            //Console.WriteLine("Sales Total: {0, -20}", Math.Round(TotalSales, 2));
            //Console.WriteLine("------------------------------\n");

        }
    }
}

