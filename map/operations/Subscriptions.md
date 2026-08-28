<!-- Generated file — do not edit; regenerated with the SDK. -->

# Subscriptions — operations

Accessor: `client.Subscriptions` · Source: `Api/Subscriptions.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkSwapPlan

- **Signature**: `BulkSwapPlan(BulkSwapPlanRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BulkSwapPlanResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkSwapPlanRequest` | `Models/BulkSwapPlanRequest.cs` |
| `BulkSwapPlanResponse` | `Models/BulkSwapPlanResponse.cs` |

### CancelSubscription

- **Signature**: `CancelSubscription(string subscriptionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelSubscriptionResponse` | `Models/CancelSubscriptionResponse.cs` |

### ChangeBillingAnchorDate

- **Signature**: `ChangeBillingAnchorDate(string subscriptionId, ChangeBillingAnchorDateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ChangeBillingAnchorDateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangeBillingAnchorDateRequest` | `Models/ChangeBillingAnchorDateRequest.cs` |
| `ChangeBillingAnchorDateResponse` | `Models/ChangeBillingAnchorDateResponse.cs` |

### CreateSubscription

- **Signature**: `CreateSubscription(CreateSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateSubscriptionRequest` | `Models/CreateSubscriptionRequest.cs` |
| `CreateSubscriptionResponse` | `Models/CreateSubscriptionResponse.cs` |

### DeleteSubscriptionAction

- **Signature**: `DeleteSubscriptionAction(string subscriptionId, string actionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteSubscriptionActionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteSubscriptionActionResponse` | `Models/DeleteSubscriptionActionResponse.cs` |

### ListSubscriptionEvents

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

- **Signature**: `PauseSubscription(string subscriptionId, PauseSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PauseSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PauseSubscriptionRequest` | `Models/PauseSubscriptionRequest.cs` |
| `PauseSubscriptionResponse` | `Models/PauseSubscriptionResponse.cs` |

### ResumeSubscription

- **Signature**: `ResumeSubscription(string subscriptionId, ResumeSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ResumeSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ResumeSubscriptionRequest` | `Models/ResumeSubscriptionRequest.cs` |
| `ResumeSubscriptionResponse` | `Models/ResumeSubscriptionResponse.cs` |

### RetrieveSubscription

- **Signature**: `RetrieveSubscription(string subscriptionId, string? include, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include` ← `include`
- **Returns**: `RetrieveSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveSubscriptionResponse` | `Models/RetrieveSubscriptionResponse.cs` |

### SearchSubscriptions

- **Signature**: `SearchSubscriptions(SearchSubscriptionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchSubscriptionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchSubscriptionsRequest` | `Models/SearchSubscriptionsRequest.cs` |
| `SearchSubscriptionsResponse` | `Models/SearchSubscriptionsResponse.cs` |

### SwapPlan

- **Signature**: `SwapPlan(string subscriptionId, SwapPlanRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SwapPlanResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SwapPlanRequest` | `Models/SwapPlanRequest.cs` |
| `SwapPlanResponse` | `Models/SwapPlanResponse.cs` |

### UpdateSubscription

- **Signature**: `UpdateSubscription(string subscriptionId, UpdateSubscriptionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateSubscriptionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateSubscriptionRequest` | `Models/UpdateSubscriptionRequest.cs` |
| `UpdateSubscriptionResponse` | `Models/UpdateSubscriptionResponse.cs` |

