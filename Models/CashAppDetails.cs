using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Additional details about <c>WALLET</c> type payments with the <c>brand</c> of <c>CASH_APP</c>.
/// </summary>
public record CashAppDetails
{
    /// <summary>
    /// The name of the Cash App account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_full_name")]
    [MaxLength(255)]
    public string? BuyerFullName { get; init; }

    /// <summary>
    /// The country of the Cash App account holder, in ISO 3166-1-alpha-2 format.
    /// <para>
    /// For possible values, see <see href="entity:Country">Country</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_country_code")]
    [StringLength(2, MinimumLength = 2)]
    public string? BuyerCountryCode { get; init; }

    /// <summary>
    /// $Cashtag of the Cash App account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_cashtag")]
    [StringLength(21, MinimumLength = 1)]
    public string? BuyerCashtag { get; init; }
}
