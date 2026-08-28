<!-- Generated file — do not edit; regenerated with the SDK. -->

# Disputes — operations

Accessor: `client.Disputes` · Source: `Api/Disputes.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AcceptDispute

- **Signature**: `AcceptDispute(string disputeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AcceptDisputeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AcceptDisputeResponse` | `Models/AcceptDisputeResponse.cs` |

### CreateDisputeEvidenceFile

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

- **Signature**: `CreateDisputeEvidenceText(string disputeId, CreateDisputeEvidenceTextRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateDisputeEvidenceTextResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateDisputeEvidenceTextRequest` | `Models/CreateDisputeEvidenceTextRequest.cs` |
| `CreateDisputeEvidenceTextResponse` | `Models/CreateDisputeEvidenceTextResponse.cs` |

### DeleteDisputeEvidence

- **Signature**: `DeleteDisputeEvidence(string disputeId, string evidenceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeleteDisputeEvidenceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteDisputeEvidenceResponse` | `Models/DeleteDisputeEvidenceResponse.cs` |

### ListDisputeEvidence

- **Signature**: `ListDisputeEvidence(string disputeId, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cursor` ← `cursor`
- **Returns**: `ListDisputeEvidenceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListDisputeEvidenceResponse` | `Models/ListDisputeEvidenceResponse.cs` |

### ListDisputes

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

- **Signature**: `RetrieveDispute(string disputeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveDisputeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveDisputeResponse` | `Models/RetrieveDisputeResponse.cs` |

### RetrieveDisputeEvidence

- **Signature**: `RetrieveDisputeEvidence(string disputeId, string evidenceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveDisputeEvidenceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveDisputeEvidenceResponse` | `Models/RetrieveDisputeEvidenceResponse.cs` |

### SubmitEvidence

- **Signature**: `SubmitEvidence(string disputeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SubmitEvidenceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SubmitEvidenceResponse` | `Models/SubmitEvidenceResponse.cs` |

