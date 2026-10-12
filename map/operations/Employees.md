<!-- Generated file — do not edit; regenerated with the SDK. -->

# Employees — operations

Accessor: `client.Employees` · Source: `src/Square/Api/Employees.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListEmployees

- **Auth**: `options.Oauth2`
- **Signature**: `ListEmployees(ListEmployeesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `location_id` ← `LocationId`, `status` ← `Status`, `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `ListEmployeesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListEmployeesRequest` | `src/Square/Requests/Employees/ListEmployeesRequest.cs` |
| `EmployeeStatus` | `src/Square/Models/Enums/EmployeeStatus.cs` |
| `ListEmployeesResponse` | `src/Square/Models/ListEmployeesResponse.cs` |

### RetrieveEmployee

- **Auth**: `options.Oauth2`
- **Signature**: `RetrieveEmployee(RetrieveEmployeeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `RetrieveEmployeeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveEmployeeRequest` | `src/Square/Requests/Employees/RetrieveEmployeeRequest.cs` |
| `RetrieveEmployeeResponse` | `src/Square/Models/RetrieveEmployeeResponse.cs` |

