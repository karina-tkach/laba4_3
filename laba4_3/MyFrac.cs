using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace laba4_3
{
    public class MyFrac : IMyNumber<MyFrac>, IComparable<MyFrac>
    {
        private BigInteger nominative, denominative;
        public BigInteger Nominative
        {
            get
            {
                return nominative;
            }
        }
        public BigInteger Denominative
        {
            get
            {
                return denominative;
            }
        }

        public MyFrac(BigInteger nom, BigInteger denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Denominative can't be zero");
            }

            if (denom < 0)
            {
                nom *= -1;
                denom *= -1;
            }

            nominative = nom;
            denominative = denom;
            SimplifyFrac();
        }
        public MyFrac(int nom, int denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Denominative can't be zero");
            }

            if (denom < 0)
            {
                nom *= -1;
                denom *= -1;
            }
            nominative = nom;
            denominative = denom;
            SimplifyFrac();
        }
        private void SimplifyFrac()
        {
            BigInteger gcd = BigInteger.GreatestCommonDivisor(nominative, denominative);
            nominative /= gcd;
            denominative /= gcd;
        }
        public MyFrac Add(MyFrac that)
        {
            return new MyFrac(this.nominative * that.denominative + that.nominative * this.denominative, this.denominative * that.denominative);
        }
        public MyFrac Subtract(MyFrac that)
        {
            return new MyFrac(this.nominative * that.denominative - that.nominative * this.denominative, this.denominative * that.denominative);
        }
        public MyFrac Multiply(MyFrac that)
        {
            return new MyFrac(this.nominative * that.nominative, this.denominative * that.denominative);
        }
        public MyFrac Divide(MyFrac that)
        {
            BigInteger newDenominative = this.denominative * that.nominative;
            if (newDenominative == 0)
            {
                throw new DivideByZeroException();
            }

            return new MyFrac(this.nominative * that.denominative, newDenominative);
        }
        public int CompareTo(MyFrac other)
        {
            decimal thisAsDecimal = (decimal)this.nominative / (decimal)this.denominative;
            decimal otherAsDecimal = (decimal)other.nominative / (decimal)other.denominative;

            return thisAsDecimal.CompareTo(otherAsDecimal);
        }
        public override string ToString()
        {
            return nominative + "/" + denominative;
        }
    }
}
