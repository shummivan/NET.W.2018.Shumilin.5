using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    public class My_Polynomial
    {
        /// <summary>
        /// Coefficient polynomial
        /// </summary>
        private double[] coefficient;

        /// <summary>
        /// Degree polynomial
        /// </summary>
        public int Degree => coefficient.Length;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="coeff"></param>
        public My_Polynomial(params double[] coeff)
        {
            coefficient = new double[coeff.Length];
            Array.Copy(coeff, coefficient, coeff.Length);
        }

        /// <summary>
        /// Check polynomials
        /// </summary>
        /// <param name="p1">First polinomial</param>
        /// <param name="p2">Second polinomial</param>
        private static void Check(My_Polynomial p1, My_Polynomial p2)
        {
            if (p1 == null || p2 == null)
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Add polinomials
        /// </summary>
        /// <param name="p1">First polinomial</param>
        /// <param name="p2">Last polinomial</param>
        /// <returns>Out polinomials</returns>
        public static My_Polynomial operator +(My_Polynomial p1, My_Polynomial p2)
        {
            double[] arr;

            Check(p1, p2);

            if (p1.Degree == 0)
            {
                return new My_Polynomial(p2.coefficient);
            }

            if (p2.Degree == 0)
            {
                return new My_Polynomial(p1.coefficient);
            }

            if (p1.Degree > p2.Degree)
            {
                arr = new double[p1.Degree];

                for (int i = 0; i < p1.Degree; i++)
                {
                    arr[i] = p1.coefficient[i];
                }

                for (int i = 0; i < p2.Degree; i++)
                {
                    arr[i] += p2.coefficient[i];
                }

            }
            else
            {
                arr = new double[p2.Degree];

                for (int i = 0; i < p2.Degree; i++)
                {
                    arr[i] = p2.coefficient[i];
                }

                for (int i = 0; i < p1.Degree; i++)
                {
                    arr[i] += p1.coefficient[i];
                }
            }
            return new My_Polynomial(arr);
        }

        /// <summary>
        /// Substract polinomials
        /// </summary>
        /// <param name="p1">First polinomial</param>
        /// <param name="p2">Second polinomial</param>
        /// <returns>Out polinomial</returns>
        public static My_Polynomial operator -(My_Polynomial p1, My_Polynomial p2)
        {
            double[] arr;

            Check(p1, p2);

            if (p1.Degree == 0)
            {
                return new My_Polynomial(p2.coefficient);
            }

            if (p2.Degree == 0)
            {
                return new My_Polynomial(p1.coefficient);
            }

            if (p1.Degree > p2.Degree)
            {
                arr = new double[p1.Degree];

                for (int i = 0; i < p1.Degree; i++)
                {
                    arr[i] = p1.coefficient[i];
                }

                for (int i = 0; i < p2.Degree; i++)
                {
                    arr[i] -= p2.coefficient[i];
                }

            }
            else
            {
                arr = new double[p2.Degree];

                for (int i = 0; i < p2.Degree; i++)
                {
                    arr[i] = -p2.coefficient[i];
                }

                for (int i = 0; i < p1.Degree; i++)
                {
                    arr[i] += p1.coefficient[i];
                }
            }
            return new My_Polynomial(arr);
        }

        /// <summary>
        /// Multiply polinomials
        /// </summary>
        /// <param name="p1">First polinomial</param>
        /// <param name="p2">Second polinomial</param>
        /// <returns>Out polinomial</returns>
        public static My_Polynomial operator *(My_Polynomial p1, My_Polynomial p2)
        {
            double[] arr = new double[p1.Degree + p2.Degree];

            Check(p1, p2);

            if (p1.Degree == 0 || p2.Degree == 0)
            {
                return new My_Polynomial();
            }

            for (int i = 0; i < p1.Degree; i++)
            {
                for (int j = 0; j < p2.Degree; j++)
                {
                    arr[i + j] += p1.coefficient[i] * p2.coefficient[j];
                }
            }

            return new My_Polynomial(arr);
        }

        /// <summary>
        /// Equality polinomials
        /// </summary>
        /// <param name="p1">First polinomial</param>
        /// <param name="p2">Second polinomial</param>
        /// <returns>Equality polinomials</returns>
        //public static bool operator ==(My_Polynomial p1, My_Polynomial p2)
        //{
        //    return p1.coefficient.SequenceEqual(p2.coefficient);
        //}

        /// <summary>
        /// Not equality polinomials
        /// </summary>
        /// <param name="p1">First polinomial</param>
        /// <param name="p2">Second polinomial</param>
        /// <returns>Not equality polinomials</returns>
        //public static bool operator !=(My_Polynomial p1, My_Polynomial p2)
        //{
        //    return !p1.coefficient.SequenceEqual(p2.coefficient);
        //}

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>Polynomial to string</returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            for (int i = coefficient.Length - 1; i >= 0; i--)
            {
                if (coefficient[i] > 0)
                {
                    str.Append("+");
                }
                else
                {
                    str.Append("");
                }

                if (coefficient[i] != 0 && i != 0)
                {
                    str.Append(coefficient[i] + "x^" + i);
                }
                else
                {
                    str.Append("");
                }

                if (i == 0)
                {
                    str.Append(coefficient[i] + "=0");
                }
                else
                {
                    str.Append("");
                }
            }

            return str.ToString();
        }

        /// <summary>
        /// Equals polynomials
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Equality objects</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            My_Polynomial p1 = obj as My_Polynomial;

            if (p1 == null)
            {
                return false;
            }

            for (int i = 0; i < p1.Degree; i++)
            {
                if (p1.coefficient[i] != coefficient[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
