using Arithemetic_Calc.Services;

namespace Test_Calc
{
    public class UnitTest1
    {
        [Fact]
        public void Add_Returns_Correct_Sum()
        {
            var calc = new CalculatorService();
            var result = calc.Add(5, 5);
            Assert.Equal(10, result);

        }
        [Fact]
        public void Subtraction_Returns_Correct_Difference()
        {
            var calc = new CalculatorService();
            var result = calc.Difference(5, 5);
            Assert.Equal(0, result);

        }
        [Fact]
        public void Multiplication_Returns_Correct_Product()
        {
            var calc = new CalculatorService();
            var result = calc.Product(5, 5);
            Assert.Equal(25, result);

        }
        [Fact]
        public void Division_Returns_Correct_Quotient()
        {
            var calc = new CalculatorService();
            var result = calc.Division(5,5);
            Assert.Equal(1, result);

        }
    }
}