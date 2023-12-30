namespace InterfaceSegregation
{
    public interface IPaymentManager
    {
        void PayOnline();
        void Confirm();
    }

    public class PaymentManager : IPaymentManager
    {
        public void Confirm()
        {
            Console.WriteLine("Payment Confirmed");
        }

        public void PayOnline()
        {
            Console.WriteLine("Paied successfully");
        }
    }

    interface IMembershipManager
    {
        void Login();
        void Logout();
    }

    class MembershipManager : IMembershipManager
    {
        public void Login()
        {
            Console.WriteLine("Logged in successfully!");
        }

        public void Logout()
        {
            Console.WriteLine("Logged out successfully!");
        }
    }
}
