using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Polymorphism
{
    public class pBurjo
    {
        public string nama { get; set; }

        public virtual void komposisi()
        {
            Console.WriteLine("Komposisi Makanan & Minuman");
        }

        public virtual void keterangan()
        {
            Console.WriteLine("Keterangan Harga");
        }
    }
}
