<!-- Generated file — do not edit; regenerated with the SDK. -->

# Devices — operations

Accessor: `client.Devices` · Source: `Api/Devices.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateDeviceCode

- **Auth**: `options.Oauth2`
- **Signature**: `CreateDeviceCode(CreateDeviceCodeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateDeviceCodeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateDeviceCodeRequest` | `Models/CreateDeviceCodeRequest.cs` |
| `CreateDeviceCodeResponse` | `Models/CreateDeviceCodeResponse.cs` |

### GetDevice

- **Auth**: `options.Oauth2`
- **Signature**: `GetDevice(string deviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetDeviceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetDeviceResponse` | `Models/GetDeviceResponse.cs` |

### GetDeviceCode

- **Auth**: `options.Oauth2`
- **Signature**: `GetDeviceCode(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetDeviceCodeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetDeviceCodeResponse` | `Models/GetDeviceCodeResponse.cs` |

### ListDeviceCodes

- **Auth**: `options.Oauth2`
- **Signature**: `ListDeviceCodes(string? cursor, string? locationId, ProductType? productType, DeviceCodeStatus? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`cursor` … `status`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `location_id` ← `locationId`, `product_type` ← `productType`, `status` ← `status`
- **Returns**: `ListDeviceCodesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProductType` | `Models/Enums/ProductType.cs` |
| `DeviceCodeStatus` | `Models/Enums/DeviceCodeStatus.cs` |
| `ListDeviceCodesResponse` | `Models/ListDeviceCodesResponse.cs` |

### ListDevices

- **Auth**: `options.Oauth2`
- **Signature**: `ListDevices(string? cursor, SortOrder? sortOrder, int? limit, string? locationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`cursor` … `locationId`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `sort_order` ← `sortOrder`, `limit` ← `limit`, `location_id` ← `locationId`
- **Returns**: `ListDevicesResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SortOrder` | `Models/Enums/SortOrder.cs` |
| `ListDevicesResponse` | `Models/ListDevicesResponse.cs` |

