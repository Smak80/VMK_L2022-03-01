using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace VMK_L2022_03_01
{
    public class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public Complex(){}

        public override string ToString()
        {
            return "" + Re + " + (" + Im + ")i";
        }

        public Complex Plus(Complex other)
        {
            return new Complex(this.Re + other.Re, Im + other.Im);
        }

        public static Complex Plus(Complex z1, Complex z2)
        {
            return new Complex(z1.Re + z2.Re, z1.Im + z2.Im);
        }

        public static Complex operator +(Complex z1, Complex z2)
        {
            return new Complex(z1.Re + z2.Re, z1.Im + z2.Im);
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            return new Complex(
                z1.Re * z2.Re - z1.Im * z2.Im,
                z1.Re * z2.Im + z1.Im * z2.Re
                );
        }

        public static Complex operator *(Complex z1, double x)
        {
            return new Complex(z1.Re * x, z1.Im * x);
        }

        public static Complex operator *(double x, Complex z1)
        {
            return new Complex(z1.Re * x, z1.Im * x);
        }

        public static Complex operator -(Complex z1, Complex z2) => z1 + z2 * -1;

        // Можно перегрузить:
        // унарные операторы: -, +, !, ~, ++, --
        // бинарные операторы: +, -, *, /, %
        // операторы сравнения: ==, !=, >, <, >=, <=
        // поразрядные операторы: &, |, ^, <<, >>
        // логические операторы: &&, ||

        // попарно перегружаются:
        // ==, !=
        // <, >
        // <=, >=

        // Нельзя перегрузить:
        // ?:, =, new
    }
}
