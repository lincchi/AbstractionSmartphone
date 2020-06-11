using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace AbstractionSmarphone
{
    class Browsing : Fungction
    {
        public string Sites { get; set; }

        public Browsing(string sites)
        {
            
            NamaFungsi = "Browsing";
            Sites = sites;
        }
        public override string Fungsinya()
        {
            return (Sites);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Situs yang dikunjungi {Sites}");
        }
    }
}
