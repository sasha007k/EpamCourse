namespace Task_5
{
    public class ComplexNumber
    {
        #region Fields
        private readonly double real;
        private readonly double imaginary;
        #endregion

        #region Constructors
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        #endregion

        #region Overloaded operators
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real * c2.real, c1.imaginary * c2.imaginary);
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real / c2.real, c1.imaginary / c2.imaginary);
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Real = " + real + "   imaginary = " + imaginary;
        }
        #endregion
    }
}
