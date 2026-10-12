using Square.Models;

namespace Square.Requests.Cards;

/// <summary>
/// The inputs of the CreateCard operation.
/// </summary>
public sealed record CreateCardOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateCardRequest Body { get; init; }
}
