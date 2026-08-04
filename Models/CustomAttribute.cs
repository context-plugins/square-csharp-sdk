using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// A custom attribute value. Each custom attribute value has a corresponding
/// <c>CustomAttributeDefinition</c> object.
/// </summary>
public record CustomAttribute
{
    /// <summary>
    /// The identifier
    /// of the custom attribute definition and its corresponding custom attributes. This value
    /// can be a simple key, which is the key that is provided when the custom attribute definition
    /// is created, or a qualified key, if the requesting
    /// application is not the definition owner. The qualified key consists of the application ID
    /// of the custom attribute definition owner
    /// followed by the simple key that was provided when the definition was created. It has the
    /// format application_id:simple key.
    /// <para>
    /// The value for a simple key can contain up to 60 alphanumeric characters, periods (.),
    /// underscores (_), and hyphens (-).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    [MinLength(1)]
    [RegularExpression("^([a-zA-Z0-9\\._-]+:)?[a-zA-Z0-9\\._-]{1,60}$")]
    public string? Key { get; init; }

    /// <summary>
    /// The value assigned to the custom attribute. It is validated against the custom
    /// attribute definition's schema on write operations. For more information about custom
    /// attribute values,
    /// see <see href="https://developer.squareup.com/docs/devtools/customattributes/overview">Custom Attributes Overview</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public object? Value { get; init; }

    /// <summary>
    /// Read only. The current version of the custom attribute. This field is incremented when the custom attribute is changed.
    /// When updating an existing custom attribute value, you can provide this field
    /// and specify the current version of the custom attribute to enable
    /// <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see>.
    /// This field can also be used to enforce strong consistency for reads. For more information about strong consistency for reads,
    /// see <see href="https://developer.squareup.com/docs/devtools/customattributes/overview">Custom Attributes Overview</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// The level of permission that a seller or other applications requires to
    /// view this custom attribute definition.
    /// The <c>Visibility</c> field controls who can read and write the custom attribute values
    /// and custom attribute definition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visibility")]
    public CustomAttributeDefinitionVisibility? Visibility { get; init; }

    /// <summary>
    /// Represents a definition for custom attribute values. A custom attribute definition
    /// specifies the key, visibility, schema, and other properties for a custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("definition")]
    public CustomAttributeDefinition? Definition { get; init; }

    /// <summary>
    /// The timestamp that indicates when the custom attribute was created or was most recently
    /// updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The timestamp that indicates when the custom attribute was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
}
