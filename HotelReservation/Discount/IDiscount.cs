using HotelReservation.Entity;

namespace HotelReservation.Discount;

public interface IDiscount
{
    decimal CalcualteDiscount(Reservation reservation);
}


