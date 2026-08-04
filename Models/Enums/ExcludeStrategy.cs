using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates which products matched by a CatalogPricingRule
/// will be excluded if the pricing rule uses an exclude set.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExcludeStrategy>))]
public sealed record ExcludeStrategy : StringEnum<ExcludeStrategy>
{
    private ExcludeStrategy(string value) : base(value)
    {
    }

    /// <summary>
    /// The least expensive matched products are excluded from the pricing. If
    /// the pricing rule is set to exclude one product and multiple products in the
    /// match set qualify as least expensive, then one will be excluded at random.
    /// <para>
    /// Excluding the least expensive product gives the best discount value to the buyer.
    /// </para>
    /// </summary>
    public static readonly ExcludeStrategy LeastExpensive = new("LEAST_EXPENSIVE");

    /// <summary>
    /// The most expensive matched product is excluded from the pricing rule.
    /// If multiple products have the same price and all qualify as least expensive,
    /// one will be excluded at random.
    /// <para>
    /// This guarantees that the most expensive product is purchased at full price.
    /// </para>
    /// </summary>
    public static readonly ExcludeStrategy MostExpensive = new("MOST_EXPENSIVE");

    /// <summary>
    /// Like MOST_EXPENSIVE, the most expensive matched product is excluded and
    /// purchased at full price. However, instead of maximizing the discount value on
    /// the remaining products (standard BOGO), the discount is applied to the CHEAPEST
    /// remaining eligible product.
    /// <para>
    /// Used by the "lowest-value free item" coupon shape where the intent is to make
    /// the least expensive item free, not the most valuable one.
    /// </para>
    /// </summary>
    public static readonly ExcludeStrategy MostExpensiveLowestValue = new("MOST_EXPENSIVE_LOWEST_VALUE");

    public static ExcludeStrategy FromValue(string value) => FromValueCore(value);
}
