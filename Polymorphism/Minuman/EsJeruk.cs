using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Polymorphism.Minuman
{
    public class EsJeruk : pBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Es Jeruk");
            Console.WriteLine("1. Jeruk");
            Console.WriteLine("2. Gula");
            Console.WriteLine("3. Es");
            Console.WriteLine("4. Air");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Es Jeruk : Rp 2.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }


    }
}
