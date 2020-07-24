using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Polymorphism.Minuman
{
    public class kratingdeng : pBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Kratingdeng");
            Console.WriteLine("1. Kratingdeng Sachet");
            Console.WriteLine("2. Es");
            Console.WriteLine("3. Gula");
            Console.WriteLine("4. Air");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Kratingdeng : Rp 3.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
