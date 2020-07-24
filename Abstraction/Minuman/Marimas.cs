using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Burjo.Abstraction.Minuman
{
    public class Marimas : aBurjo
    {
        public override void komposisi()
        {
            Console.WriteLine("Komposisi utama Marimas");
            Console.WriteLine("1. Marimas sachet");
            Console.WriteLine("2. Air");
            Console.WriteLine("3. Es");
        }

        public override void keterangan()
        {
            Console.WriteLine("Harga Marimas : Rp 2.000");
        }

        public void getNama()
        {
            Console.WriteLine("{0}", nama);
        }
    }
}
