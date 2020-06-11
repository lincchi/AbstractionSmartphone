using System;

namespace AbstractionSmarphone
{
    class Program
    {
        static void Main(string[] args)
        {
            Fungction[] fungctions = { new Browsing("google") };
            foreach (Fungction f in fungctions)
            {
                f.GetInfo();
                

                Browsing browsing = f as Browsing;
                if (browsing == null)
                {
                    Console.WriteLine("Eror 404");
                }
                if (f is Browsing)
                {
                    Console.WriteLine("Memuat situs yang anda tuju");
                }
            }
        }
    }
}
