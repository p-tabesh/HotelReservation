using HotelReservation.Discount.Discount;
using HotelReservation.Discount.DiscountSetting;

namespace HotelReservation.Discount.DiscountRule;

public class CodeDiscountRule : IDiscountRule
{
    CodeDiscountSetting _setting;

    public CodeDiscountRule(CodeDiscountSetting setting)
    {
        _setting = setting;
    }

    public IDiscount CreateDiscount() => new CodeDiscount(_setting);

    public bool IsApplicable(DiscountContext discountContext) => _setting.CodeDiscounts.ContainsKey(discountContext.DiscountCode);
}
