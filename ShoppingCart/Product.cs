﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Product
    {
        public string Name {get; }
        public int Price { get;}
        public int Count { get; private set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public void AddCount(int count)
        {
            Count += count;
        }
    }
}
