using HotelReservation.Discount.Discount;
using HotelReservation.Discount.DiscountRule;
using HotelReservation.Entity;

namespace HotelReservation.Service;

public class DiscountCreator
{
    private readonly IEnumerable<IDiscountRule> _discountRules;
    public DiscountCreator(IEnumerable<IDiscountRule> discountRules)
    {
        _discountRules = discountRules;
    }

    public IEnumerable<IDiscount> CreateDiscount(DiscountContext discountContext)
    {
        return _discountRules
            .Where(r => r.IsApplicable(discountContext))
            .Select(r => r.CreateDiscount());
    }
}
