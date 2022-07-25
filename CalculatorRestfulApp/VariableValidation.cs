namespace CalculatorRestfulApp
{
    public class VariableValidation
    {
        public static void EnsureValidVariables(int varOne, int varTwo)
        {
            if ((varOne < 0) || (varTwo < 0))
            {
                throw new ArgumentException("Variables must be greater than zero");
            }
        }
    }
}
