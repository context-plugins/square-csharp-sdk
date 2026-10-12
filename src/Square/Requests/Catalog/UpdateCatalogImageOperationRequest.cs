using Square.Core.Models;
using Square.Models;

namespace Square.Requests.Catalog;

/// <summary>
/// The inputs of the UpdateCatalogImage operation.
/// </summary>
public sealed record UpdateCatalogImageOperationRequest
{
    /// <summary>
    /// The ID of the <c>CatalogImage</c> object to update the encapsulated image file.
    /// </summary>
    public required string ImageId { get; init; }

    public UpdateCatalogImageRequest? Request { get; init; }

    public BinaryContent? ImageFile { get; init; }
}
