namespace HotelReservation.Entity.Discount;

public interface IDiscount
{
    decimal CalcualteDiscount(decimal price);
}

