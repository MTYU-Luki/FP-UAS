using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Polymorphism.Minuman
{
    public class EsTeh : pBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Es Teh");
            Console.WriteLine("1. Teh");
            Console.WriteLine("2. Gula");
            Console.WriteLine("3. Es");
            Console.WriteLine("4. Air");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Es Teh : Rp 2.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
