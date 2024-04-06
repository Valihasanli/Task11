using System.Numerics;

namespace C__Static__Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Mehsul elave et");
            Console.WriteLine("2. Mehsul sil");
            Console.WriteLine("3. Mehsula bax");
            Console.WriteLine("4. Type'a gore mehsullara bax");
            Console.WriteLine("5. Ada gore mehsullara bax");
            Console.WriteLine("0. Proqramdan cix");
            string answer = Console.ReadLine();
            Product product = new Product();
            Store store = new Store();
            bool check = true;
            while (check)
            {
                switch (answer)
                {
                    case "1":
                        store.AddProduct();
                        break;
                    case "2":
                        string nostr = Console.ReadLine();
                        int.TryParse(nostr, out int no);
                        store.RemoveProductByNo(no);
                        break;
                    case "3":
                        string nostrr = Console.ReadLine();
                        int.TryParse(nostrr, out int noo);
                        store.GetProductByNo(noo).ToString();
                        break;
                    case "4":
                        string type = Console.ReadLine();
                        store.FilterProductsByType(type);
                        break;
                    case "5":
                        string name = Console.ReadLine();
                        store.FilterProductsByName(name);
                        break;
                    case "0":
                        check = false;
                        break;


                }
            }

        }


    }
}

