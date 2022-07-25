
//namespace CalculatorRestfulApp.Managers
//{
//    public class CalculatorManager : ICalculatorManager
//    {
//        public int Add(int addendsOne, int addendsTwo)
//        {
//            int sum = addendsOne + addendsTwo;
//            VariableValidation.EnsureValidVariables(addendsOne, addendsTwo);

//            return sum;
//        }

//        public double Divide(int dividend, int divisor)
//        {
//            VariableValidation.EnsureValidVariables(dividend, divisor);

//            if (divisor == 0)
//                throw new ArgumentException("Divisor must be greater than zero");

//            return dividend / divisor;
//        }

//        public int Multiply(int multiplier, int multiplicand)
//        {
//            VariableValidation.EnsureValidVariables(multiplier, multiplicand);

//            return multiplier * multiplicand;

//        }

//        public int Subtract(int minuend, int subtrahend)
//        {
//            return minuend - subtrahend;
//        }
//    }
//}
//}
