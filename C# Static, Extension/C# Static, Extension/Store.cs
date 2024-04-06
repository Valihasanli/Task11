using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Static__Extension
{
    internal class Store
    {
        private static int _idd;
        public int ID { get; set; }
        public Store()
        {
            _idd++;
            ID = _idd;
        }
        Product[] Products = { };
        public Product[] AddProduct()
        {
            Console.WriteLine("Mehsulun adini daxil et");
            string name = Console.ReadLine();
            Console.WriteLine("qiymet daxil et");
            string pricestr = Console.ReadLine();
            double.TryParse(pricestr, out double price);
            Console.WriteLine("Mehsulun tipini daxil et");
            string type = Console.ReadLine();
            Console.WriteLine("Mehsulun sayini daxil et");
            string countstr = Console.ReadLine();
            int.TryParse(countstr, out int count);
            Product product = new Product()
            {
                Name = name,
                Price = price,
                Type = type,
                Count = count

            };
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
           
            return Products;
        }
        public Product[] RemoveProductByNo(int no)
        {
            int Removedindex =-1;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    Removedindex = i;
                    break;
                }
            }

            if (Removedindex != -1)
            {
                for (int i = Removedindex; i < Products.Length - 1; i++)
                {  
                    Products[i] = Products[i + 1];
                }
                Products[Products.Length - 1] = null;
            }

            return Products;

        }
        public  Product GetProductByNo(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No==no)
                    return Products[i];
                break;
                
            }
            return null;
        }
        public Product[] FilterProductsByType(string type)
        {
            Product[] newproducts = { };
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Type == type)
                {
                    Array.Resize(ref newproducts, newproducts.Length+1);
                    newproducts[newproducts.Length-1] = Products[i];    
                }
                
            }
            for (int i = 0;i<newproducts.Length; i++)
            {
                newproducts[i].ToString();
            }
            return newproducts;
        }
        public Product[] FilterProductsByName(string name)
        {
            Product[] newproducts = { };
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Array.Resize(ref newproducts, newproducts.Length + 1);
                    newproducts[newproducts.Length - 1] = Products[i];
                }

            }
            for (int i = 0; i < newproducts.Length; i++)
            {
                newproducts[i].ToString();
            }
            return newproducts;
        }
        public void Sale(int no,Person person)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    Products[i].Count--;
                    person.Cash -= Products[i].Price;
                    break;
                }
                

            }


        }

        
    }
}
