namespace LiskovSubstitution
{
    public abstract class Product
    {
        public string Name { get; }

        public string Model { get; set; }

        public abstract int GetProductOffer();
    }

    public class TShirt : Product
    {
        public string Color { get; set; }
        public override int GetProductOffer()
        {
            return 70;
        }
    }

    public class Car : Product
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public override int GetProductOffer()
        {
            return 50;
        }
    }

    public class CheckProduct
    {
        public static int GetProductOffer(Product product)
        {
            return product.GetProductOffer();
        }
    }
}
