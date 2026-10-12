<!-- Generated file — do not edit; regenerated with the SDK. -->

# Devices — operations

Accessor: `client.Devices` · Source: `src/Square/Api/Devices.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateDeviceCode

- **Auth**: `options.Oauth2`
- **Signature**: `CreateDeviceCode(CreateDeviceCodeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreateDeviceCodeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateDeviceCodeOperationRequest` | `src/Square/Requests/Devices/CreateDeviceCodeOperationRequest.cs` |
| `CreateDeviceCodeRequest` | `src/Square/Models/CreateDeviceCodeRequest.cs` |
| `CreateDeviceCodeResponse` | `src/Square/Models/CreateDeviceCodeResponse.cs` |

### GetDevice

- **Auth**: `options.Oauth2`
- **Signature**: `GetDevice(GetDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DeviceId`
- **Returns**: `GetDeviceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetDeviceRequest` | `src/Square/Requests/Devices/GetDeviceRequest.cs` |
| `GetDeviceResponse` | `src/Square/Models/GetDeviceResponse.cs` |

### GetDeviceCode

- **Auth**: `options.Oauth2`
- **Signature**: `GetDeviceCode(GetDeviceCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GetDeviceCodeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetDeviceCodeRequest` | `src/Square/Requests/Devices/GetDeviceCodeRequest.cs` |
| `GetDeviceCodeResponse` | `src/Square/Models/GetDeviceCodeResponse.cs` |

### ListDeviceCodes

- **Auth**: `options.Oauth2`
- **Signature**: `ListDeviceCodes(ListDeviceCodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `location_id` ← `LocationId`, `product_type` ← `ProductType`, `status` ← `Status`
- **Returns**: `ListDeviceCodesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListDeviceCodesRequest` | `src/Square/Requests/Devices/ListDeviceCodesRequest.cs` |
| `ProductType` | `src/Square/Models/Enums/ProductType.cs` |
| `DeviceCodeStatus` | `src/Square/Models/Enums/DeviceCodeStatus.cs` |
| `ListDeviceCodesResponse` | `src/Square/Models/ListDeviceCodesResponse.cs` |

### ListDevices

- **Auth**: `options.Oauth2`
- **Signature**: `ListDevices(ListDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cursor` ← `Cursor`, `sort_order` ← `SortOrder`, `limit` ← `Limit`, `location_id` ← `LocationId`
- **Returns**: `ListDevicesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListDevicesRequest` | `src/Square/Requests/Devices/ListDevicesRequest.cs` |
| `SortOrder` | `src/Square/Models/Enums/SortOrder.cs` |
| `ListDevicesResponse` | `src/Square/Models/ListDevicesResponse.cs` |

