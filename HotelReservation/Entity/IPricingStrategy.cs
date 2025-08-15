namespace HotelReservation.Entity;

public interface IPricingStrategy
{
    public decimal Calculate(decimal price);
}


public class LowSeasoningPricing : IPricingStrategy
{
    PricingStrategySetting _pricingStrategySetting;
    public LowSeasoningPricing(PricingStrategySetting pricingStrategySetting)
    {
        _pricingStrategySetting = pricingStrategySetting;
    }
    public decimal Calculate(decimal price)
    {
        var discountPercent = _pricingStrategySetting.PricingStrategyPercent[this];

        var finalAmount = price - (price * discountPercent);
        return finalAmount;
    }
}


public class HighSeasoningPricing : IPricingStrategy
{
    PricingStrategySetting _pricingStrategySetting;
    public HighSeasoningPricing(PricingStrategySetting pricingStrategySetting)
    {
        _pricingStrategySetting = pricingStrategySetting;
    }

    public decimal Calculate(decimal price)
    {
        var discountPercent = _pricingStrategySetting.PricingStrategyPercent[this];

        var finalAmount = price + (price * discountPercent);
        return finalAmount;
    }
}
