using Burjo.Abstraction;
using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace Burjo.Abstraction.Minuman
{
    public class ExtraJoss : aBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Extra Joss");
            Console.WriteLine("1. Extra Joss Sachet");
            Console.WriteLine("2. Air");
            Console.WriteLine("3. Es");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Extra Joss : Rp 3.500");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
