using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026_3_10_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aleksa Jankovic
            tacka a = new tacka(-1,-1);
            Console.WriteLine(a.ugao());
            Console.WriteLine(a.d());
            tacka A = new tacka(3, 1);
            tacka B = new tacka(-1,3);
            tacka C = new tacka(3, 3);
            vektor OA = new vektor(A);
            vektor OB = new vektor(B);
            vektor AC = new vektor(A, C);
            Console.WriteLine(vektor.SP(OA, OB));
            Console.WriteLine(vektor.VP(OA, AC));
            Console.ReadKey();*/
            tacka A = new tacka(1, 2);
            tacka B = new tacka(3, 2);
            tacka C = new tacka(2, 3);
            tacka D = new tacka(2, 1);
            vektor AB = new vektor(A, B);
            Console.WriteLine(ravan.SIS(AB, C, D));
        }
    }
}
