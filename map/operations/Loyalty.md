<!-- Generated file — do not edit; regenerated with the SDK. -->

# Loyalty — operations

Accessor: `client.Loyalty` · Source: `Api/Loyalty.cs` · 18 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccumulateLoyaltyPoints

- **Auth**: `options.Oauth2`
- **Signature**: `AccumulateLoyaltyPoints(string accountId, AccumulateLoyaltyPointsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AccumulateLoyaltyPointsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccumulateLoyaltyPointsRequest` | `Models/AccumulateLoyaltyPointsRequest.cs` |
| `AccumulateLoyaltyPointsResponse` | `Models/AccumulateLoyaltyPointsResponse.cs` |

### AdjustLoyaltyPoints

- **Auth**: `options.Oauth2`
- **Signature**: `AdjustLoyaltyPoints(string accountId, AdjustLoyaltyPointsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AdjustLoyaltyPointsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdjustLoyaltyPointsRequest` | `Models/AdjustLoyaltyPointsRequest.cs` |
| `AdjustLoyaltyPointsResponse` | `Models/AdjustLoyaltyPointsResponse.cs` |

### CalculateLoyaltyPoints

- **Auth**: `options.Oauth2`
- **Signature**: `CalculateLoyaltyPoints(string programId, CalculateLoyaltyPointsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CalculateLoyaltyPointsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CalculateLoyaltyPointsRequest` | `Models/CalculateLoyaltyPointsRequest.cs` |
| `CalculateLoyaltyPointsResponse` | `Models/CalculateLoyaltyPointsResponse.cs` |

### CancelLoyaltyPromotion

- **Auth**: `options.Oauth2`
- **Signature**: `CancelLoyaltyPromotion(string promotionId, string programId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelLoyaltyPromotionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CancelLoyaltyPromotionResponse` | `Models/CancelLoyaltyPromotionResponse.cs` |

### CreateLoyaltyAccount

- **Auth**: `options.Oauth2`
- **Signature**: `CreateLoyaltyAccount(CreateLoyaltyAccountRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateLoyaltyAccountResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateLoyaltyAccountRequest` | `Models/CreateLoyaltyAccountRequest.cs` |
| `CreateLoyaltyAccountResponse` | `Models/CreateLoyaltyAccountResponse.cs` |

### CreateLoyaltyPromotion

- **Auth**: `options.Oauth2`
- **Signature**: `CreateLoyaltyPromotion(string programId, CreateLoyaltyPromotionRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateLoyaltyPromotionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateLoyaltyPromotionRequest` | `Models/CreateLoyaltyPromotionRequest.cs` |
| `CreateLoyaltyPromotionResponse` | `Models/CreateLoyaltyPromotionResponse.cs` |

### CreateLoyaltyReward

- **Auth**: `options.Oauth2`
- **Signature**: `CreateLoyaltyReward(CreateLoyaltyRewardRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateLoyaltyRewardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateLoyaltyRewardRequest` | `Models/CreateLoyaltyRewardRequest.cs` |
| `CreateLoyaltyRewardResponse` | `Models/CreateLoyaltyRewardResponse.cs` |

### DeleteLoyaltyReward

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteLoyaltyReward(string rewardId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteLoyaltyRewardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteLoyaltyRewardResponse` | `Models/DeleteLoyaltyRewardResponse.cs` |

### ListLoyaltyPrograms

- **Auth**: `options.Oauth2`
- **Signature**: `ListLoyaltyPrograms(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ListLoyaltyProgramsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListLoyaltyProgramsResponse` | `Models/ListLoyaltyProgramsResponse.cs` |

### ListLoyaltyPromotions

- **Auth**: `options.Oauth2`
- **Signature**: `ListLoyaltyPromotions(string programId, LoyaltyPromotionStatus? status, string? cursor, int? limit, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `status` — nullable, no default → **must pass explicitly**
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `status` ← `status`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `ListLoyaltyPromotionsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LoyaltyPromotionStatus` | `Models/Enums/LoyaltyPromotionStatus.cs` |
| `ListLoyaltyPromotionsResponse` | `Models/ListLoyaltyPromotionsResponse.cs` |

### RedeemLoyaltyReward

- **Auth**: `options.Oauth2`
- **Signature**: `RedeemLoyaltyReward(string rewardId, RedeemLoyaltyRewardRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RedeemLoyaltyRewardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RedeemLoyaltyRewardRequest` | `Models/RedeemLoyaltyRewardRequest.cs` |
| `RedeemLoyaltyRewardResponse` | `Models/RedeemLoyaltyRewardResponse.cs` |

### RetrieveLoyaltyAccount

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLoyaltyAccount(string accountId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveLoyaltyAccountResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLoyaltyAccountResponse` | `Models/RetrieveLoyaltyAccountResponse.cs` |

### RetrieveLoyaltyProgram

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLoyaltyProgram(string programId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveLoyaltyProgramResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLoyaltyProgramResponse` | `Models/RetrieveLoyaltyProgramResponse.cs` |

### RetrieveLoyaltyPromotion

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLoyaltyPromotion(string promotionId, string programId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveLoyaltyPromotionResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLoyaltyPromotionResponse` | `Models/RetrieveLoyaltyPromotionResponse.cs` |

### RetrieveLoyaltyReward

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveLoyaltyReward(string rewardId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveLoyaltyRewardResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveLoyaltyRewardResponse` | `Models/RetrieveLoyaltyRewardResponse.cs` |

### SearchLoyaltyAccounts

- **Auth**: `options.Oauth2`
- **Signature**: `SearchLoyaltyAccounts(SearchLoyaltyAccountsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchLoyaltyAccountsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchLoyaltyAccountsRequest` | `Models/SearchLoyaltyAccountsRequest.cs` |
| `SearchLoyaltyAccountsResponse` | `Models/SearchLoyaltyAccountsResponse.cs` |

### SearchLoyaltyEvents

- **Auth**: `options.Oauth2`
- **Signature**: `SearchLoyaltyEvents(SearchLoyaltyEventsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchLoyaltyEventsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchLoyaltyEventsRequest` | `Models/SearchLoyaltyEventsRequest.cs` |
| `SearchLoyaltyEventsResponse` | `Models/SearchLoyaltyEventsResponse.cs` |

### SearchLoyaltyRewards

- **Auth**: `options.Oauth2`
- **Signature**: `SearchLoyaltyRewards(SearchLoyaltyRewardsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SearchLoyaltyRewardsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchLoyaltyRewardsRequest` | `Models/SearchLoyaltyRewardsRequest.cs` |
| `SearchLoyaltyRewardsResponse` | `Models/SearchLoyaltyRewardsResponse.cs` |

