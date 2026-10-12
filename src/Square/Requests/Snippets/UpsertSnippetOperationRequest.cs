using Square.Models;

namespace Square.Requests.Snippets;

/// <summary>
/// The inputs of the UpsertSnippet operation.
/// </summary>
public sealed record UpsertSnippetOperationRequest
{
    /// <summary>
    /// The ID of the site where you want to add or update the snippet.
    /// </summary>
    public required string SiteId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpsertSnippetRequest Body { get; init; }
}
