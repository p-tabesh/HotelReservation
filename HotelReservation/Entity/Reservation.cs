using HotelReservation.Entity.Pricing;
using HotelReservation.Discount;

namespace HotelReservation.Entity;

public class Reservation
{
    public Room ReservationRoom { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public IPricingStrategy PricingStrategy { get; private set; }
    public decimal FinalPrice { get; private set; }

    public Reservation(Room room, DateTime startDate, DateTime endDate)
    {
        ReservationRoom = room;
        StartDate = startDate;
        EndDate = endDate;
    }

    public void SetPricingStrategy(IPricingStrategy pricingStrategy)
    {
        PricingStrategy = pricingStrategy;
    }

    public void ApplyPricingStrategy()
    {
        FinalPrice = PricingStrategy.Calculate(ReservationRoom.Price);
    }

    public void ApplyDiscount(decimal discount)
    {
        FinalPrice -= discount;
    }
}
