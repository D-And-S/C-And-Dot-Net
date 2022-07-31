namespace Generic
{
    // Where T : Product (class label any of the class label or subclass label)
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}
