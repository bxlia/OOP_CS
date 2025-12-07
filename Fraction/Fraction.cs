using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        public int Integer { get; set; }
        public int Numerator { get; set; }
        int denominator;
        public int Denominator
        { get => denominator;
            set
            {
                if (value == 0) value = 1;
                denominator = value;
            }
                 
        }

        public Fraction()
        {
            Integer = 0;
            Numerator = 0;
            Denominator = 0;
            Console.WriteLine($"Construcror:\t{GetHashCode()}");
        }

        public Fraction(int integer)
        {
            Integer = Integer;
            Numerator = 0;
            Denominator = 1;
            Console.WriteLine($"Construcror:\t{GetHashCode()}");
        }

        public Fraction(int numerator, int denominator)
        {
            Integer = 0;
            Numerator = numerator;
            Denominator = denominator;
            Console.WriteLine($"Construcror:\t{GetHashCode()}");
        }
        public Fraction(int integer=0, int numerator=0, int denominator=1)
        {
            Integer = integer;
            Numerator = numerator;
            Denominator = denominator;
            Console.WriteLine($"Constructor:\t{GetHashCode()}");
        }
        
        public Fraction(Fraction other)
        {
            this.Integer = other.Integer;
            this.Numerator = other.Numerator;
            this.Denominator = other.Denominator;
            Console.WriteLine($"CopyConstructor:{GetHashCode()}");
        }
        ~Fraction()
        {
            Console.WriteLine($"Destructor:\t{GetHashCode()}");
        }
        public static Fraction operator *(Fraction left, Fraction right)
        {
            Fraction left_copy = new Fraction(left);
            Fraction right_copy = new Fraction(right);
            left_copy.ToImproper();
            right_copy.ToImproper();
            return new Fraction
            (
                left_copy.Numerator * right_copy.Numerator,
                left_copy.Denominator * right_copy.Denominator
            ).ToProper();

        }
        public static Fraction operator /(Fraction left, Fraction right)
        {
            return left * right.Inverted();
        }
        public Fraction ToProper()
        {
            Integer += Numerator / Denominator;
            Numerator %= Denominator;
            return this;
        }
        public Fraction ToImproper()
        {
            Numerator += Integer * Denominator;
            Integer = 0;
            return this;
        }
        public Fraction Inverted()
        {
            Fraction inverted = new Fraction(this);
            inverted.ToImproper();
            int buffer = inverted.Numerator;
            inverted.Numerator = inverted.Denominator;
            inverted.Denominator = buffer;
            return inverted;
        }
        public static Fraction operator ++(Fraction fraction)
        {
            fraction.Integer += 1;
            return fraction;
        }

        public static Fraction operator --(Fraction fraction)
        {
            fraction.Integer -= 1;
            return fraction;
        }

        public static bool operator ==(Fraction left, Fraction right)
        {
            Fraction left_copy = new Fraction(left);
            Fraction right_copy = new Fraction(right);
            left_copy.ToImproper();
            right_copy.ToImproper();

            left_copy.Reduce();
            right_copy.Reduce();

            return left_copy.Numerator == right_copy.Numerator &&
                   left_copy.Denominator == right_copy.Denominator;
        }

        public static bool operator !=(Fraction left, Fraction right)
        {
            return !(left == right);
        }

        public static bool operator >(Fraction left, Fraction right)
        {
            Fraction left_copy = new Fraction(left);
            Fraction right_copy = new Fraction(right);
            left_copy.ToImproper();
            right_copy.ToImproper();

            int leftNumerator = left_copy.Numerator * right_copy.Denominator;
            int rightNumerator = right_copy.Numerator * left_copy.Denominator;

            return leftNumerator > rightNumerator;
        }

        public static bool operator <(Fraction left, Fraction right)
        {
            return right > left;
        }

        public static bool operator >=(Fraction left, Fraction right)
        {
            return (left > right) || (left == right);
        }

        public static bool operator <=(Fraction left, Fraction right)
        {
            return (left < right) || (left == right);
        }
        public Fraction Reduce()
        {
            int more, less, rest = 0;
            if (Numerator > Denominator)
            {
                more = Numerator;
                less = Denominator;
            }
            else
            {
                more = Denominator;
                less = Numerator;
            }
            do
            {
                rest = more % less;
                more = less;
                less = rest;

            } while (rest > 0);
            int GCD = more;
            Numerator /= GCD;
            Denominator /= GCD;
            return this;
        }
        public void Print()
        {
            if (Integer != 0) Console.Write(Integer);
            if (Numerator != 0) 
            {
                if (Integer != 0) Console.Write("(");
                Console.Write($"{Numerator}/{Denominator}");
                if (Integer != 0) Console.Write(")");
            }
            else if (Integer != 0) Console.Write(0);
            Console.WriteLine();
        }
    }
}
