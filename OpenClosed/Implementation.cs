namespace OpenClosed
{
    public abstract class Customer
    {
        public float Price { get; set; }

        public abstract float CalculateDiscount();
    }

    public class GoldenCustomer : Customer
    {
        public override float CalculateDiscount()
        {
            return Price * 0.10f;
        }
    }

    public class SilverCustomer : Customer
    {
        public override float CalculateDiscount()
        {
            return Price * 0.05f;
        }
    }
}
