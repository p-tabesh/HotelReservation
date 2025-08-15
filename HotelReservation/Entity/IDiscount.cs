namespace HotelReservation.Entity;

public interface IDiscount
{
    decimal CalcualteDiscount(Reservation reservation);
}


public class VIPCustomerDiscount : IDiscount
{
    Customer _customer;
    DiscountSetting _discountSetting;
    public VIPCustomerDiscount(Customer customer,DiscountSetting discountSetting)
    {
        _customer = customer;
        _discountSetting = discountSetting;
    }
    public decimal CalcualteDiscount(Reservation reservation)
    {
        if (_discountSetting.VIPCustomersDiscount.ContainsKey(_customer))
        {
            var discount = _discountSetting.VIPCustomersDiscount[_customer];

        }
    }
}