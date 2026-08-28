<!-- Generated file — do not edit; regenerated with the SDK. -->

# WebhookSubscriptions — operations

Accessor: `client.WebhookSubscriptions` · Source: `Api/WebhookSubscriptions.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateWebhookSubscription

- **Signature**: `CreateWebhookSubscription(CreateWebhookSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateWebhookSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateWebhookSubscriptionRequest` | `Models/CreateWebhookSubscriptionRequest.cs` |
| `CreateWebhookSubscriptionResponse` | `Models/CreateWebhookSubscriptionResponse.cs` |

### DeleteWebhookSubscription

- **Signature**: `DeleteWebhookSubscription(string subscriptionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteWebhookSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteWebhookSubscriptionResponse` | `Models/DeleteWebhookSubscriptionResponse.cs` |

### ListWebhookEventTypes

- **Signature**: `ListWebhookEventTypes(string? apiVersion, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `apiVersion` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `api_version` ← `apiVersion`
- **Returns**: `ListWebhookEventTypesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListWebhookEventTypesResponse` | `Models/ListWebhookEventTypesResponse.cs` |

### ListWebhookSubscriptions

- **Signature**: `ListWebhookSubscriptions(string? cursor, SortOrder? sortOrder, int? limit, bool? includeDisabled = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `sortOrder` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - defaults: `includeDisabled` = `false`
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `include_disabled` ← `includeDisabled`, `sort_order` ← `sortOrder`, `limit` ← `limit`
- **Returns**: `ListWebhookSubscriptionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SortOrder` | `Models/Enums/SortOrder.cs` |
| `ListWebhookSubscriptionsResponse` | `Models/ListWebhookSubscriptionsResponse.cs` |

### RetrieveWebhookSubscription

- **Signature**: `RetrieveWebhookSubscription(string subscriptionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveWebhookSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveWebhookSubscriptionResponse` | `Models/RetrieveWebhookSubscriptionResponse.cs` |

### TestWebhookSubscription

- **Signature**: `TestWebhookSubscription(string subscriptionId, TestWebhookSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TestWebhookSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TestWebhookSubscriptionRequest` | `Models/TestWebhookSubscriptionRequest.cs` |
| `TestWebhookSubscriptionResponse` | `Models/TestWebhookSubscriptionResponse.cs` |

### UpdateWebhookSubscription

- **Signature**: `UpdateWebhookSubscription(string subscriptionId, UpdateWebhookSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateWebhookSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWebhookSubscriptionRequest` | `Models/UpdateWebhookSubscriptionRequest.cs` |
| `UpdateWebhookSubscriptionResponse` | `Models/UpdateWebhookSubscriptionResponse.cs` |

### UpdateWebhookSubscriptionSignatureKey

- **Signature**: `UpdateWebhookSubscriptionSignatureKey(string subscriptionId, UpdateWebhookSubscriptionSignatureKeyRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateWebhookSubscriptionSignatureKeyResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWebhookSubscriptionSignatureKeyRequest` | `Models/UpdateWebhookSubscriptionSignatureKeyRequest.cs` |
| `UpdateWebhookSubscriptionSignatureKeyResponse` | `Models/UpdateWebhookSubscriptionSignatureKeyResponse.cs` |

