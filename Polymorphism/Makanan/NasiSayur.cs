using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Polymorphism.Makanan
{
    public class NasiSayur : pBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Nasi Sayur");
            Console.WriteLine("1. Nasi");
            Console.WriteLine("2. Sayur - Sayuran");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Nasi Sayur : Rp 7.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
