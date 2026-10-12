<!-- Generated file — do not edit; regenerated with the SDK. -->

# Channels — operations

Accessor: `client.Channels` · Source: `src/Square/Api/Channels.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkRetrieveChannels

- **Auth**: `options.Oauth2`
- **Signature**: `BulkRetrieveChannels(BulkRetrieveChannelsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkRetrieveChannelsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRetrieveChannelsOperationRequest` | `src/Square/Requests/Channels/BulkRetrieveChannelsOperationRequest.cs` |
| `BulkRetrieveChannelsRequest` | `src/Square/Models/BulkRetrieveChannelsRequest.cs` |
| `BulkRetrieveChannelsResponse` | `src/Square/Models/BulkRetrieveChannelsResponse.cs` |

### ListChannels

- **Auth**: `options.Oauth2`
- **Signature**: `ListChannels(ListChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `reference_type` ← `ReferenceType`, `reference_id` ← `ReferenceId`, `status` ← `Status`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListChannelsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListChannelsRequest` | `src/Square/Requests/Channels/ListChannelsRequest.cs` |
| `ReferenceType` | `src/Square/Models/Enums/ReferenceType.cs` |
| `ChannelStatus` | `src/Square/Models/Enums/ChannelStatus.cs` |
| `ListChannelsResponse` | `src/Square/Models/ListChannelsResponse.cs` |

### RetrieveChannel

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveChannel(RetrieveChannelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ChannelId`
- **Returns**: `RetrieveChannelResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveChannelRequest` | `src/Square/Requests/Channels/RetrieveChannelRequest.cs` |
| `RetrieveChannelResponse` | `src/Square/Models/RetrieveChannelResponse.cs` |

