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
        private List<Product> _products = new ();

        public void Buy(Product item, int count)
        {
            if (_products.All(p => p.Name != item.Name)) _products.Add(item);
            _products.First(p => p.Name == item.Name).AddCount(count);
            Console.WriteLine(@$"Du kjøpte {count}stk av {item.Name}");
        }
        public void Show()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine($@"Handlevogn er tom.");
                return;
            }
            var total = 0;
            Console.WriteLine("Handlevogn:");
            foreach (var product in _products)
            {
                var productTotal = product.Price * product.Count;
                Console.WriteLine($@"   {product.Count} stk av {product.Name} kr {product.Price} = {product.Total()}");
                total += productTotal;
            }
            Console.WriteLine($@"Total pris er {total}");
        }
    }
}
