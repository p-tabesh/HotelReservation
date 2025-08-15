namespace HotelReservation.Entity;

public class Reservation
{
    public Room Room { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public IPricingStrategy PricingStrategy { get; private set; }
    
    public Reservation(Room room, DateTime startDate, DateTime endDate)
    {
        
    }

    public void SetPricingStrategy(IPricingStrategy pricingStrategy)
    {
        PricingStrategy = pricingStrategy;
    }
    
    public void ApplyPricingStrategy()
    {
        PricingStrategy.Calculate(Room.Price);
    }

    public void ApplyDiscount(IDiscount discount)
    {
         = discount.CalcualteDiscount(this);
    }
}
