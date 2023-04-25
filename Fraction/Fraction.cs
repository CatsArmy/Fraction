using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = (denominator == 0) ? 1 : denominator;
        }
        public Fraction(Fraction other)
        {
            this.numerator = other.numerator;
            this.denominator = other.denominator;
        }

        public int GetNumerator()
        {
            return this.numerator;
        }
        public int GetDenominator()
        {
            return this.denominator;
        }
        public override string ToString()
        {
            return $"{this.numerator} / {this.denominator}";
        }
        public static int FindMaxDenomunator(int n1, int n2)
        {
            int loop = Math.Min(n1, n2) / 2;
            int maxDeno = 1;
            for (int i = 2; i <= loop; i++)
            {
                if (0 == n1 % i && 0 == n2 % i)
                {
                    maxDeno = i;
                }
            }
            return maxDeno;
        }
        public void Expansion(int expand)
        {
            this.numerator *= expand;
            this.denominator *= expand;
        }
        public void Simplify()
        {
            int deno = FindMaxDenomunator(this.numerator, this.denominator);
            this.numerator /= deno;
            this.denominator /= deno;
        }
        public static Fraction Add(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.numerator * f2.denominator+ f1.denominator * f2.numerator,
                f1.denominator * f2.denominator);
        }

    }
}
