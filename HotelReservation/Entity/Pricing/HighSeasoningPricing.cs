namespace HotelReservation.Entity.Pricing;

public class HighSeasoningPricing : IPricingStrategy
{
    PricingStrategySetting _pricingStrategySetting;
    public HighSeasoningPricing(PricingStrategySetting pricingStrategySetting)
    {
        _pricingStrategySetting = pricingStrategySetting;
    }

    public decimal Calculate(decimal price)
    {
        var discountPercent = _pricingStrategySetting.PricingStrategyPercent[nameof(HighSeasoningPricing)];

        var finalAmount = price + price * discountPercent;
        return finalAmount;
    }
}
