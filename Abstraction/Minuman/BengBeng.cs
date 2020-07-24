using Burjo.Polymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Abstraction.Minuman
{
    public class BengBeng : aBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Beng Beng");
            Console.WriteLine("1. Beng Beng Sachet");
            Console.WriteLine("2. Es");
            Console.WriteLine("3. Air");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Beng Beng : Rp 3.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
