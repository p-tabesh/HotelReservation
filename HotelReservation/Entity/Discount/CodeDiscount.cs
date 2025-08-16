namespace HotelReservation.Entity.Discount;

public class CodeDiscount : IDiscount
{
    string _code;
    CodeDiscountSetting _discountSetting;
    public CodeDiscount(CodeDiscountSetting discountSetting, string Code)
    {
        _discountSetting = discountSetting;
        _code = Code;
    }

    public decimal CalcualteDiscount(decimal price)
    {
        if (_discountSetting.CodeDiscounts.ContainsKey(_code))
        {
            var discount = _discountSetting.CodeDiscounts[_code];
            return price * (discount / 100m);
        }
        return 0;
    }
}
