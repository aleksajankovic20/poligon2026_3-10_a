using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026_3_10_a
{
    internal class vektor
    {
        public tacka pocetak;
        public tacka kraj;
        public vektor(tacka pocetak, tacka kraj)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
        }
        public vektor(tacka kraj)
        {
            this.pocetak = new tacka();
            this.kraj = kraj;
        }
        public tacka centriraj()
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y - pocetak.y;
            return new tacka(x, y);
        }
        static public double SP(vektor a, vektor b)
        {
            tacka A =  a.centriraj();
            tacka B =  b.centriraj();
            return A.x * B.x + A.y * B.y;
        }
        static public double VP(vektor a, vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            double k = A.x * B.y + A.y * B.x;
            return k;
        }
    }
}
