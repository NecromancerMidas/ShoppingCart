using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class OrderLine
    {
        public Product Product { get; }
        public int Count { get; private set; }

        public OrderLine(Product product)
        {
            Product = product;
        }
        public int Total()
        {
            return Product.Price * Count;
        }
        public void AddCount(int count)
        {
            Count += count;
        }

        public void Show()
        { 
            Console.WriteLine($@"   {Count} stk av {Product.Name} kr {Product.Price} = {Total()}");
        }
    }
}
