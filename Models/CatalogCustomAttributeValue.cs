using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// An instance of a custom attribute. Custom attributes can be defined and
/// added to <c>ITEM</c> and <c>ITEM_VARIATION</c> type catalog objects.
/// <see href="https://developer.squareup.com/docs/catalog-api/add-custom-attributes">Read more about custom attributes</see>.
/// </summary>
public record CatalogCustomAttributeValue
{
    /// <summary>
    /// The name of the custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The string value of the custom attribute.  Populated if <c>type</c> = <c>STRING</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("string_value")]
    public string? StringValue { get; init; }

    /// <summary>
    /// The id of the <see href="entity:CatalogCustomAttributeDefinition">CatalogCustomAttributeDefinition</see> this value belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_definition_id")]
    public string? CustomAttributeDefinitionId { get; init; }

    /// <summary>
    /// Defines the possible types for a custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public CatalogCustomAttributeDefinitionType? Type { get; init; }

    /// <summary>
    /// Populated if <c>type</c> = <c>NUMBER</c>. Contains a string
    /// representation of a decimal number, using a <c>.</c> as the decimal separator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number_value")]
    public string? NumberValue { get; init; }

    /// <summary>
    /// A <c>true</c> or <c>false</c> value. Populated if <c>type</c> = <c>BOOLEAN</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("boolean_value")]
    public bool? BooleanValue { get; init; }

    /// <summary>
    /// One or more choices from <c>allowed_selections</c>. Populated if <c>type</c> = <c>SELECTION</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selection_uid_values")]
    public IReadOnlyList<string?>? SelectionUidValues { get; init; }

    /// <summary>
    /// If the associated <c>CatalogCustomAttributeDefinition</c> object is defined by another application, this key is prefixed by the defining application ID.
    /// For example, if the CatalogCustomAttributeDefinition has a key attribute of "cocoa_brand" and the defining application ID is "abcd1234", this key is "abcd1234:cocoa_brand"
    /// when the application making the request is different from the application defining the custom attribute definition. Otherwise, the key is simply "cocoa_brand".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
