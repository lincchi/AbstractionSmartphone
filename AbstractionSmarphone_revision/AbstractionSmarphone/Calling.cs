using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractionSmarphone
{
    class Calling : ICalling
    {
        string notlp;
        string fungsi ="Telpon";
        //abstrac method ICalling
        public void phone(string number)
        {
            notlp = number;
            Console.WriteLine("Fungsi yang digunakan adalah : {0}", fungsi);
        }

        //method class Calling
        public void display()
        {
            Console.WriteLine("Memanggil no: " + notlp);
        }
    }
}
