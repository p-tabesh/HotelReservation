using HotelReservation.Entity;

namespace HotelReservation.Discount;
public class VIPCustomerDiscount : IDiscount
{
    Customer _customer;
    DiscountSetting _discountSetting;
    public VIPCustomerDiscount(Customer customer, DiscountSetting discountSetting)
    {
        _customer = customer;
        _discountSetting = discountSetting;
    }
    public decimal CalcualteDiscount()
    {
        if (_discountSetting.VIPCustomersDiscount.ContainsKey(_customer))
        {
            var discount = _discountSetting.VIPCustomersDiscount[_customer];
            reservation.CalculatePrice
        }
    }