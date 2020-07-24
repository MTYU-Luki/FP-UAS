using Burjo.Polymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Abstraction.Makanan
{
    public class NasiGoreng : aBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Nasi Goreng");
            Console.WriteLine("1. Nasi");
            Console.WriteLine("2. Telur");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Nasi Goreng : Rp 8.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
