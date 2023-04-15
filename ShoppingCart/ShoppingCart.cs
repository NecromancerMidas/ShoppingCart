using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ShoppingCart
{ 
    internal class ShoppingCart
    {
        private List<OrderLine> _orders = new ();

        public void Buy(OrderLine order, int count)
        {
            if (_orders.All(o => o.Product.Name != order.Product.Name)) _orders.Add(order);
            _orders.First(o => o.Product.Name == order.Product.Name).AddCount(count);
            Console.WriteLine(@$"Du kjøpte {count}stk av {order.Product.Name}");
        }
        public void Show()
        {
            if (_orders.Count == 0)
            {
                Console.WriteLine($@"Handlevogn er tom.");
                return;
            }
            Console.WriteLine("Handlevogn:");
            foreach (var order in _orders)
            {
                Console.WriteLine($@"   {order.Count} stk av {order.Product.Name} kr {order.Product.Price} = {order.Total()}");
            }
            Console.WriteLine($@"Total pris er {Total()}");
        }
        public int Total()
        {
            return _orders.Sum(o => o.Total());
        }
    }
}
