using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The list of possible dispute states.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisputeState>))]
public sealed record DisputeState : OpenStringEnum<DisputeState>
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

    public TResult Match<TResult>(Func<TResult> onInquiryEvidenceRequired,
        Func<TResult> onInquiryProcessing,
        Func<TResult> onInquiryClosed,
        Func<TResult> onEvidenceRequired,
        Func<TResult> onProcessing,
        Func<TResult> onWon,
        Func<TResult> onLost,
        Func<TResult> onAccepted,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InquiryEvidenceRequired => onInquiryEvidenceRequired(),
            _ when this == InquiryProcessing => onInquiryProcessing(),
            _ when this == InquiryClosed => onInquiryClosed(),
            _ when this == EvidenceRequired => onEvidenceRequired(),
            _ when this == Processing => onProcessing(),
            _ when this == Won => onWon(),
            _ when this == Lost => onLost(),
            _ when this == Accepted => onAccepted(),
            _ => otherwise(Value)
        };

    public void Match(Action onInquiryEvidenceRequired,
        Action onInquiryProcessing,
        Action onInquiryClosed,
        Action onEvidenceRequired,
        Action onProcessing,
        Action onWon,
        Action onLost,
        Action onAccepted,
        Action<string> otherwise)
    {
        if (this == InquiryEvidenceRequired) onInquiryEvidenceRequired();
        else if (this == InquiryProcessing) onInquiryProcessing();
        else if (this == InquiryClosed) onInquiryClosed();
        else if (this == EvidenceRequired) onEvidenceRequired();
        else if (this == Processing) onProcessing();
        else if (this == Won) onWon();
        else if (this == Lost) onLost();
        else if (this == Accepted) onAccepted();
        else otherwise(Value);
    }
}
