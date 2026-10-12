<!-- Generated file — do not edit; regenerated with the SDK. -->

# Loyalty — operations

Accessor: `client.Loyalty` · Source: `src/Square/Api/Loyalty.cs` · 18 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccumulateLoyaltyPoints

- **Auth**: `options.Oauth2`
- **Signature**: `AccumulateLoyaltyPoints(AccumulateLoyaltyPointsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountId`, `Body`
- **Returns**: `AccumulateLoyaltyPointsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccumulateLoyaltyPointsOperationRequest` | `src/Square/Requests/Loyalty/AccumulateLoyaltyPointsOperationRequest.cs` |
| `AccumulateLoyaltyPointsRequest` | `src/Square/Models/AccumulateLoyaltyPointsRequest.cs` |
| `AccumulateLoyaltyPointsResponse` | `src/Square/Models/AccumulateLoyaltyPointsResponse.cs` |

### AdjustLoyaltyPoints

- **Auth**: `options.Oauth2`
- **Signature**: `AdjustLoyaltyPoints(AdjustLoyaltyPointsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountId`, `Body`
- **Returns**: `AdjustLoyaltyPointsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdjustLoyaltyPointsOperationRequest` | `src/Square/Requests/Loyalty/AdjustLoyaltyPointsOperationRequest.cs` |
| `AdjustLoyaltyPointsRequest` | `src/Square/Models/AdjustLoyaltyPointsRequest.cs` |
| `AdjustLoyaltyPointsResponse` | `src/Square/Models/AdjustLoyaltyPointsResponse.cs` |

### CalculateLoyaltyPoints

- **Auth**: `options.Oauth2`
- **Signature**: `CalculateLoyaltyPoints(CalculateLoyaltyPointsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProgramId`, `Body`
- **Returns**: `CalculateLoyaltyPointsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CalculateLoyaltyPointsOperationRequest` | `src/Square/Requests/Loyalty/CalculateLoyaltyPointsOperationRequest.cs` |
| `CalculateLoyaltyPointsRequest` | `src/Square/Models/CalculateLoyaltyPointsRequest.cs` |
| `CalculateLoyaltyPointsResponse` | `src/Square/Models/CalculateLoyaltyPointsResponse.cs` |

### CancelLoyaltyPromotion

- **Auth**: `options.Oauth2`
- **Signature**: `CancelLoyaltyPromotion(CancelLoyaltyPromotionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PromotionId`, `ProgramId`
- **Returns**: `CancelLoyaltyPromotionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelLoyaltyPromotionRequest` | `src/Square/Requests/Loyalty/CancelLoyaltyPromotionRequest.cs` |
| `CancelLoyaltyPromotionResponse` | `src/Square/Models/CancelLoyaltyPromotionResponse.cs` |

### CreateLoyaltyAccount

- **Auth**: `options.Oauth2`
- **Signature**: `CreateLoyaltyAccount(CreateLoyaltyAccountOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateLoyaltyAccountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateLoyaltyAccountOperationRequest` | `src/Square/Requests/Loyalty/CreateLoyaltyAccountOperationRequest.cs` |
| `CreateLoyaltyAccountRequest` | `src/Square/Models/CreateLoyaltyAccountRequest.cs` |
| `CreateLoyaltyAccountResponse` | `src/Square/Models/CreateLoyaltyAccountResponse.cs` |

### CreateLoyaltyPromotion

- **Auth**: `options.Oauth2`
- **Signature**: `CreateLoyaltyPromotion(CreateLoyaltyPromotionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProgramId`, `Body`
- **Returns**: `CreateLoyaltyPromotionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateLoyaltyPromotionOperationRequest` | `src/Square/Requests/Loyalty/CreateLoyaltyPromotionOperationRequest.cs` |
| `CreateLoyaltyPromotionRequest` | `src/Square/Models/CreateLoyaltyPromotionRequest.cs` |
| `CreateLoyaltyPromotionResponse` | `src/Square/Models/CreateLoyaltyPromotionResponse.cs` |

### CreateLoyaltyReward

- **Auth**: `options.Oauth2`
- **Signature**: `CreateLoyaltyReward(CreateLoyaltyRewardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateLoyaltyRewardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateLoyaltyRewardOperationRequest` | `src/Square/Requests/Loyalty/CreateLoyaltyRewardOperationRequest.cs` |
| `CreateLoyaltyRewardRequest` | `src/Square/Models/CreateLoyaltyRewardRequest.cs` |
| `CreateLoyaltyRewardResponse` | `src/Square/Models/CreateLoyaltyRewardResponse.cs` |

