using HotelReservation.Entity;

namespace HotelReservation.Discount.DiscountRule;

public class DiscountContext
{
    public Customer Customer { get; private set; }
    public Reservation Reservation { get; private set; }
    public string DiscountCode { get; private set; }

    public DiscountContext(Customer customer, Reservation reservation, string discountCode)
    {
        Customer = customer;
        Reservation = reservation;
        DiscountCode = discountCode;
    }
}
