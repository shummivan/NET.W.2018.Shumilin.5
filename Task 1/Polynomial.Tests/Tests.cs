using System;
using NUnit.Framework;

namespace Polynomial.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(1, 2, 3, 4, ExpectedResult = "+4x^3+3x^2+2x^1+1=0")]
        public string toString_Polinom_PolynomString(params double[] coeff)
        {
            My_Polynomial a = new My_Polynomial(coeff);
            return a.ToString();
        }

        [TestCase(ExpectedResult = "+3x^3+5x^2+9x^1+9=0")]
        public string OperatorSum_Polinom_PolynomString()
        {
            My_Polynomial a = new My_Polynomial(4, 7, 5);
            My_Polynomial b = new My_Polynomial(5, 2, 0, 3);

            return (a + b).ToString();
        }

        [TestCase(ExpectedResult = "+21x^5+32x^4+34x^3+28x^2+13x^1+4=0")]
        public string OperatorMult_Polinom_PolynomString()
        {
            My_Polynomial a = new My_Polynomial(1, 2, 3);
            My_Polynomial b = new My_Polynomial(4, 5, 6, 7);

            return (a * b).ToString();
        }

        [TestCase(ExpectedResult = "-3x^3+5x^2+5x^1-1=0")]
        public string OperatorSubstruct_Polinom_PolynomString()
        {
            My_Polynomial a = new My_Polynomial(4, 7, 5);
            My_Polynomial b = new My_Polynomial(5, 2, 0, 3);
            My_Polynomial c = a - b;
            return c.ToString();
        }
    }
}
