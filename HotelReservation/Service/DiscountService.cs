using HotelReservation.Entity;
using HotelReservation.Entity.Discount;

namespace HotelReservation.Service;

public class DiscountService
{
    IDiscount _discount;
    Reservation _reservation;
    public DiscountService(Reservation reservation, IDiscount discount)
    {
        _reservation = reservation;
        _discount = discount;
    }

    public void ApplyDiscount()
    {
        var discount = _discount.CalcualteDiscount(_reservation);
        _reservation.ApplyDiscount(discount);
    }
}
