using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents an action processed by the Square Terminal.
/// </summary>
public record TerminalAction
{
    /// <summary>
    /// A unique ID for this <c>TerminalAction</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [StringLength(255, MinimumLength = 10)]
    public string? Id { get; init; }

    /// <summary>
    /// The unique Id of the device intended for this <c>TerminalAction</c>.
    /// The Id can be retrieved from /v2/devices api.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_id")]
    public string? DeviceId { get; init; }

    /// <summary>
    /// The duration as an RFC 3339 duration, after which the action will be automatically canceled.
    /// TerminalActions that are <c>PENDING</c> will be automatically <c>CANCELED</c> and have a cancellation reason
    /// of <c>TIMED_OUT</c>
    /// <para>
    /// Default: 5 minutes from creation
    /// </para>
    /// <para>
    /// Maximum: 5 minutes
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deadline_duration")]
    public string? DeadlineDuration { get; init; }

    /// <summary>
    /// The status of the <c>TerminalAction</c>.
    /// Options: <c>PENDING</c>, <c>IN_PROGRESS</c>, <c>CANCEL_REQUESTED</c>, <c>CANCELED</c>, <c>COMPLETED</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel_reason")]
    public ActionCancelReason? CancelReason { get; init; }

    /// <summary>
    /// The time when the <c>TerminalAction</c> was created as an RFC 3339 timestamp.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The time when the <c>TerminalAction</c> was last updated as an RFC 3339 timestamp.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The ID of the application that created the action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("app_id")]
    public string? AppId { get; init; }

    /// <summary>
    /// The location id the action is attached to, if a link can be made.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(64)]
    public string? LocationId { get; init; }

    /// <summary>
    /// Describes the type of this unit and indicates which field contains the unit information. This is an ‘open’ enum.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TerminalActionActionType? Type { get; init; }

    /// <summary>
    /// Fields to describe the action that displays QR-Codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qr_code_options")]
    public QrCodeOptions? QrCodeOptions { get; init; }

    /// <summary>
    /// Describes save-card action fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("save_card_options")]
    public SaveCardOptions? SaveCardOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature_options")]
    public SignatureOptions? SignatureOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confirmation_options")]
    public ConfirmationOptions? ConfirmationOptions { get; init; }

    /// <summary>
    /// Describes receipt action fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receipt_options")]
    public ReceiptOptions? ReceiptOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data_collection_options")]
    public DataCollectionOptions? DataCollectionOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("select_options")]
    public SelectOptions? SelectOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_metadata")]
    public DeviceMetadata? DeviceMetadata { get; init; }

    /// <summary>
    /// Indicates the action will be linked to another action and requires a waiting dialog to be
    /// displayed instead of returning to the idle screen on completion of the action.
    /// <para>
    /// Only supported on SIGNATURE, CONFIRMATION, DATA_COLLECTION, and SELECT types.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("await_next_action")]
    public bool? AwaitNextAction { get; init; }

    /// <summary>
    /// The timeout duration of the waiting dialog as an RFC 3339 duration, after which the
    /// waiting dialog will no longer be displayed and the Terminal will return to the idle screen.
    /// <para>
    /// Default: 5 minutes from when the waiting dialog is displayed
    /// </para>
    /// <para>
    /// Maximum: 5 minutes
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("await_next_action_duration")]
    public string? AwaitNextActionDuration { get; init; }
}
