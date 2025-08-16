using HotelReservation.Discount.DiscountSetting;

namespace HotelReservation.Discount.Discount;

public class VIPCustomerDiscount : IDiscount
{
    VIPCustomerDiscountSetting _discountSetting;

    public VIPCustomerDiscount(VIPCustomerDiscountSetting discountSetting)
    {
        _discountSetting = discountSetting;
    }

    public decimal CalcualteDiscount(decimal price)
    {
        return price * (_discountSetting.DiscountPercent / 100m);
    }
}



