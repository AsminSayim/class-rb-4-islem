using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_rd_4_islem
{
    internal class İslem
    {
        public int sayi1;
        public int sayi2;

        public double Topla()
        {
            return sayi1 + sayi2;
        }

        public double Cikar()
        {
            return sayi1 - sayi2;
        }

        public double Carp()
        {
            return sayi1* sayi2;
        }

        public double Bol()
        {
            return sayi1 / sayi2;
        }
    }
}
