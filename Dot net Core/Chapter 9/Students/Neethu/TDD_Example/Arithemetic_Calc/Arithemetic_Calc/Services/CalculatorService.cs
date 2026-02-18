namespace Arithemetic_Calc.Services
{
    public class CalculatorService
    {
        public int Add(int x, int y) => x + y;
        public int Difference(int x, int y)
        {
            if (x > y)
                return x - y;
            else
                return y - x;
        }
        public int Product(int x, int y) => x * y;
        public decimal Division(int x,int y) => x / y;
    }
}
