namespace Square.Requests.Snippets;

/// <summary>
/// The inputs of the RetrieveSnippet operation.
/// </summary>
public sealed record RetrieveSnippetRequest
{
    /// <summary>
    /// The ID of the site that contains the snippet.
    /// </summary>
    public required string SiteId { get; init; }
}
