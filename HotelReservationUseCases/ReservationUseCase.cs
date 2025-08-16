using HotelReservation.Discount.DiscountRule;
using HotelReservation.Entity;
using HotelReservation.Entity.Pricing;
using HotelReservation.Service;

namespace HotelReservationUseCases;

public class ReservationUseCase
{
    public void Reserve(ReservationDto reservationDto)
    {
        var room = new Room(); // get from repo after selected by user
        var customer = new Customer("", "", ""); // get from user identity
        var reservation = new Reservation(reservationDto.Room, reservationDto.StartDate, reservationDto.EndDate);

        reservation.SetPricingStrategy(new PricingStrategyCreator().Create()); // pass the reservation or data of it
        reservation.ApplyPricingStrategy(); // or do apply in one method  (i mean getting strategy in this method)


        // need to move discount login in its service
        var discountContext = new DiscountContext(customer, reservation, reservationDto.DiscountCode);
        var discountRules = new List<IDiscountRule>(); // get from db
        var discount = new DiscountCreator(discountRules).CreateDiscount(discountContext);

        foreach (var d in discount)
        {
            reservation.ApplyDiscount(d.CalcualteDiscount(reservation.FinalPrice)); // need to get cleaner
        }
    }
}

public class ReservationDto
{
    public Room Room { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int UserId { get; set; }
    public string DiscountCode { get; set; }
}