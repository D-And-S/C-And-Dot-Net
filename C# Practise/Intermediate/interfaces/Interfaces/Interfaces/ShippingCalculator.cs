namespace Interfaces
{
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }

    public class ShippingCalculator2 : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            System.Console.WriteLine("Hello World");
            return 0;
        }
    }
}
