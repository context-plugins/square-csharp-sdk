using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The <c>line_item_application</c> describes what order line items this fulfillment applies
/// to. It can be <c>ALL</c> or <c>ENTRY_LIST</c> with a supplied list of fulfillment entries.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FulfillmentFulfillmentLineItemApplication>))]
public sealed record FulfillmentFulfillmentLineItemApplication : StringEnum<FulfillmentFulfillmentLineItemApplication>
{
    private FulfillmentFulfillmentLineItemApplication(string value) : base(value)
    {
    }

    /// <summary>
    /// If <c>ALL</c>, <c>entries</c> must be unset.
    /// </summary>
    public static readonly FulfillmentFulfillmentLineItemApplication All = new("ALL");

    /// <summary>
    /// If <c>ENTRY_LIST</c>, supply a list of <c>entries</c>.
    /// </summary>
    public static readonly FulfillmentFulfillmentLineItemApplication EntryList = new("ENTRY_LIST");

    public static FulfillmentFulfillmentLineItemApplication FromValue(string value) => FromValueCore(value);
}
