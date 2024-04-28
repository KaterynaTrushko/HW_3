using System;

public class Class1
    {


    public interface INumber<T> : IComparable, IComparable<T>, IEquatable<T>, IParsable<T>, ISpanParsable<T>, IUtf8SpanParsable<T>, System.Numerics.IAdditionOperators<T, T, T>, System.Numerics.IAdditiveIdentity<T, T>, System.Numerics.IComparisonOperators<T, T, bool>, System.Numerics.IDecrementOperators<T>, System.Numerics.IDivisionOperators<T, T, T>, System.Numerics.IEqualityOperators<T, T, bool>, System.Numerics.IIncrementOperators<T>, System.Numerics.IModulusOperators<T, T, T>, System.Numerics.IMultiplicativeIdentity<T, T>, System.Numerics.IMultiplyOperators<T, T, T>, System.Numerics.INumberBase<T>, System.Numerics.ISubtractionOperators<T, T, T>, System.Numerics.IUnaryNegationOperators<T, T>, System.Numerics.IUnaryPlusOperators<T, T> where T : INumber<T>;

    public struct ComplexNumber
         where T : INumber<T>
        {
        public ComplexNumber(T re, T im)
            {
            Re = re;
            Im = im;
            }
        T re;
        T im;
        public T Re
            {
            get
                {
                if (re == null) throw new ArgumentNullException(paramName: nameof(re), message: "Re cannot be null");
                else
                    { return re; }
                }
            set
                {
                if (value != null || value is int || value is double || value is float) re = value;
                else { throw new ArgumentNullException(paramName: nameof(re), message: "Re cannot be null"); }
                }
            }
        public T Im
            {
            get
                {
                if (im == null) throw new ArgumentNullException(paramName: nameof(re), message: "Im cannot be null");
                else
                    { return re; }
                }
            set
                {
                if (value != null || value is int || value is double || value is float) im = value;
                else { throw new ArgumentNullException(paramName: nameof(im), message: "Im cannot be null"); }
                }
            }


        public static ComplexNumber<T> operator +(ComplexNumber<T> a1, ComplexNumber<T> a2)
            {
            try
                {
                return new ComplexNumber<T>(a1.Re + a2.Re, a1.Im + a2.Im);
                }
            catch (ArgumentException e)
                {
                throw new ArgumentNullException(paramName: nameof(re), message: "Arguments cannot be null");
                }
            }

        public static ComplexNumber<T> operator -(ComplexNumber<T> a1, ComplexNumber<T> a2)
            {
            try
                {
                return new ComplexNumber<T>(a1.Re - a2.Re, a1.Im - a2.Im);
                }
            catch (ArgumentException e)
                {
                throw new ArgumentNullException("Arguments cannot be null", e);
                }
            }
        public override string ToString()
            {
            try
                {
                return $"re:{this.Re} im:{this.Im}";
                }
            catch (Exception e)
                {
                throw new Exception("Ir or Im arguments cannot be null", e);
                }
            }
        public void Print()
            {
            try
                {
                Console.WriteLine($"We have complex number with real part {this.Re} and imaginary {this.Im}");
                }
            catch (Exception e)
                {
                throw new Exception("Ir or Im arguments cannot be null", e);
                }
            }

        }

    }



