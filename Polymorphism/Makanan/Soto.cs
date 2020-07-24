using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Polymorphism.Makanan
{
    public class Soto : pBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi Utama Soto");
            Console.WriteLine("1. Sayur Sayuran");
            Console.WriteLine("2. Rempah Rempahan");
            Console.WriteLine("3. Nasi");
            Console.WriteLine("4. Daging");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Soto  = Rp 12.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
