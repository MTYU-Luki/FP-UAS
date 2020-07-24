using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Polymorphism.Makanan
{
    public class OrakArik : pBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Orak Arik");
            Console.WriteLine("1. Telur Orak Arik");
            Console.WriteLine("2. Nasi");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Orak Arik : Rp 7.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
