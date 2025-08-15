namespace HotelReservation.Entity;

public enum PaymentStatus
{
    UnPaid,
    InProgress,
    Paid,
    Failed
}

public class Payment
{
    public decimal Amount { get; private set; }
    public DateTime Date { get; private set; }
    public IPaymentMethod Method { get; private set; }

    public Payment(decimal amount)
    {
        Amount = amount;
    }

    public void Process(IPaymentMethod paymentMethod)
    {
        paymentMethod.ProcessPayment(Amount);
    }
}
