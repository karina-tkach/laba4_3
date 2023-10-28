using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4_3
{
    public class MyComplex : IMyNumber<MyComplex>
    {
        double re, im;
        public double Real
        {
            get
            {
                return re;
            }
        }
        public double Imaginary
        {
            get
            {
                return im;
            }
        }
        public MyComplex(double real, double imaginary)
        {
            this.re = real;
            this.im = imaginary;
        }
        public MyComplex Add(MyComplex that)
        {
            return new MyComplex(this.re + that.re, this.im + that.im);
        }
        public MyComplex Subtract(MyComplex that)
        {
            return new MyComplex(this.re - that.re, this.im - that.im);
        }
        public MyComplex Multiply(MyComplex that)
        {
            return new MyComplex(this.re * that.re - this.im * that.im, this.re * that.im + this.im * that.re);
        }
        public MyComplex Divide(MyComplex that)
        {
            double divisor = (Math.Pow(that.re, 2) + Math.Pow(that.im, 2));
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            return new MyComplex((this.re * that.re + this.im * that.im) / divisor, (this.im * that.re - this.re * that.im) / divisor);
        }
        public override string ToString()
        {
            if (im < 0)
            {
                return re + "-" + -im + "i";
            }
            else
            {
                return re + "+" + im + "i";
            }
        }
    }
}
