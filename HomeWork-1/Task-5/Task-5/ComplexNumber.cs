using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class ComplexNumber
    {
        #region Fields
        private double real;
        private double imaginary;
        #endregion

        #region Constructors
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        #endregion

        #region Methods
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real * c2.real, c1.imaginary * c2.imaginary);
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real / c2.real, c1.imaginary / c2.imaginary);
        }

        public override string ToString()
        {
            return "Real = " + real + "   imaginary = " + imaginary;
        }
        #endregion
    }
}
