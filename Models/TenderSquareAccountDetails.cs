using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents the details of a tender with <c>type</c> <c>SQUARE_ACCOUNT</c>.
/// </summary>
public record TenderSquareAccountDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public TenderSquareAccountDetailsStatus? Status { get; init; }
}
