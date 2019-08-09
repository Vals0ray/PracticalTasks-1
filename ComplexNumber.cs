﻿namespace Practical_Tasks_No1
{
    class ComplexNumber
    {
        public double R { get; set; }
        public double I { get; set; }

        public ComplexNumber()
        {
            R = 0;
            I = 0;
        }

        public ComplexNumber(double r, double i)
        {
            this.R = r;
            this.I = i;
        }

        #region Multiplication operator overload
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber complex = new ComplexNumber();
            complex.R = c1.R * c2.R - c1.I * c2.I;
            complex.I = c1.R * c2.I + c1.I * c2.R;
            return complex;
        }
        #endregion

        #region Division operator overload
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber complex = new ComplexNumber();
            complex.R = ((c1.R * c2.R) + (c1.I * c2.R)) / ((c2.R * c2.R) + (c2.I * c2.I));
            complex.I = ((c2.R * c1.I) - (c1.R * c2.I)) / ((c2.R * c2.R) + (c2.I * c2.I));
            return complex;
        }
        #endregion
    }
}
