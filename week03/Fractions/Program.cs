using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction = new Fraction();

        myFraction .SetNumerator(3);
        myFraction .SetDenominator(4);

        Console.WriteLine($"My Numerator is: {myFraction .GetNumerator}");
        Console.WriteLine($"My Denominator is: {myFraction .GetDenmoinator}");

        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction one is: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction two is: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");

        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine($"Fraction three is: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");
    }

    public class Fraction
    {
        private int _numerator;
        private int _denominator;
    
        public int GetNumerator()
        {
            return _numerator;
        }
        public void SetNumerator(int numerator)
        {
            _numerator = numerator;
        }


        public int GetDenmoinator()
        {
            return _denominator;
        }
        public void SetDenominator(int denominator)
        {
            _denominator = denominator;
        }


        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        public Fraction (int numerator)
         {
            _numerator = numerator;
            _denominator = 1;
         }

        public Fraction (int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public string GetFractionString()
        {
            return $"{_numerator} / {_denominator}";
        }

        public double GetDecimalValue()
        {
            return (double) _numerator / _denominator;
        }
        
    }
}