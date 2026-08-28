<!-- Generated file — do not edit; regenerated with the SDK. -->

# Employees — operations

Accessor: `client.Employees` · Source: `Api/Employees.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListEmployees

- **Signature**: `ListEmployees(string? locationId, EmployeeStatus? status, int? limit, string? cursor, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`locationId` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `location_id` ← `locationId`, `status` ← `status`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `ListEmployeesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EmployeeStatus` | `Models/Enums/EmployeeStatus.cs` |
| `ListEmployeesResponse` | `Models/ListEmployeesResponse.cs` |

### RetrieveEmployee

- **Signature**: `RetrieveEmployee(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RetrieveEmployeeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveEmployeeResponse` | `Models/RetrieveEmployeeResponse.cs` |

