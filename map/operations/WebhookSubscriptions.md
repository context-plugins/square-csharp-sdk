<!-- Generated file — do not edit; regenerated with the SDK. -->

# WebhookSubscriptions — operations

Accessor: `client.WebhookSubscriptions` · Source: `src/Square/Api/WebhookSubscriptions.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateWebhookSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CreateWebhookSubscription(CreateWebhookSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateWebhookSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateWebhookSubscriptionOperationRequest` | `src/Square/Requests/WebhookSubscriptions/CreateWebhookSubscriptionOperationRequest.cs` |
| `CreateWebhookSubscriptionRequest` | `src/Square/Models/CreateWebhookSubscriptionRequest.cs` |
| `CreateWebhookSubscriptionResponse` | `src/Square/Models/CreateWebhookSubscriptionResponse.cs` |

### DeleteWebhookSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteWebhookSubscription(DeleteWebhookSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `DeleteWebhookSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteWebhookSubscriptionRequest` | `src/Square/Requests/WebhookSubscriptions/DeleteWebhookSubscriptionRequest.cs` |
| `DeleteWebhookSubscriptionResponse` | `src/Square/Models/DeleteWebhookSubscriptionResponse.cs` |

### ListWebhookEventTypes

- **Auth**: `options.Oauth2`
- **Signature**: `ListWebhookEventTypes(ListWebhookEventTypesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `api_version` ← `ApiVersion`
- **Returns**: `ListWebhookEventTypesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListWebhookEventTypesRequest` | `src/Square/Requests/WebhookSubscriptions/ListWebhookEventTypesRequest.cs` |
| `ListWebhookEventTypesResponse` | `src/Square/Models/ListWebhookEventTypesResponse.cs` |

### ListWebhookSubscriptions

- **Auth**: `options.Oauth2`
- **Signature**: `ListWebhookSubscriptions(ListWebhookSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `include_disabled` ← `IncludeDisabled`, `sort_order` ← `SortOrder`, `limit` ← `Limit`
- **Returns**: `ListWebhookSubscriptionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListWebhookSubscriptionsRequest` | `src/Square/Requests/WebhookSubscriptions/ListWebhookSubscriptionsRequest.cs` |
| `SortOrder` | `src/Square/Models/Enums/SortOrder.cs` |
| `ListWebhookSubscriptionsResponse` | `src/Square/Models/ListWebhookSubscriptionsResponse.cs` |

### RetrieveWebhookSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveWebhookSubscription(RetrieveWebhookSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `RetrieveWebhookSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveWebhookSubscriptionRequest` | `src/Square/Requests/WebhookSubscriptions/RetrieveWebhookSubscriptionRequest.cs` |
| `RetrieveWebhookSubscriptionResponse` | `src/Square/Models/RetrieveWebhookSubscriptionResponse.cs` |

### TestWebhookSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `TestWebhookSubscription(TestWebhookSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Body`
- **Returns**: `TestWebhookSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TestWebhookSubscriptionOperationRequest` | `src/Square/Requests/WebhookSubscriptions/TestWebhookSubscriptionOperationRequest.cs` |
| `TestWebhookSubscriptionRequest` | `src/Square/Models/TestWebhookSubscriptionRequest.cs` |
| `TestWebhookSubscriptionResponse` | `src/Square/Models/TestWebhookSubscriptionResponse.cs` |

### UpdateWebhookSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateWebhookSubscription(UpdateWebhookSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Body`
- **Returns**: `UpdateWebhookSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWebhookSubscriptionOperationRequest` | `src/Square/Requests/WebhookSubscriptions/UpdateWebhookSubscriptionOperationRequest.cs` |
| `UpdateWebhookSubscriptionRequest` | `src/Square/Models/UpdateWebhookSubscriptionRequest.cs` |
| `UpdateWebhookSubscriptionResponse` | `src/Square/Models/UpdateWebhookSubscriptionResponse.cs` |

### UpdateWebhookSubscriptionSignatureKey

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateWebhookSubscriptionSignatureKey(UpdateWebhookSubscriptionSignatureKeyOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Body`
- **Returns**: `UpdateWebhookSubscriptionSignatureKeyResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWebhookSubscriptionSignatureKeyOperationRequest` | `src/Square/Requests/WebhookSubscriptions/UpdateWebhookSubscriptionSignatureKeyOperationRequest.cs` |
| `UpdateWebhookSubscriptionSignatureKeyRequest` | `src/Square/Models/UpdateWebhookSubscriptionSignatureKeyRequest.cs` |
| `UpdateWebhookSubscriptionSignatureKeyResponse` | `src/Square/Models/UpdateWebhookSubscriptionSignatureKeyResponse.cs` |

