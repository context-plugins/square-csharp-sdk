<!-- Generated file — do not edit; regenerated with the SDK. -->

# Channels — operations

Accessor: `client.Channels` · Source: `Api/Channels.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkRetrieveChannels

- **Auth**: `options.Oauth2`
- **Signature**: `BulkRetrieveChannels(BulkRetrieveChannelsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkRetrieveChannelsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRetrieveChannelsRequest` | `Models/BulkRetrieveChannelsRequest.cs` |
| `BulkRetrieveChannelsResponse` | `Models/BulkRetrieveChannelsResponse.cs` |

### ListChannels

- **Auth**: `options.Oauth2`
- **Signature**: `ListChannels(ReferenceType? referenceType, string? referenceId, ChannelStatus? status, string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`referenceType` … `limit`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `reference_type` ← `referenceType`, `reference_id` ← `referenceId`, `status` ← `status`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ListChannelsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReferenceType` | `Models/Enums/ReferenceType.cs` |
| `ChannelStatus` | `Models/Enums/ChannelStatus.cs` |
| `ListChannelsResponse` | `Models/ListChannelsResponse.cs` |

### RetrieveChannel

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveChannel(string channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveChannelResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveChannelResponse` | `Models/RetrieveChannelResponse.cs` |

