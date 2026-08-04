using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The list of possible dispute states.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisputeState>))]
public sealed record DisputeState : StringEnum<DisputeState>
{
    private DisputeState(string value) : base(value)
    {
    }

    /// <summary>
    /// The initial state of an inquiry with evidence required
    /// </summary>
    public static readonly DisputeState InquiryEvidenceRequired = new("INQUIRY_EVIDENCE_REQUIRED");

    /// <summary>
    /// Inquiry evidence has been submitted and the bank is processing the inquiry
    /// </summary>
    public static readonly DisputeState InquiryProcessing = new("INQUIRY_PROCESSING");

    /// <summary>
    /// The inquiry is complete
    /// </summary>
    public static readonly DisputeState InquiryClosed = new("INQUIRY_CLOSED");

    /// <summary>
    /// The initial state of a dispute with evidence required
    /// </summary>
    public static readonly DisputeState EvidenceRequired = new("EVIDENCE_REQUIRED");

    /// <summary>
    /// Dispute evidence has been submitted and the bank is processing the dispute
    /// </summary>
    public static readonly DisputeState Processing = new("PROCESSING");

    /// <summary>
    /// The bank has completed processing the dispute and the seller has won
    /// </summary>
    public static readonly DisputeState Won = new("WON");

    /// <summary>
    /// The bank has completed processing the dispute and the seller has lost
    /// </summary>
    public static readonly DisputeState Lost = new("LOST");

    /// <summary>
    /// The seller has accepted the dispute
    /// </summary>
    public static readonly DisputeState Accepted = new("ACCEPTED");

    public static DisputeState FromValue(string value) => FromValueCore(value);
}
