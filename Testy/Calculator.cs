namespace Testy
{
    public class Calculator
    {
        // Adds two integers and returns an integer
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public double AddNumbersDouble(double a, double b)
        {
            return a + b;
        }

        public bool IsOddNumber(int num)
        {
            return num % 2 != 0;
        }
    }
}
