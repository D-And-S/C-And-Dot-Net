using Interfaces;

namespace UnitTestProject1
{
    public partial class OrderProcessorTests
    {
        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 1;
            }
        }

    }
}
