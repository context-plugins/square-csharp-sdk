<!-- Generated file — do not edit; regenerated with the SDK. -->

# Team — operations

Accessor: `client.Team` · Source: `src/Square/Api/Team.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkCreateTeamMembers

- **Auth**: `options.Oauth2`
- **Signature**: `BulkCreateTeamMembers(BulkCreateTeamMembersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkCreateTeamMembersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkCreateTeamMembersOperationRequest` | `src/Square/Requests/Team/BulkCreateTeamMembersOperationRequest.cs` |
| `BulkCreateTeamMembersRequest` | `src/Square/Models/BulkCreateTeamMembersRequest.cs` |
| `BulkCreateTeamMembersResponse` | `src/Square/Models/BulkCreateTeamMembersResponse.cs` |

### BulkUpdateTeamMembers

- **Auth**: `options.Oauth2`
- **Signature**: `BulkUpdateTeamMembers(BulkUpdateTeamMembersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BulkUpdateTeamMembersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkUpdateTeamMembersOperationRequest` | `src/Square/Requests/Team/BulkUpdateTeamMembersOperationRequest.cs` |
| `BulkUpdateTeamMembersRequest` | `src/Square/Models/BulkUpdateTeamMembersRequest.cs` |
| `BulkUpdateTeamMembersResponse` | `src/Square/Models/BulkUpdateTeamMembersResponse.cs` |

### CreateJob

- **Auth**: `options.Oauth2`
- **Signature**: `CreateJob(CreateJobOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateJobResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateJobOperationRequest` | `src/Square/Requests/Team/CreateJobOperationRequest.cs` |
| `CreateJobRequest` | `src/Square/Models/CreateJobRequest.cs` |
| `CreateJobResponse` | `src/Square/Models/CreateJobResponse.cs` |

### CreateTeamMember

- **Auth**: `options.Oauth2`
- **Signature**: `CreateTeamMember(CreateTeamMemberOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateTeamMemberResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTeamMemberOperationRequest` | `src/Square/Requests/Team/CreateTeamMemberOperationRequest.cs` |
| `CreateTeamMemberRequest` | `src/Square/Models/CreateTeamMemberRequest.cs` |
| `CreateTeamMemberResponse` | `src/Square/Models/CreateTeamMemberResponse.cs` |

### ListJobs

- **Auth**: `options.Oauth2`
- **Signature**: `ListJobs(ListJobsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`
- **Returns**: `ListJobsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListJobsRequest` | `src/Square/Requests/Team/ListJobsRequest.cs` |
| `ListJobsResponse` | `src/Square/Models/ListJobsResponse.cs` |

### RetrieveJob

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveJob(RetrieveJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `JobId`
- **Returns**: `RetrieveJobResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveJobRequest` | `src/Square/Requests/Team/RetrieveJobRequest.cs` |
| `RetrieveJobResponse` | `src/Square/Models/RetrieveJobResponse.cs` |

### RetrieveTeamMember

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveTeamMember(RetrieveTeamMemberRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamMemberId`
- **Returns**: `RetrieveTeamMemberResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveTeamMemberRequest` | `src/Square/Requests/Team/RetrieveTeamMemberRequest.cs` |
| `RetrieveTeamMemberResponse` | `src/Square/Models/RetrieveTeamMemberResponse.cs` |

### RetrieveWageSetting

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveWageSetting(RetrieveWageSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamMemberId`
- **Returns**: `RetrieveWageSettingResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveWageSettingRequest` | `src/Square/Requests/Team/RetrieveWageSettingRequest.cs` |
| `RetrieveWageSettingResponse` | `src/Square/Models/RetrieveWageSettingResponse.cs` |

### SearchTeamMembers

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTeamMembers(SearchTeamMembersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SearchTeamMembersResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTeamMembersOperationRequest` | `src/Square/Requests/Team/SearchTeamMembersOperationRequest.cs` |
| `SearchTeamMembersRequest` | `src/Square/Models/SearchTeamMembersRequest.cs` |
| `SearchTeamMembersResponse` | `src/Square/Models/SearchTeamMembersResponse.cs` |

### UpdateJob

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateJob(UpdateJobOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `JobId`, `Body`
- **Returns**: `UpdateJobResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateJobOperationRequest` | `src/Square/Requests/Team/UpdateJobOperationRequest.cs` |
| `UpdateJobRequest` | `src/Square/Models/UpdateJobRequest.cs` |
| `UpdateJobResponse` | `src/Square/Models/UpdateJobResponse.cs` |

### UpdateTeamMember

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateTeamMember(UpdateTeamMemberOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamMemberId`, `Body`
- **Returns**: `UpdateTeamMemberResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTeamMemberOperationRequest` | `src/Square/Requests/Team/UpdateTeamMemberOperationRequest.cs` |
| `UpdateTeamMemberRequest` | `src/Square/Models/UpdateTeamMemberRequest.cs` |
| `UpdateTeamMemberResponse` | `src/Square/Models/UpdateTeamMemberResponse.cs` |

### UpdateWageSetting

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateWageSetting(UpdateWageSettingOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamMemberId`, `Body`
- **Returns**: `UpdateWageSettingResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWageSettingOperationRequest` | `src/Square/Requests/Team/UpdateWageSettingOperationRequest.cs` |
| `UpdateWageSettingRequest` | `src/Square/Models/UpdateWageSettingRequest.cs` |
| `UpdateWageSettingResponse` | `src/Square/Models/UpdateWageSettingResponse.cs` |

