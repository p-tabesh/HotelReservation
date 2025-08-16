namespace HotelReservation.Entity.Pricing;

public interface IPricingStrategy
{
    public decimal Calculate(decimal price);
}
