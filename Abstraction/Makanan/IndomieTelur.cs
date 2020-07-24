using Burjo.Polymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Abstraction.Makanan
{
    public class IndomieTelur : aBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Indomie Telur");
            Console.WriteLine("1. Indomie");
            Console.WriteLine("2. Telur");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Indomie Telur : Rp 5.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
