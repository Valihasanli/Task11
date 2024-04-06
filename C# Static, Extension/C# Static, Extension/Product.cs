using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Static__Extension
{
    internal class Product
    {
        private static int _no;
        public int No { get; set; }
        public Product()
        {
            _no++;
            No = _no;
        }
        public string Name { get; set; }
        private double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price > 0)
                {
                    _price = value;
                }
            }

        }
        public string Type { get; set; }
        public int Count { get; set; }
        public Product(string name,double price,string type)
        {
            Name = name;
            Price = price;
            Type = type;
        }
        public override string ToString()
        {
            return $"No: {No}, Name: {Name}, Price: {Price}, Type: {Type}, Count: {Count}";
        }

    }
}
