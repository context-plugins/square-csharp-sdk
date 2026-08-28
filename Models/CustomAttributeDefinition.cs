using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a definition for custom attribute values. A custom attribute definition
/// specifies the key, visibility, schema, and other properties for a custom attribute.
/// </summary>
public record CustomAttributeDefinition
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
    /// <para>
    /// This field can not be changed
    /// after the custom attribute definition is created. This field is required when creating
    /// a definition and must be unique per application, seller, and resource type.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    [MinLength(1)]
    [RegularExpression("^([a-zA-Z0-9\\._-]+:)?[a-zA-Z0-9\\._-]{1,60}$")]
    public string? Key { get; init; }

    /// <summary>
    /// The JSON schema for the custom attribute definition, which determines the data type of the corresponding custom attributes. For more information,
    /// see <see href="https://developer.squareup.com/docs/devtools/customattributes/overview">Custom Attributes Overview</see>. This field is required when creating a definition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schema")]
    public object? Schema { get; init; }

    /// <summary>
    /// The name of the custom attribute definition for API and seller-facing UI purposes. The name must
    /// be unique within the seller and application pair. This field is required if the
    /// <c>visibility</c> field is <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// Seller-oriented description of the custom attribute definition, including any constraints
    /// that the seller should observe. May be displayed as a tooltip in Square UIs. This field is
    /// required if the <c>visibility</c> field is <c>VISIBILITY_READ_ONLY</c> or <c>VISIBILITY_READ_WRITE_VALUES</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(255)]
    public string? Description { get; init; }

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
    /// Read only. The current version of the custom attribute definition.
    /// The value is incremented each time the custom attribute definition is updated.
    /// When updating a custom attribute definition, you can provide this field
    /// and specify the current version of the custom attribute definition to enable
    /// <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see>.
    /// <para>
    /// On writes, this field must be set to the latest version. Stale writes are rejected.
    /// </para>
    /// <para>
    /// This field can also be used to enforce strong consistency for reads. For more information about strong consistency for reads,
    /// see <see href="https://developer.squareup.com/docs/devtools/customattributes/overview">Custom Attributes Overview</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// The timestamp that indicates when the custom attribute definition was created or most recently updated,
    /// in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The timestamp that indicates when the custom attribute definition was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
