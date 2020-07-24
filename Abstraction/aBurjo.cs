using System;
using System.Collections.Generic;
using System.Text;

namespace Burjo.Abstraction
{
    public abstract class aBurjo
    {
        public string nama { get; set; }
        
        public abstract void komposisi();
        public abstract void keterangan();    
    }
}
