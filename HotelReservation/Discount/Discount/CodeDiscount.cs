using HotelReservation.Discount.DiscountSetting;

namespace HotelReservation.Discount.Discount;

public class CodeDiscount : IDiscount
{
    CodeDiscountSetting _discountSetting;

    public CodeDiscount(CodeDiscountSetting discountSetting)
    {
        _discountSetting = discountSetting;
    }

    public decimal CalcualteDiscount(decimal price)
    {
        string _code = "";
        if (_discountSetting.CodeDiscounts.ContainsKey(_code))
        {
            var discount = _discountSetting.CodeDiscounts[_code];
            return price * (discount / 100m);
        }
        return 0;
    }
}
