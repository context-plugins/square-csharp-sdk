<!-- Generated file — do not edit; regenerated with the SDK. -->

# Subscriptions — operations

Accessor: `client.Subscriptions` · Source: `Api/Subscriptions.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkSwapPlan

- **Auth**: `options.Oauth2`
- **Signature**: `BulkSwapPlan(BulkSwapPlanRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkSwapPlanResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkSwapPlanRequest` | `Models/BulkSwapPlanRequest.cs` |
| `BulkSwapPlanResponse` | `Models/BulkSwapPlanResponse.cs` |

### CancelSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CancelSubscription(string subscriptionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelSubscriptionResponse` | `Models/CancelSubscriptionResponse.cs` |

### ChangeBillingAnchorDate

- **Auth**: `options.Oauth2`
- **Signature**: `ChangeBillingAnchorDate(string subscriptionId, ChangeBillingAnchorDateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ChangeBillingAnchorDateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangeBillingAnchorDateRequest` | `Models/ChangeBillingAnchorDateRequest.cs` |
| `ChangeBillingAnchorDateResponse` | `Models/ChangeBillingAnchorDateResponse.cs` |

### CreateSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CreateSubscription(CreateSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateSubscriptionRequest` | `Models/CreateSubscriptionRequest.cs` |
| `CreateSubscriptionResponse` | `Models/CreateSubscriptionResponse.cs` |

### DeleteSubscriptionAction

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteSubscriptionAction(string subscriptionId, string actionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteSubscriptionActionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteSubscriptionActionResponse` | `Models/DeleteSubscriptionActionResponse.cs` |

### ListSubscriptionEvents

- **Auth**: `options.Oauth2`
- **Signature**: `ListSubscriptionEvents(string subscriptionId, string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ListSubscriptionEventsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionEventsResponse` | `Models/ListSubscriptionEventsResponse.cs` |

### PauseSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `PauseSubscription(string subscriptionId, PauseSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PauseSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PauseSubscriptionRequest` | `Models/PauseSubscriptionRequest.cs` |
| `PauseSubscriptionResponse` | `Models/PauseSubscriptionResponse.cs` |

### ResumeSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `ResumeSubscription(string subscriptionId, ResumeSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ResumeSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ResumeSubscriptionRequest` | `Models/ResumeSubscriptionRequest.cs` |
| `ResumeSubscriptionResponse` | `Models/ResumeSubscriptionResponse.cs` |

### RetrieveSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveSubscription(string subscriptionId, string? include, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include` ← `include`
- **Returns**: `RetrieveSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveSubscriptionResponse` | `Models/RetrieveSubscriptionResponse.cs` |

### SearchSubscriptions

- **Auth**: `options.Oauth2`
- **Signature**: `SearchSubscriptions(SearchSubscriptionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchSubscriptionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchSubscriptionsRequest` | `Models/SearchSubscriptionsRequest.cs` |
| `SearchSubscriptionsResponse` | `Models/SearchSubscriptionsResponse.cs` |

### SwapPlan

- **Auth**: `options.Oauth2`
- **Signature**: `SwapPlan(string subscriptionId, SwapPlanRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SwapPlanResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SwapPlanRequest` | `Models/SwapPlanRequest.cs` |
| `SwapPlanResponse` | `Models/SwapPlanResponse.cs` |

### UpdateSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateSubscription(string subscriptionId, UpdateSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateSubscriptionRequest` | `Models/UpdateSubscriptionRequest.cs` |
| `UpdateSubscriptionResponse` | `Models/UpdateSubscriptionResponse.cs` |

