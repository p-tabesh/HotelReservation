namespace HotelReservation.Entity.Discount;

public class VIPCustomerDiscount : IDiscount
{
    Customer _customer;
    DiscountSetting _discountSetting;

    public VIPCustomerDiscount(Customer customer, DiscountSetting discountSetting)
    {
        _customer = customer;
        _discountSetting = discountSetting;
    }

    public decimal CalcualteDiscount(decimal price)
    {
        if (_discountSetting.VIPCustomersDiscount.ContainsKey(_customer))
        {
            var discount = _discountSetting.VIPCustomersDiscount[_customer];
            return price * discount / 100m;
        }
        return 0;
    }
}



