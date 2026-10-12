using Square.Core.Models;
using Square.Models;

namespace Square.Requests.Catalog;

/// <summary>
/// The inputs of the CreateCatalogImage operation.
/// </summary>
public sealed record CreateCatalogImageOperationRequest
{
    public CreateCatalogImageRequest? Request { get; init; }

    public BinaryContent? ImageFile { get; init; }
}
