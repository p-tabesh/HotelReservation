using HotelReservation.Discount.Discount;
using HotelReservation.Discount.DiscountSetting;

namespace HotelReservation.Discount.DiscountRule;

public class VIPCustomerDiscountRule : IDiscountRule
{
    VIPCustomerDiscountSetting _setting;

    public VIPCustomerDiscountRule(VIPCustomerDiscountSetting setting)
    {
        _setting = setting;
    }

    public IDiscount CreateDiscount() => new VIPCustomerDiscount(_setting);

    public bool IsApplicable(DiscountContext context) => _setting.VIPCustomers.Contains(context.Customer.PhoneNumber);
}
