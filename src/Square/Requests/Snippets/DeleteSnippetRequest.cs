namespace Square.Requests.Snippets;

/// <summary>
/// The inputs of the DeleteSnippet operation.
/// </summary>
public sealed record DeleteSnippetRequest
{
    /// <summary>
    /// The ID of the site that contains the snippet.
    /// </summary>
    public required string SiteId { get; init; }
}
