//#define CONSRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        const string delimeter = "\n--------------------------------";
        static void Main(string[] args)
        {
#if CONSRUCTORS_CHECK
            Fraction A = new Fraction();
            A.Print();

            double b = 5;
            Fraction B = new Fraction(5);
            B.Print();

            Fraction C = new Fraction(1, 2);
            C.Print();

            Fraction D = new Fraction(2, 3, 4);
            D.Print();
#endif
            Fraction A = new Fraction(2, 3, 4);
            Fraction B = new Fraction(3, 4, 5);
            Fraction C = A / B;
            A.Print();
            B.Print();
            C.Print();
            Console.WriteLine(delimeter);
            A *= B;
            A.Print();
            A /= B;
            A.Print();
        }
    }
}
