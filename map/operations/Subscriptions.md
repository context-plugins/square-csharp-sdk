<!-- Generated file — do not edit; regenerated with the SDK. -->

# Subscriptions — operations

Accessor: `client.Subscriptions` · Source: `src/Square/Api/Subscriptions.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkSwapPlan

- **Auth**: `options.Oauth2`
- **Signature**: `BulkSwapPlan(BulkSwapPlanOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkSwapPlanResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkSwapPlanOperationRequest` | `src/Square/Requests/Subscriptions/BulkSwapPlanOperationRequest.cs` |
| `BulkSwapPlanRequest` | `src/Square/Models/BulkSwapPlanRequest.cs` |
| `BulkSwapPlanResponse` | `src/Square/Models/BulkSwapPlanResponse.cs` |

### CancelSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CancelSubscription(CancelSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `CancelSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelSubscriptionRequest` | `src/Square/Requests/Subscriptions/CancelSubscriptionRequest.cs` |
| `CancelSubscriptionResponse` | `src/Square/Models/CancelSubscriptionResponse.cs` |

### ChangeBillingAnchorDate

- **Auth**: `options.Oauth2`
- **Signature**: `ChangeBillingAnchorDate(ChangeBillingAnchorDateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Body`
- **Returns**: `ChangeBillingAnchorDateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChangeBillingAnchorDateOperationRequest` | `src/Square/Requests/Subscriptions/ChangeBillingAnchorDateOperationRequest.cs` |
| `ChangeBillingAnchorDateRequest` | `src/Square/Models/ChangeBillingAnchorDateRequest.cs` |
| `ChangeBillingAnchorDateResponse` | `src/Square/Models/ChangeBillingAnchorDateResponse.cs` |

### CreateSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CreateSubscription(CreateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateSubscriptionOperationRequest` | `src/Square/Requests/Subscriptions/CreateSubscriptionOperationRequest.cs` |
| `CreateSubscriptionRequest` | `src/Square/Models/CreateSubscriptionRequest.cs` |
| `CreateSubscriptionResponse` | `src/Square/Models/CreateSubscriptionResponse.cs` |

### DeleteSubscriptionAction

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteSubscriptionAction(DeleteSubscriptionActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ActionId`
- **Returns**: `DeleteSubscriptionActionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteSubscriptionActionRequest` | `src/Square/Requests/Subscriptions/DeleteSubscriptionActionRequest.cs` |
| `DeleteSubscriptionActionResponse` | `src/Square/Models/DeleteSubscriptionActionResponse.cs` |

### ListSubscriptionEvents

- **Auth**: `options.Oauth2`
- **Signature**: `ListSubscriptionEvents(ListSubscriptionEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListSubscriptionEventsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionEventsRequest` | `src/Square/Requests/Subscriptions/ListSubscriptionEventsRequest.cs` |
| `ListSubscriptionEventsResponse` | `src/Square/Models/ListSubscriptionEventsResponse.cs` |

### PauseSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `PauseSubscription(PauseSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Body`
- **Returns**: `PauseSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PauseSubscriptionOperationRequest` | `src/Square/Requests/Subscriptions/PauseSubscriptionOperationRequest.cs` |
| `PauseSubscriptionRequest` | `src/Square/Models/PauseSubscriptionRequest.cs` |
| `PauseSubscriptionResponse` | `src/Square/Models/PauseSubscriptionResponse.cs` |

### ResumeSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `ResumeSubscription(ResumeSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Body`
- **Returns**: `ResumeSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ResumeSubscriptionOperationRequest` | `src/Square/Requests/Subscriptions/ResumeSubscriptionOperationRequest.cs` |
| `ResumeSubscriptionRequest` | `src/Square/Models/ResumeSubscriptionRequest.cs` |
| `ResumeSubscriptionResponse` | `src/Square/Models/ResumeSubscriptionResponse.cs` |

### RetrieveSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveSubscription(RetrieveSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `include` ← `Include`
- **Returns**: `RetrieveSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveSubscriptionRequest` | `src/Square/Requests/Subscriptions/RetrieveSubscriptionRequest.cs` |
| `RetrieveSubscriptionResponse` | `src/Square/Models/RetrieveSubscriptionResponse.cs` |

### SearchSubscriptions

- **Auth**: `options.Oauth2`
- **Signature**: `SearchSubscriptions(SearchSubscriptionsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchSubscriptionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchSubscriptionsOperationRequest` | `src/Square/Requests/Subscriptions/SearchSubscriptionsOperationRequest.cs` |
| `SearchSubscriptionsRequest` | `src/Square/Models/SearchSubscriptionsRequest.cs` |
| `SearchSubscriptionsResponse` | `src/Square/Models/SearchSubscriptionsResponse.cs` |

### SwapPlan

- **Auth**: `options.Oauth2`
- **Signature**: `SwapPlan(SwapPlanOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Body`
- **Returns**: `SwapPlanResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SwapPlanOperationRequest` | `src/Square/Requests/Subscriptions/SwapPlanOperationRequest.cs` |
| `SwapPlanRequest` | `src/Square/Models/SwapPlanRequest.cs` |
| `SwapPlanResponse` | `src/Square/Models/SwapPlanResponse.cs` |

### UpdateSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateSubscription(UpdateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Body`
- **Returns**: `UpdateSubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateSubscriptionOperationRequest` | `src/Square/Requests/Subscriptions/UpdateSubscriptionOperationRequest.cs` |
| `UpdateSubscriptionRequest` | `src/Square/Models/UpdateSubscriptionRequest.cs` |
| `UpdateSubscriptionResponse` | `src/Square/Models/UpdateSubscriptionResponse.cs` |

