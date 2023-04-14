using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class SimpleShoppingCart2
    {
        public static void Run()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Show();
            var productA = new Product("A", 40);
            var productB = new Product("B", 70);
            var productC = new Product("C", 30);
            shoppingCart.Buy(productA, 1);
            shoppingCart.Show();
            shoppingCart.Buy(productB, 3);
            shoppingCart.Show();
            shoppingCart.Buy(productA, 5);
            shoppingCart.Show();
        }
    }
}
