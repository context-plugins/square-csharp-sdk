<!-- Generated file — do not edit; regenerated with the SDK. -->

# Disputes — operations

Accessor: `client.Disputes` · Source: `src/Square/Api/Disputes.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AcceptDispute

- **Auth**: `options.Oauth2`
- **Signature**: `AcceptDispute(AcceptDisputeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`
- **Returns**: `AcceptDisputeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AcceptDisputeRequest` | `src/Square/Requests/Disputes/AcceptDisputeRequest.cs` |
| `AcceptDisputeResponse` | `src/Square/Models/AcceptDisputeResponse.cs` |

### CreateDisputeEvidenceFile

- **Auth**: `options.Oauth2`
- **Signature**: `CreateDisputeEvidenceFile(CreateDisputeEvidenceFileOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`
- **Returns**: `CreateDisputeEvidenceFileResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateDisputeEvidenceFileOperationRequest` | `src/Square/Requests/Disputes/CreateDisputeEvidenceFileOperationRequest.cs` |
| `CreateDisputeEvidenceFileRequest` | `src/Square/Models/CreateDisputeEvidenceFileRequest.cs` |
| `CreateDisputeEvidenceFileResponse` | `src/Square/Models/CreateDisputeEvidenceFileResponse.cs` |

### CreateDisputeEvidenceText

- **Auth**: `options.Oauth2`
- **Signature**: `CreateDisputeEvidenceText(CreateDisputeEvidenceTextOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`, `Body`
- **Returns**: `CreateDisputeEvidenceTextResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateDisputeEvidenceTextOperationRequest` | `src/Square/Requests/Disputes/CreateDisputeEvidenceTextOperationRequest.cs` |
| `CreateDisputeEvidenceTextRequest` | `src/Square/Models/CreateDisputeEvidenceTextRequest.cs` |
| `CreateDisputeEvidenceTextResponse` | `src/Square/Models/CreateDisputeEvidenceTextResponse.cs` |

### DeleteDisputeEvidence

- **Auth**: `options.Oauth2`
- **Signature**: `DeleteDisputeEvidence(DeleteDisputeEvidenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`, `EvidenceId`
- **Returns**: `DeleteDisputeEvidenceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteDisputeEvidenceRequest` | `src/Square/Requests/Disputes/DeleteDisputeEvidenceRequest.cs` |
| `DeleteDisputeEvidenceResponse` | `src/Square/Models/DeleteDisputeEvidenceResponse.cs` |

### ListDisputeEvidence

- **Auth**: `options.Oauth2`
- **Signature**: `ListDisputeEvidence(ListDisputeEvidenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`
- **Returns**: `ListDisputeEvidenceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListDisputeEvidenceRequest` | `src/Square/Requests/Disputes/ListDisputeEvidenceRequest.cs` |
| `ListDisputeEvidenceResponse` | `src/Square/Models/ListDisputeEvidenceResponse.cs` |

### ListDisputes

- **Auth**: `options.Oauth2`
- **Signature**: `ListDisputes(ListDisputesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `states` ← `States`, `location_id` ← `LocationId`
- **Returns**: `ListDisputesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListDisputesRequest` | `src/Square/Requests/Disputes/ListDisputesRequest.cs` |
| `DisputeState` | `src/Square/Models/Enums/DisputeState.cs` |
| `ListDisputesResponse` | `src/Square/Models/ListDisputesResponse.cs` |

### RetrieveDispute

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveDispute(RetrieveDisputeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`
- **Returns**: `RetrieveDisputeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveDisputeRequest` | `src/Square/Requests/Disputes/RetrieveDisputeRequest.cs` |
| `RetrieveDisputeResponse` | `src/Square/Models/RetrieveDisputeResponse.cs` |

### RetrieveDisputeEvidence

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveDisputeEvidence(RetrieveDisputeEvidenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`, `EvidenceId`
- **Returns**: `RetrieveDisputeEvidenceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveDisputeEvidenceRequest` | `src/Square/Requests/Disputes/RetrieveDisputeEvidenceRequest.cs` |
| `RetrieveDisputeEvidenceResponse` | `src/Square/Models/RetrieveDisputeEvidenceResponse.cs` |

### SubmitEvidence

- **Auth**: `options.Oauth2`
- **Signature**: `SubmitEvidence(SubmitEvidenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`
- **Returns**: `SubmitEvidenceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SubmitEvidenceRequest` | `src/Square/Requests/Disputes/SubmitEvidenceRequest.cs` |
| `SubmitEvidenceResponse` | `src/Square/Models/SubmitEvidenceResponse.cs` |

