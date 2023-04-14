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
            Console.WriteLine("Handlevogn:");
            foreach (var product in _products)
            {
                Console.WriteLine($@"   {product.Count} stk av {product.Name} kr {product.Price} = {product.Total()}");
            }
            Console.WriteLine($@"Total pris er {Total()}");
        }
        public int Total()
        {
            var total = 0;
            _products.ForEach(p => total += p.Total());
            return total;
        }
    }
}
