using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice_S4
{
    public class Number
    {
        private bool IsInteger { get; set; }
        private double DoubleValue { get; set; }
        private int IntValue { get; set; }

        private double AsDouble()
        {
            if (IsInteger)
            {
                return IntValue;
            }

            return DoubleValue;
        }

        public static Number Create(string s)
        {
            if (s.Contains("."))
            {
                return new Number
                {
                    DoubleValue = double.Parse(s),
                    IsInteger = false
                };
            }

            return new Number
            {
                IntValue = int.Parse(s),
                IsInteger = true
            };
        }

        private static Number FromValue(int value)
        {
            return new Number
            {
                IntValue = value,
                IsInteger = true
            };
        }

        private static Number FromValue(double value)
        {
            return new Number
            {
                DoubleValue = value,
                IsInteger = false
            };
        }

        public static Number operator +(Number a, Number b)
        {
            if (a.IsInteger && b.IsInteger)
            {
                return FromValue(a.IntValue + b.IntValue);
            }
            return FromValue(a.AsDouble() + b.AsDouble());
        }

        public static Number operator -(Number a, Number b)
        {
            if (a.IsInteger && b.IsInteger)
            {
                return FromValue(a.IntValue - b.IntValue);
            }
            return FromValue(a.AsDouble() - b.AsDouble());
        }

        public static Number operator *(Number a, Number b)
        {
            if (a.IsInteger && b.IsInteger)
            {
                return FromValue(a.IntValue * b.IntValue);
            }
            return FromValue(a.AsDouble() * b.AsDouble());
        }

        public static Number operator /(Number a, Number b)
        {
            if (a.IsInteger && b.IsInteger && a.IntValue == a.IntValue / b.IntValue * b.IntValue)
            {
                return FromValue(a.IntValue / b.IntValue);
            }
            return FromValue(a.AsDouble() / b.AsDouble());
        }

        public override string ToString()
        {
            if (IsInteger)
            {
                return IntValue.ToString();
            }
            return DoubleValue.ToString("N2");
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Number);
        }


        protected bool Equals(Number other)
        {
            return IsInteger == other.IsInteger && DoubleValue.Equals(other.DoubleValue) && IntValue == other.IntValue;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = IsInteger.GetHashCode();
                hashCode = (hashCode * 397) ^ DoubleValue.GetHashCode();
                hashCode = (hashCode * 397) ^ IntValue;
                return hashCode;
            }
        }
    }
}

