using System;

namespace AbstractionSmarphone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstrac Browsing
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

            Console.WriteLine();
            Console.WriteLine();


            //Interface Calling
            Calling calling = new Calling();
            ICalling telpon;
            telpon = calling;
            
            telpon.phone("081223546");
            calling.display();
        }
    }
}
