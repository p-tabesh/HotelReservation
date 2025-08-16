namespace HotelReservation.Entity.Pricing;

public class LowSeasoningPricing : IPricingStrategy
{
    PricingStrategySetting _pricingStrategySetting;

    public LowSeasoningPricing(PricingStrategySetting pricingStrategySetting)
    {
        _pricingStrategySetting = pricingStrategySetting;
    }

    public decimal Calculate(decimal price)
    {
        var discountPercent = _pricingStrategySetting.PricingStrategyPercent[nameof(LowSeasoningPricing)];

        var finalAmount = price - price * discountPercent;
        return finalAmount;
    }
}
