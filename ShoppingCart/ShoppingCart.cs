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

        public void Buy(Product item, int count)
        {
            if (_orders.All(o => o.Product.Name != item.Name)) _orders.Add(new OrderLine(item));
            _orders.First(o => o.Product.Name == item.Name).AddCount(count);
            Console.WriteLine(@$"Du kjøpte {count}stk av {item.Name}");
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
                order.Show();
            }
            Console.WriteLine($@"Total pris er {Total()}");
        }
        public int Total()
        {
            return _orders.Sum(o => o.Total());
        }
    }
}
