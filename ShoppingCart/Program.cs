using ShoppingCart;

/*SimpleShoppingCartDemo.Run();*/
namespace ShoppingCart
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Show();
            var productA = new Product("A", 40);
            var productB = new Product("B", 70);
            var productC = new Product("C", 30);
            shoppingCart.Buy(productA,1);
            shoppingCart.Show();
            shoppingCart.Buy(productB,3);
            shoppingCart.Show();
            shoppingCart.Buy(productA,5);
            shoppingCart.Show();
        }
    }
}

    