### DeleteLoyaltyReward

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteLoyaltyReward(DeleteLoyaltyRewardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RewardId`
- **Returns**: `DeleteLoyaltyRewardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteLoyaltyRewardRequest` | `src/Square/Requests/Loyalty/DeleteLoyaltyRewardRequest.cs` |
| `DeleteLoyaltyRewardResponse` | `src/Square/Models/DeleteLoyaltyRewardResponse.cs` |

### ListLoyaltyPrograms

- **Auth**: `options.Oauth2`
- **Signature**: `ListLoyaltyPrograms(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ListLoyaltyProgramsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLoyaltyProgramsResponse` | `src/Square/Models/ListLoyaltyProgramsResponse.cs` |

### ListLoyaltyPromotions

- **Auth**: `options.Oauth2`
- **Signature**: `ListLoyaltyPromotions(ListLoyaltyPromotionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProgramId`
- **Query params (wire ← C#)**: `status` ← `Status`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `ListLoyaltyPromotionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLoyaltyPromotionsRequest` | `src/Square/Requests/Loyalty/ListLoyaltyPromotionsRequest.cs` |
| `LoyaltyPromotionStatus` | `src/Square/Models/Enums/LoyaltyPromotionStatus.cs` |
| `ListLoyaltyPromotionsResponse` | `src/Square/Models/ListLoyaltyPromotionsResponse.cs` |

### RedeemLoyaltyReward

- **Auth**: `options.Oauth2`
- **Signature**: `RedeemLoyaltyReward(RedeemLoyaltyRewardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RewardId`, `Body`
- **Returns**: `RedeemLoyaltyRewardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RedeemLoyaltyRewardOperationRequest` | `src/Square/Requests/Loyalty/RedeemLoyaltyRewardOperationRequest.cs` |
| `RedeemLoyaltyRewardRequest` | `src/Square/Models/RedeemLoyaltyRewardRequest.cs` |
| `RedeemLoyaltyRewardResponse` | `src/Square/Models/RedeemLoyaltyRewardResponse.cs` |

### RetrieveLoyaltyAccount

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLoyaltyAccount(RetrieveLoyaltyAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AccountId`
- **Returns**: `RetrieveLoyaltyAccountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLoyaltyAccountRequest` | `src/Square/Requests/Loyalty/RetrieveLoyaltyAccountRequest.cs` |
| `RetrieveLoyaltyAccountResponse` | `src/Square/Models/RetrieveLoyaltyAccountResponse.cs` |

### RetrieveLoyaltyProgram

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLoyaltyProgram(RetrieveLoyaltyProgramRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProgramId`
- **Returns**: `RetrieveLoyaltyProgramResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLoyaltyProgramRequest` | `src/Square/Requests/Loyalty/RetrieveLoyaltyProgramRequest.cs` |
| `RetrieveLoyaltyProgramResponse` | `src/Square/Models/RetrieveLoyaltyProgramResponse.cs` |

### RetrieveLoyaltyPromotion

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLoyaltyPromotion(RetrieveLoyaltyPromotionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PromotionId`, `ProgramId`
- **Returns**: `RetrieveLoyaltyPromotionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLoyaltyPromotionRequest` | `src/Square/Requests/Loyalty/RetrieveLoyaltyPromotionRequest.cs` |
| `RetrieveLoyaltyPromotionResponse` | `src/Square/Models/RetrieveLoyaltyPromotionResponse.cs` |

### RetrieveLoyaltyReward

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLoyaltyReward(RetrieveLoyaltyRewardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RewardId`
- **Returns**: `RetrieveLoyaltyRewardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLoyaltyRewardRequest` | `src/Square/Requests/Loyalty/RetrieveLoyaltyRewardRequest.cs` |
| `RetrieveLoyaltyRewardResponse` | `src/Square/Models/RetrieveLoyaltyRewardResponse.cs` |

### SearchLoyaltyAccounts

- **Auth**: `options.Oauth2`
- **Signature**: `SearchLoyaltyAccounts(SearchLoyaltyAccountsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchLoyaltyAccountsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchLoyaltyAccountsOperationRequest` | `src/Square/Requests/Loyalty/SearchLoyaltyAccountsOperationRequest.cs` |
| `SearchLoyaltyAccountsRequest` | `src/Square/Models/SearchLoyaltyAccountsRequest.cs` |
| `SearchLoyaltyAccountsResponse` | `src/Square/Models/SearchLoyaltyAccountsResponse.cs` |

### SearchLoyaltyEvents

- **Auth**: `options.Oauth2`
- **Signature**: `SearchLoyaltyEvents(SearchLoyaltyEventsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchLoyaltyEventsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchLoyaltyEventsOperationRequest` | `src/Square/Requests/Loyalty/SearchLoyaltyEventsOperationRequest.cs` |
| `SearchLoyaltyEventsRequest` | `src/Square/Models/SearchLoyaltyEventsRequest.cs` |
| `SearchLoyaltyEventsResponse` | `src/Square/Models/SearchLoyaltyEventsResponse.cs` |

### SearchLoyaltyRewards

- **Auth**: `options.Oauth2`
- **Signature**: `SearchLoyaltyRewards(SearchLoyaltyRewardsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchLoyaltyRewardsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchLoyaltyRewardsOperationRequest` | `src/Square/Requests/Loyalty/SearchLoyaltyRewardsOperationRequest.cs` |
| `SearchLoyaltyRewardsRequest` | `src/Square/Models/SearchLoyaltyRewardsRequest.cs` |
| `SearchLoyaltyRewardsResponse` | `src/Square/Models/SearchLoyaltyRewardsResponse.cs` |

