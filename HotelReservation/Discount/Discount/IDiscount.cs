namespace HotelReservation.Discount.Discount;

public interface IDiscount
{
    decimal CalcualteDiscount(decimal price);
}

