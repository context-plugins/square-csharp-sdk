<!-- Generated file — do not edit; regenerated with the SDK. -->

# Disputes — operations

Accessor: `client.Disputes` · Source: `Api/Disputes.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AcceptDispute

- **Auth**: `options.Oauth2`
- **Signature**: `AcceptDispute(string disputeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AcceptDisputeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AcceptDisputeResponse` | `Models/AcceptDisputeResponse.cs` |

### CreateDisputeEvidenceFile

- **Auth**: `options.Oauth2`
- **Signature**: `CreateDisputeEvidenceFile(string disputeId, CreateDisputeEvidenceFileRequest? request, BinaryContent? imageFile, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `request` — nullable, no default → **must pass explicitly**
  - `imageFile` — nullable, no default → **must pass explicitly**
- **Returns**: `CreateDisputeEvidenceFileResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateDisputeEvidenceFileRequest` | `Models/CreateDisputeEvidenceFileRequest.cs` |
| `CreateDisputeEvidenceFileResponse` | `Models/CreateDisputeEvidenceFileResponse.cs` |

### CreateDisputeEvidenceText

- **Auth**: `options.Oauth2`
- **Signature**: `CreateDisputeEvidenceText(string disputeId, CreateDisputeEvidenceTextRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateDisputeEvidenceTextResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateDisputeEvidenceTextRequest` | `Models/CreateDisputeEvidenceTextRequest.cs` |
| `CreateDisputeEvidenceTextResponse` | `Models/CreateDisputeEvidenceTextResponse.cs` |

### DeleteDisputeEvidence

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteDisputeEvidence(string disputeId, string evidenceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteDisputeEvidenceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteDisputeEvidenceResponse` | `Models/DeleteDisputeEvidenceResponse.cs` |

### ListDisputeEvidence

- **Auth**: `options.Oauth2`
- **Signature**: `ListDisputeEvidence(string disputeId, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cursor` ← `cursor`
- **Returns**: `ListDisputeEvidenceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListDisputeEvidenceResponse` | `Models/ListDisputeEvidenceResponse.cs` |

### ListDisputes

- **Auth**: `options.Oauth2`
- **Signature**: `ListDisputes(string? cursor, DisputeState? states, string? locationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `states` — nullable, no default → **must pass explicitly**
  - `locationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `states` ← `states`, `location_id` ← `locationId`
- **Returns**: `ListDisputesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DisputeState` | `Models/Enums/DisputeState.cs` |
| `ListDisputesResponse` | `Models/ListDisputesResponse.cs` |

### RetrieveDispute

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveDispute(string disputeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveDisputeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveDisputeResponse` | `Models/RetrieveDisputeResponse.cs` |

### RetrieveDisputeEvidence

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveDisputeEvidence(string disputeId, string evidenceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveDisputeEvidenceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveDisputeEvidenceResponse` | `Models/RetrieveDisputeEvidenceResponse.cs` |

### SubmitEvidence

- **Auth**: `options.Oauth2`
- **Signature**: `SubmitEvidence(string disputeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SubmitEvidenceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SubmitEvidenceResponse` | `Models/SubmitEvidenceResponse.cs` |

