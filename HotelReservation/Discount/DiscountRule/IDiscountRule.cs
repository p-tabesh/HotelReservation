using HotelReservation.Discount.Discount;

namespace HotelReservation.Discount.DiscountRule;

public interface IDiscountRule
{
    bool IsApplicable(DiscountContext discountContext);
    IDiscount CreateDiscount();
}
