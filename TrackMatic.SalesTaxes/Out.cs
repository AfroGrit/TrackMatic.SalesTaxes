using System;
namespace TrackMatic.SalesTaxes
{
    public class Out
    {
        public Cart cart;

        public void Print()
        {
            //cart.Amount();
            using (var Trolley = new Cart(Type.Exempt))
            {
                //Trolley.Amount = 0;
                Console.WriteLine("Print the receipt {0}", Trolley.Amount);
            }

            Console.WriteLine("Print the receipt {0}", cart.Amount);
        }

        //public void Cart Parse(Cart)
        //{
        //    var Trolley = new Cart();

        //}
    }
}
