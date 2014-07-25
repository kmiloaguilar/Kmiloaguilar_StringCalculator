using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace StringCalculator
{
    public class StringCalculatorClass : ICalculator
    {
        public int Calculate(string value)
        {
            var result = 0;

            if (CheckIfValueIsEmpty(value))
                return -1;

            var values = value.Split('+');

            if (IfValuesLengthIsOne(values))
            {
                result = ContainsASubstraction(values) ? 
                        SubstractValues(values.First()) : Convert.ToInt32(values.First());
            }
            else if (IfValuesHasMoreThanOne(values))
            {
                result = SumAllValues(values);                
            }
            
            return result;
        }

        static bool ContainsASubstraction(string[] values)
        {
            return values[0].Contains("-");
        }

        static bool IfValuesHasMoreThanOne(string[] values)
        {
            return values.Length > 1;
        }

        static bool IfValuesLengthIsOne(string[] values)
        {
            return values.Length == 1;
        }

        static int SubstractValues(string values)
        {
            int result = 0;
            var subtractValues = values.Split('-');
            var firstSubstractElement = Convert.ToInt32(subtractValues.First());
            result = firstSubstractElement;
            for (int i = 1; i < subtractValues.Length; i++)
            {
                result -= Convert.ToInt32(subtractValues[i]);
            }
            return result;
        }

        static int SumAllValues(string[] values)
        {
            int result = 0;
            foreach (string s in values)
            {
                result += Convert.ToInt32(s);
            }
            return result;
        }

        static bool CheckIfValueIsEmpty(string value)
        {
            return value == string.Empty;
            
        }
    }

    class MyThirdStringCalculatorClass
    {
        public static int Algo;
    }

    class MySecondStringCalculatorClass : MyThirdStringCalculatorClass, ICalculator,ICalculator2
    {

        public int Calculate(string value)
        {
            Algo = 4;
            return 0;
        }

        public int Read()
        {
            return -1;
        }
    }

    public interface ICalculator2
    {
        int Read();
    }

    public interface ICalculator
    {
        int Calculate(string value);
    }
}
