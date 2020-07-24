using Burjo.Polymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Abstraction.Makanan
{
    public class Magelangan : aBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Magelangan");
            Console.WriteLine("1. Indomie");
            Console.WriteLine("2. Nasi");
            Console.WriteLine("3. Telur");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Magelangan : Rp 8.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
