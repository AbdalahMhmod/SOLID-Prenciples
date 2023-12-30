namespace InterfaceSegregation
{
    public interface IPaymentManager
    {
        void PayOnline();
        void Confirm();
    }

    public class PaymentManagerByCredit : IPaymentManager
    {
        public void Confirm()
        {
            Console.WriteLine("Payment Confirmed by credit");
        }

        public void PayOnline()
        {
            Console.WriteLine("Paied successfully by credit");
        }
    }

    public class PaymentManagerByDebit : IPaymentManager
    {
        public void Confirm()
        {
            Console.WriteLine("Payment Confirmed by debit");
        }

        public void PayOnline()
        {
            Console.WriteLine("Paied successfully by debit");
        }
    }

    public class PaymentService
    {
        private readonly IPaymentManager _paymentManager;

        public PaymentService(IPaymentManager paymentManager)
        {
            _paymentManager = paymentManager;
        }

        public void Pay()
        {
            _paymentManager.PayOnline();
        }
    }
}
