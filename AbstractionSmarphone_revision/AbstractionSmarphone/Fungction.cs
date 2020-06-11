using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionSmarphone
{
    abstract class Fungction
    {
        public string NamaFungsi { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Fungsi smartphone yang digunakan {NamaFungsi}");
        }

        public abstract string Fungsinya();
    }
}
