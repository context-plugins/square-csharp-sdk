# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [SquareClient](src/Square/SquareClient.cs)

## ApplePay

> Source: [ApplePay](src/Square/Api/ApplePay.cs)

<details>
<summary><code>Task&lt;RegisterDomainResponse&gt; RegisterDomain(RegisterDomainOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Activates a domain for use with Apple Pay on the Web and Square. A validation
is performed on this domain by Apple to ensure that it is properly set up as
an Apple Pay enabled domain.

This endpoint provides an easy way for platform developers to bulk activate
Apple Pay on the Web with Square for merchants using their platform.

Note: You will need to host a valid domain verification file on your domain to support Apple Pay.  The
current version of this file is always available at https://app.squareup.com/digital-wallets/apple-pay/apple-developer-merchantid-domain-association,
and should be hosted at `.well_known/apple-developer-merchantid-domain-association` on your
domain.  This file is subject to change; we strongly recommend checking for updates regularly and avoiding
long-lived caches that might not keep in sync with the correct file version.

To learn more about the Web Payments SDK and how to add Apple Pay, see [Take an Apple Pay Payment](https://developer.squareup.com/docs/web-payments/apple-pay).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApplePay.RegisterDomain(new RegisterDomainOperationRequest
    {
        Body = new RegisterDomainRequest { DomainName = "some example string" },
    });
    // TODO: Handle 'response' of type RegisterDomainResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RegisterDomainOperationRequest](src/Square/Requests/ApplePay/RegisterDomainOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegisterDomainResponse](src/Square/Models/RegisterDomainResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BankAccounts

> Source: [BankAccounts](src/Square/Api/BankAccounts.cs)

<details>
<summary><code>Task&lt;CreateBankAccountResponse&gt; CreateBankAccount(CreateBankAccountOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Store a bank account on file for a square account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankAccounts.CreateBankAccount(new CreateBankAccountOperationRequest
    {
        Body = new CreateBankAccountRequest
        {
            IdempotencyKey = "some example string",
            SourceId = "some example string",
        },
    });
    // TODO: Handle 'response' of type CreateBankAccountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateBankAccountOperationRequest](src/Square/Requests/BankAccounts/CreateBankAccountOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateBankAccountResponse](src/Square/Models/CreateBankAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisableBankAccountResponse&gt; DisableBankAccount(DisableBankAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disable a bank account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankAccounts.DisableBankAccount(new DisableBankAccountRequest
    {
        BankAccountId = "some example string",
    });
    // TODO: Handle 'response' of type DisableBankAccountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DisableBankAccountRequest](src/Square/Requests/BankAccounts/DisableBankAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisableBankAccountResponse](src/Square/Models/DisableBankAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetBankAccountResponse&gt; GetBankAccount(GetBankAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve details of a [BankAccount](entity:BankAccount) bank account linked to a Square account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankAccounts.GetBankAccount(new GetBankAccountRequest
    {
        BankAccountId = "some example string",
    });
    // TODO: Handle 'response' of type GetBankAccountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBankAccountRequest](src/Square/Requests/BankAccounts/GetBankAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetBankAccountResponse](src/Square/Models/GetBankAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetBankAccountByV1IdResponse&gt; GetBankAccountByV1Id(GetBankAccountByV1IdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details of a [BankAccount](entity:BankAccount) identified by V1 bank account ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankAccounts.GetBankAccountByV1Id(new GetBankAccountByV1IdRequest
    {
        V1BankAccountId = "some example string",
    });
    // TODO: Handle 'response' of type GetBankAccountByV1IdResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBankAccountByV1IdRequest](src/Square/Requests/BankAccounts/GetBankAccountByV1IdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetBankAccountByV1IdResponse](src/Square/Models/GetBankAccountByV1IdResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListBankAccountsResponse&gt; ListBankAccounts(ListBankAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of [BankAccount](entity:BankAccount) objects linked to a Square account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankAccounts.ListBankAccounts(new ListBankAccountsRequest());
    // TODO: Handle 'response' of type ListBankAccountsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListBankAccountsRequest](src/Square/Requests/BankAccounts/ListBankAccountsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListBankAccountsResponse](src/Square/Models/ListBankAccountsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BookingCustomAttributes

> Source: [BookingCustomAttributes](src/Square/Api/BookingCustomAttributes.cs)

<details>
<summary><code>Task&lt;BulkDeleteBookingCustomAttributesResponse&gt; BulkDeleteBookingCustomAttributes(BulkDeleteBookingCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Bulk deletes bookings custom attributes.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.BulkDeleteBookingCustomAttributes(
        new BulkDeleteBookingCustomAttributesOperationRequest
        {
            Body = new BulkDeleteBookingCustomAttributesRequest
            {
                Values = new Dictionary<string, BookingCustomAttributeDeleteRequest>
                {
                    ["key"] = new BookingCustomAttributeDeleteRequest
                    {
                        BookingId = "some example string",
                        Key = "some example string",
                    },
                },
            },
        });
    // TODO: Handle 'response' of type BulkDeleteBookingCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkDeleteBookingCustomAttributesOperationRequest](src/Square/Requests/BookingCustomAttributes/BulkDeleteBookingCustomAttributesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkDeleteBookingCustomAttributesResponse](src/Square/Models/BulkDeleteBookingCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkUpsertBookingCustomAttributesResponse&gt; BulkUpsertBookingCustomAttributes(BulkUpsertBookingCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Bulk upserts bookings custom attributes.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.BulkUpsertBookingCustomAttributes(
        new BulkUpsertBookingCustomAttributesOperationRequest
        {
            Body = new BulkUpsertBookingCustomAttributesRequest
            {
                Values = new Dictionary<string, BookingCustomAttributeUpsertRequest>
                {
                    ["key"] = new BookingCustomAttributeUpsertRequest
                    {
                        BookingId = "some example string",
                        CustomAttribute = new CustomAttribute(),
                    },
                },
            },
        });
    // TODO: Handle 'response' of type BulkUpsertBookingCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkUpsertBookingCustomAttributesOperationRequest](src/Square/Requests/BookingCustomAttributes/BulkUpsertBookingCustomAttributesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkUpsertBookingCustomAttributesResponse](src/Square/Models/BulkUpsertBookingCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateBookingCustomAttributeDefinitionResponse&gt; CreateBookingCustomAttributeDefinition(CreateBookingCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a bookings custom attribute definition.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.CreateBookingCustomAttributeDefinition(
        new CreateBookingCustomAttributeDefinitionOperationRequest
        {
            Body = new CreateBookingCustomAttributeDefinitionRequest
            {
                CustomAttributeDefinition = new CustomAttributeDefinition(),
            },
        });
    // TODO: Handle 'response' of type CreateBookingCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateBookingCustomAttributeDefinitionOperationRequest](src/Square/Requests/BookingCustomAttributes/CreateBookingCustomAttributeDefinitionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateBookingCustomAttributeDefinitionResponse](src/Square/Models/CreateBookingCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteBookingCustomAttributeResponse&gt; DeleteBookingCustomAttribute(DeleteBookingCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a bookings custom attribute.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.DeleteBookingCustomAttribute(
        new DeleteBookingCustomAttributeRequest { BookingId = "some example string", Key = "some example string" });
    // TODO: Handle 'response' of type DeleteBookingCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBookingCustomAttributeRequest](src/Square/Requests/BookingCustomAttributes/DeleteBookingCustomAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteBookingCustomAttributeResponse](src/Square/Models/DeleteBookingCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteBookingCustomAttributeDefinitionResponse&gt; DeleteBookingCustomAttributeDefinition(DeleteBookingCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a bookings custom attribute definition.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.DeleteBookingCustomAttributeDefinition(
        new DeleteBookingCustomAttributeDefinitionRequest { Key = "some example string" });
    // TODO: Handle 'response' of type DeleteBookingCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBookingCustomAttributeDefinitionRequest](src/Square/Requests/BookingCustomAttributes/DeleteBookingCustomAttributeDefinitionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteBookingCustomAttributeDefinitionResponse](src/Square/Models/DeleteBookingCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListBookingCustomAttributeDefinitionsResponse&gt; ListBookingCustomAttributeDefinitions(ListBookingCustomAttributeDefinitionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all bookings custom attribute definitions.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.ListBookingCustomAttributeDefinitions(
        new ListBookingCustomAttributeDefinitionsRequest());
    // TODO: Handle 'response' of type ListBookingCustomAttributeDefinitionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListBookingCustomAttributeDefinitionsRequest](src/Square/Requests/BookingCustomAttributes/ListBookingCustomAttributeDefinitionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListBookingCustomAttributeDefinitionsResponse](src/Square/Models/ListBookingCustomAttributeDefinitionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListBookingCustomAttributesResponse&gt; ListBookingCustomAttributes(ListBookingCustomAttributesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists a booking's custom attributes.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.ListBookingCustomAttributes(
        new ListBookingCustomAttributesRequest { BookingId = "some example string" });
    // TODO: Handle 'response' of type ListBookingCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListBookingCustomAttributesRequest](src/Square/Requests/BookingCustomAttributes/ListBookingCustomAttributesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListBookingCustomAttributesResponse](src/Square/Models/ListBookingCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveBookingCustomAttributeResponse&gt; RetrieveBookingCustomAttribute(RetrieveBookingCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a bookings custom attribute.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.RetrieveBookingCustomAttribute(
        new RetrieveBookingCustomAttributeRequest { BookingId = "some example string", Key = "some example string" });
    // TODO: Handle 'response' of type RetrieveBookingCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveBookingCustomAttributeRequest](src/Square/Requests/BookingCustomAttributes/RetrieveBookingCustomAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveBookingCustomAttributeResponse](src/Square/Models/RetrieveBookingCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveBookingCustomAttributeDefinitionResponse&gt; RetrieveBookingCustomAttributeDefinition(RetrieveBookingCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a bookings custom attribute definition.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.RetrieveBookingCustomAttributeDefinition(
        new RetrieveBookingCustomAttributeDefinitionRequest { Key = "some example string" });
    // TODO: Handle 'response' of type RetrieveBookingCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveBookingCustomAttributeDefinitionRequest](src/Square/Requests/BookingCustomAttributes/RetrieveBookingCustomAttributeDefinitionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveBookingCustomAttributeDefinitionResponse](src/Square/Models/RetrieveBookingCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateBookingCustomAttributeDefinitionResponse&gt; UpdateBookingCustomAttributeDefinition(UpdateBookingCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a bookings custom attribute definition.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.UpdateBookingCustomAttributeDefinition(
        new UpdateBookingCustomAttributeDefinitionOperationRequest
        {
            Key = "some example string",
            Body = new UpdateBookingCustomAttributeDefinitionRequest
            {
                CustomAttributeDefinition = new CustomAttributeDefinition(),
            },
        });
    // TODO: Handle 'response' of type UpdateBookingCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateBookingCustomAttributeDefinitionOperationRequest](src/Square/Requests/BookingCustomAttributes/UpdateBookingCustomAttributeDefinitionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateBookingCustomAttributeDefinitionResponse](src/Square/Models/UpdateBookingCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpsertBookingCustomAttributeResponse&gt; UpsertBookingCustomAttribute(UpsertBookingCustomAttributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Upserts a bookings custom attribute.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BookingCustomAttributes.UpsertBookingCustomAttribute(
        new UpsertBookingCustomAttributeOperationRequest
        {
            BookingId = "some example string",
            Key = "some example string",
            Body = new UpsertBookingCustomAttributeRequest { CustomAttribute = new CustomAttribute() },
        });
    // TODO: Handle 'response' of type UpsertBookingCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpsertBookingCustomAttributeOperationRequest](src/Square/Requests/BookingCustomAttributes/UpsertBookingCustomAttributeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpsertBookingCustomAttributeResponse](src/Square/Models/UpsertBookingCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Bookings

> Source: [Bookings](src/Square/Api/Bookings.cs)

<details>
<summary><code>Task&lt;BulkRetrieveBookingsResponse&gt; BulkRetrieveBookings(BulkRetrieveBookingsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Bulk-Retrieves a list of bookings by booking IDs.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.BulkRetrieveBookings(new BulkRetrieveBookingsOperationRequest
    {
        Body = new BulkRetrieveBookingsRequest { BookingIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type BulkRetrieveBookingsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkRetrieveBookingsOperationRequest](src/Square/Requests/Bookings/BulkRetrieveBookingsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkRetrieveBookingsResponse](src/Square/Models/BulkRetrieveBookingsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkRetrieveTeamMemberBookingProfilesResponse&gt; BulkRetrieveTeamMemberBookingProfiles(BulkRetrieveTeamMemberBookingProfilesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves one or more team members' booking profiles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.BulkRetrieveTeamMemberBookingProfiles(
        new BulkRetrieveTeamMemberBookingProfilesOperationRequest
        {
            Body = new BulkRetrieveTeamMemberBookingProfilesRequest { TeamMemberIds = ["some example string"] },
        });
    // TODO: Handle 'response' of type BulkRetrieveTeamMemberBookingProfilesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkRetrieveTeamMemberBookingProfilesOperationRequest](src/Square/Requests/Bookings/BulkRetrieveTeamMemberBookingProfilesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkRetrieveTeamMemberBookingProfilesResponse](src/Square/Models/BulkRetrieveTeamMemberBookingProfilesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelBookingResponse&gt; CancelBooking(CancelBookingOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an existing booking.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.CancelBooking(new CancelBookingOperationRequest
    {
        BookingId = "some example string",
        Body = new CancelBookingRequest(),
    });
    // TODO: Handle 'response' of type CancelBookingResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelBookingOperationRequest](src/Square/Requests/Bookings/CancelBookingOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelBookingResponse](src/Square/Models/CancelBookingResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateBookingResponse&gt; CreateBooking(CreateBookingOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a booking.

The required input must include the following:
- `Booking.location_id`
- `Booking.start_at`
- `Booking.AppointmentSegment.team_member_id`
- `Booking.AppointmentSegment.service_variation_id`
- `Booking.AppointmentSegment.service_variation_version`

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.CreateBooking(new CreateBookingOperationRequest
    {
        Body = new CreateBookingRequest { Booking = new Booking() },
    });
    // TODO: Handle 'response' of type CreateBookingResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateBookingOperationRequest](src/Square/Requests/Bookings/CreateBookingOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateBookingResponse](src/Square/Models/CreateBookingResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListBookingsResponse&gt; ListBookings(ListBookingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a collection of bookings.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.ListBookings(new ListBookingsRequest());
    // TODO: Handle 'response' of type ListBookingsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListBookingsRequest](src/Square/Requests/Bookings/ListBookingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListBookingsResponse](src/Square/Models/ListBookingsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListLocationBookingProfilesResponse&gt; ListLocationBookingProfiles(ListLocationBookingProfilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists location booking profiles of a seller.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.ListLocationBookingProfiles(new ListLocationBookingProfilesRequest());
    // TODO: Handle 'response' of type ListLocationBookingProfilesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListLocationBookingProfilesRequest](src/Square/Requests/Bookings/ListLocationBookingProfilesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListLocationBookingProfilesResponse](src/Square/Models/ListLocationBookingProfilesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListTeamMemberBookingProfilesResponse&gt; ListTeamMemberBookingProfiles(ListTeamMemberBookingProfilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists booking profiles for team members.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.ListTeamMemberBookingProfiles(new ListTeamMemberBookingProfilesRequest());
    // TODO: Handle 'response' of type ListTeamMemberBookingProfilesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListTeamMemberBookingProfilesRequest](src/Square/Requests/Bookings/ListTeamMemberBookingProfilesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListTeamMemberBookingProfilesResponse](src/Square/Models/ListTeamMemberBookingProfilesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveBookingResponse&gt; RetrieveBooking(RetrieveBookingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a booking.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.RetrieveBooking(new RetrieveBookingRequest
    {
        BookingId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveBookingResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveBookingRequest](src/Square/Requests/Bookings/RetrieveBookingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveBookingResponse](src/Square/Models/RetrieveBookingResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveBusinessBookingProfileResponse&gt; RetrieveBusinessBookingProfile(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a seller's booking profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.RetrieveBusinessBookingProfile();
    // TODO: Handle 'response' of type RetrieveBusinessBookingProfileResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveBusinessBookingProfileResponse](src/Square/Models/RetrieveBusinessBookingProfileResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLocationBookingProfileResponse&gt; RetrieveLocationBookingProfile(RetrieveLocationBookingProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a seller's location booking profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.RetrieveLocationBookingProfile(new RetrieveLocationBookingProfileRequest
    {
        LocationId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveLocationBookingProfileResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveLocationBookingProfileRequest](src/Square/Requests/Bookings/RetrieveLocationBookingProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLocationBookingProfileResponse](src/Square/Models/RetrieveLocationBookingProfileResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveTeamMemberBookingProfileResponse&gt; RetrieveTeamMemberBookingProfile(RetrieveTeamMemberBookingProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a team member's booking profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.RetrieveTeamMemberBookingProfile(new RetrieveTeamMemberBookingProfileRequest
    {
        TeamMemberId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveTeamMemberBookingProfileResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveTeamMemberBookingProfileRequest](src/Square/Requests/Bookings/RetrieveTeamMemberBookingProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveTeamMemberBookingProfileResponse](src/Square/Models/RetrieveTeamMemberBookingProfileResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchAvailabilityResponse&gt; SearchAvailability(SearchAvailabilityOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for availabilities for booking.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_READ` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_READ` and `APPOINTMENTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.SearchAvailability(new SearchAvailabilityOperationRequest
    {
        Body = new SearchAvailabilityRequest
        {
            Query = new SearchAvailabilityQuery
            {
                Filter = new SearchAvailabilityFilter { StartAtRange = new TimeRange() },
            },
        },
    });
    // TODO: Handle 'response' of type SearchAvailabilityResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchAvailabilityOperationRequest](src/Square/Requests/Bookings/SearchAvailabilityOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchAvailabilityResponse](src/Square/Models/SearchAvailabilityResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateBookingResponse&gt; UpdateBooking(UpdateBookingOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a booking.

To call this endpoint with buyer-level permissions, set `APPOINTMENTS_WRITE` for the OAuth scope.
To call this endpoint with seller-level permissions, set `APPOINTMENTS_ALL_WRITE` and `APPOINTMENTS_WRITE` for the OAuth scope.

For calls to this endpoint with seller-level permissions to succeed, the seller must have subscribed to *Appointments Plus*
or *Appointments Premium*.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Bookings.UpdateBooking(new UpdateBookingOperationRequest
    {
        BookingId = "some example string",
        Body = new UpdateBookingRequest { Booking = new Booking() },
    });
    // TODO: Handle 'response' of type UpdateBookingResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateBookingOperationRequest](src/Square/Requests/Bookings/UpdateBookingOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateBookingResponse](src/Square/Models/UpdateBookingResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Cards

> Source: [Cards](src/Square/Api/Cards.cs)

<details>
<summary><code>Task&lt;CreateCardResponse&gt; CreateCard(CreateCardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a card on file to an existing merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Cards.CreateCard(new CreateCardOperationRequest
    {
        Body = new CreateCardRequest
        {
            IdempotencyKey = "some example string",
            SourceId = "some example string",
            Card = new Card(),
        },
    });
    // TODO: Handle 'response' of type CreateCardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCardOperationRequest](src/Square/Requests/Cards/CreateCardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCardResponse](src/Square/Models/CreateCardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DisableCardResponse&gt; DisableCard(DisableCardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disables the card, preventing any further updates or charges.
Disabling an already disabled card is allowed but has no effect.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Cards.DisableCard(new DisableCardRequest { CardId = "some example string" });
    // TODO: Handle 'response' of type DisableCardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DisableCardRequest](src/Square/Requests/Cards/DisableCardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisableCardResponse](src/Square/Models/DisableCardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCardsResponse&gt; ListCards(ListCardsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of cards owned by the account making the request.
A max of 25 cards will be returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Cards.ListCards(new ListCardsRequest());
    // TODO: Handle 'response' of type ListCardsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCardsRequest](src/Square/Requests/Cards/ListCardsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCardsResponse](src/Square/Models/ListCardsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCardResponse&gt; RetrieveCard(RetrieveCardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details for a specific Card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Cards.RetrieveCard(new RetrieveCardRequest { CardId = "some example string" });
    // TODO: Handle 'response' of type RetrieveCardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveCardRequest](src/Square/Requests/Cards/RetrieveCardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCardResponse](src/Square/Models/RetrieveCardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CashDrawers

> Source: [CashDrawers](src/Square/Api/CashDrawers.cs)

<details>
<summary><code>Task&lt;ListCashDrawerShiftEventsResponse&gt; ListCashDrawerShiftEvents(ListCashDrawerShiftEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides a paginated list of events for a single cash drawer shift.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashDrawers.ListCashDrawerShiftEvents(new ListCashDrawerShiftEventsRequest
    {
        ShiftId = "some example string",
        LocationId = "some example string",
    });
    // TODO: Handle 'response' of type ListCashDrawerShiftEventsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCashDrawerShiftEventsRequest](src/Square/Requests/CashDrawers/ListCashDrawerShiftEventsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCashDrawerShiftEventsResponse](src/Square/Models/ListCashDrawerShiftEventsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCashDrawerShiftsResponse&gt; ListCashDrawerShifts(ListCashDrawerShiftsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides the details for all of the cash drawer shifts for a location
in a date range.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashDrawers.ListCashDrawerShifts(new ListCashDrawerShiftsRequest
    {
        LocationId = "some example string",
    });
    // TODO: Handle 'response' of type ListCashDrawerShiftsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCashDrawerShiftsRequest](src/Square/Requests/CashDrawers/ListCashDrawerShiftsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCashDrawerShiftsResponse](src/Square/Models/ListCashDrawerShiftsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCashDrawerShiftResponse&gt; RetrieveCashDrawerShift(RetrieveCashDrawerShiftRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides the summary details for a single cash drawer shift. See
[ListCashDrawerShiftEvents](api-endpoint:CashDrawers-ListCashDrawerShiftEvents) for a list of cash drawer shift events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashDrawers.RetrieveCashDrawerShift(new RetrieveCashDrawerShiftRequest
    {
        ShiftId = "some example string",
        LocationId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveCashDrawerShiftResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveCashDrawerShiftRequest](src/Square/Requests/CashDrawers/RetrieveCashDrawerShiftRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCashDrawerShiftResponse](src/Square/Models/RetrieveCashDrawerShiftResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Catalog

> Source: [Catalog](src/Square/Api/Catalog.cs)

<details>
<summary><code>Task&lt;BatchDeleteCatalogObjectsResponse&gt; BatchDeleteCatalogObjects(BatchDeleteCatalogObjectsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a set of [CatalogItem](entity:CatalogItem)s based on the
provided list of target IDs and returns a set of successfully deleted IDs in
the response. Deletion is a cascading event such that all children of the
targeted object are also deleted. For example, deleting a CatalogItem will
also delete all of its [CatalogItemVariation](entity:CatalogItemVariation)
children.

`BatchDeleteCatalogObjects` succeeds even if only a portion of the targeted
IDs can be deleted. The response will only include IDs that were
actually deleted.

To ensure consistency, only one delete request is processed at a time per seller account.
While one (batch or non-batch) delete request is being processed, other (batched and non-batched)
delete requests are rejected with the `429` error code.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.BatchDeleteCatalogObjects(new BatchDeleteCatalogObjectsOperationRequest
    {
        Body = new BatchDeleteCatalogObjectsRequest { ObjectIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type BatchDeleteCatalogObjectsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BatchDeleteCatalogObjectsOperationRequest](src/Square/Requests/Catalog/BatchDeleteCatalogObjectsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchDeleteCatalogObjectsResponse](src/Square/Models/BatchDeleteCatalogObjectsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchRetrieveCatalogObjectsResponse&gt; BatchRetrieveCatalogObjects(BatchRetrieveCatalogObjectsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a set of objects based on the provided ID.
Each [CatalogItem](entity:CatalogItem) returned in the set includes all of its
child information including: all of its
[CatalogItemVariation](entity:CatalogItemVariation) objects, references to
its [CatalogModifierList](entity:CatalogModifierList) objects, and the ids of
any [CatalogTax](entity:CatalogTax) objects that apply to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.BatchRetrieveCatalogObjects(new BatchRetrieveCatalogObjectsOperationRequest
    {
        Body = new BatchRetrieveCatalogObjectsRequest { ObjectIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type BatchRetrieveCatalogObjectsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BatchRetrieveCatalogObjectsOperationRequest](src/Square/Requests/Catalog/BatchRetrieveCatalogObjectsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveCatalogObjectsResponse](src/Square/Models/BatchRetrieveCatalogObjectsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchUpsertCatalogObjectsResponse&gt; BatchUpsertCatalogObjects(BatchUpsertCatalogObjectsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates up to 10,000 target objects based on the provided
list of objects. The target objects are grouped into batches and each batch is
inserted/updated in an all-or-nothing manner. If an object within a batch is
malformed in some way, or violates a database constraint, the entire batch
containing that item will be disregarded. However, other batches in the same
request may still succeed. Each batch may contain up to 1,000 objects, and
batches will be processed in order as long as the total object count for the
request (items, variations, modifier lists, discounts, and taxes) is no more
than 10,000.

This endpoint uses full-replacement semantics. The client must send the complete object, and any
field absent from the request is interpreted as an intentional clear. This logic applies to
nested objects as well. For example, omitting inlined children like variations will delete them.

To ensure consistency, only one update request is processed at a time per seller account.
While one (batch or non-batch) update request is being processed, other (batched and non-batched)
update requests are rejected with the `429` error code. Prefer batching related changes into a
single call rather than issuing many small writes, since each write acquires the lock separately
and parallel writes to the same seller will contend with each other, producing `429` errors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.BatchUpsertCatalogObjects(new BatchUpsertCatalogObjectsOperationRequest
    {
        Body = new BatchUpsertCatalogObjectsRequest
        {
            IdempotencyKey = "some example string",
            Batches = [
                new CatalogObjectBatch
                {
                    Objects = [new CatalogObject { Type = CatalogObjectType.Item, Id = "some example string" }],
                },
            ],
        },
    });
    // TODO: Handle 'response' of type BatchUpsertCatalogObjectsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BatchUpsertCatalogObjectsOperationRequest](src/Square/Requests/Catalog/BatchUpsertCatalogObjectsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchUpsertCatalogObjectsResponse](src/Square/Models/BatchUpsertCatalogObjectsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CatalogInfoResponse&gt; CatalogInfo(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves information about the Square Catalog API, such as batch size
limits that can be used by the `BatchUpsertCatalogObjects` endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.CatalogInfo();
    // TODO: Handle 'response' of type CatalogInfoResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CatalogInfoResponse](src/Square/Models/CatalogInfoResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCatalogImageResponse&gt; CreateCatalogImage(CreateCatalogImageOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads an image file to be represented by a [CatalogImage](entity:CatalogImage) object that can be linked to an existing
[CatalogObject](entity:CatalogObject) instance. The resulting `CatalogImage` is unattached to any `CatalogObject` if the `object_id`
is not specified.

This `CreateCatalogImage` endpoint accepts HTTP multipart/form-data requests with a JSON part and an image file part in
JPEG, PJPEG, PNG, or GIF format. The maximum file size is 15MB.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.CreateCatalogImage(new CreateCatalogImageOperationRequest());
    // TODO: Handle 'response' of type CreateCatalogImageResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCatalogImageOperationRequest](src/Square/Requests/Catalog/CreateCatalogImageOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCatalogImageResponse](src/Square/Models/CreateCatalogImageResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteCatalogObjectResponse&gt; DeleteCatalogObject(DeleteCatalogObjectRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a single [CatalogObject](entity:CatalogObject) based on the
provided ID and returns the set of successfully deleted IDs in the response.
Deletion is a cascading event such that all children of the targeted object
are also deleted. For example, deleting a [CatalogItem](entity:CatalogItem)
will also delete all of its
[CatalogItemVariation](entity:CatalogItemVariation) children.

To ensure consistency, only one delete request is processed at a time per seller account.
While one (batch or non-batch) delete request is being processed, other (batched and non-batched)
delete requests are rejected with the `429` error code.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.DeleteCatalogObject(new DeleteCatalogObjectRequest
    {
        ObjectId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteCatalogObjectResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCatalogObjectRequest](src/Square/Requests/Catalog/DeleteCatalogObjectRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteCatalogObjectResponse](src/Square/Models/DeleteCatalogObjectResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCatalogResponse&gt; ListCatalog(ListCatalogRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all [CatalogObject](entity:CatalogObject)s of the specified types in the catalog.

The `types` parameter is specified as a comma-separated list of the [CatalogObjectType](entity:CatalogObjectType) values,
for example, "`ITEM`, `ITEM_VARIATION`, `MODIFIER`, `MODIFIER_LIST`, `CATEGORY`, `DISCOUNT`, `TAX`, `IMAGE`".
Always specify `types` explicitly. When upgrading to a newer API version, omitting `types` may
cause new object types to appear in results that were not returned under the previous version.

__Important:__ ListCatalog does not return deleted catalog items. To retrieve
deleted catalog items, use [SearchCatalogObjects](api-endpoint:Catalog-SearchCatalogObjects)
and set the `include_deleted_objects` attribute value to `true`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.ListCatalog(new ListCatalogRequest());
    // TODO: Handle 'response' of type ListCatalogResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCatalogRequest](src/Square/Requests/Catalog/ListCatalogRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCatalogResponse](src/Square/Models/ListCatalogResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCatalogObjectResponse&gt; RetrieveCatalogObject(RetrieveCatalogObjectRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single [CatalogItem](entity:CatalogItem) as a
[CatalogObject](entity:CatalogObject) based on the provided ID. The returned
object includes all of the relevant [CatalogItem](entity:CatalogItem)
information including: [CatalogItemVariation](entity:CatalogItemVariation)
children, references to its
[CatalogModifierList](entity:CatalogModifierList) objects, and the ids of
any [CatalogTax](entity:CatalogTax) objects that apply to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.RetrieveCatalogObject(new RetrieveCatalogObjectRequest
    {
        ObjectId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveCatalogObjectResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveCatalogObjectRequest](src/Square/Requests/Catalog/RetrieveCatalogObjectRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCatalogObjectResponse](src/Square/Models/RetrieveCatalogObjectResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchCatalogItemsResponse&gt; SearchCatalogItems(SearchCatalogItemsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for catalog items or item variations by matching supported search attribute values, including
custom attribute values, against one or more of the specified query filters.

This (`SearchCatalogItems`) endpoint differs from the [SearchCatalogObjects](api-endpoint:Catalog-SearchCatalogObjects)
endpoint in the following aspects:

- `SearchCatalogItems` can only search for items or item variations, whereas `SearchCatalogObjects` can search for any type of catalog objects.
- `SearchCatalogItems` supports the custom attribute query filters to return items or item variations that contain custom attribute values, where `SearchCatalogObjects` does not.
- `SearchCatalogItems` does not support the `include_deleted_objects` filter to search for deleted items or item variations, whereas `SearchCatalogObjects` does.
- The both endpoints use different call conventions, including the query filter formats.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.SearchCatalogItems(new SearchCatalogItemsOperationRequest
    {
        Body = new SearchCatalogItemsRequest(),
    });
    // TODO: Handle 'response' of type SearchCatalogItemsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchCatalogItemsOperationRequest](src/Square/Requests/Catalog/SearchCatalogItemsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchCatalogItemsResponse](src/Square/Models/SearchCatalogItemsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchCatalogObjectsResponse&gt; SearchCatalogObjects(SearchCatalogObjectsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for [CatalogObject](entity:CatalogObject) of any type by matching supported search attribute values,
excluding custom attribute values on items or item variations, against one or more of the specified query filters.

This (`SearchCatalogObjects`) endpoint differs from the [SearchCatalogItems](api-endpoint:Catalog-SearchCatalogItems)
endpoint in the following aspects:

- `SearchCatalogItems` can only search for items or item variations, whereas `SearchCatalogObjects` can search for any type of catalog objects.
- `SearchCatalogItems` supports the custom attribute query filters to return items or item variations that contain custom attribute values, where `SearchCatalogObjects` does not.
- `SearchCatalogItems` does not support the `include_deleted_objects` filter to search for deleted items or item variations, whereas `SearchCatalogObjects` does.
- The both endpoints have different call conventions, including the query filter formats.

The `object_types` parameter is specified as a list of [CatalogObjectType](entity:CatalogObjectType) values.
Always specify `object_types` explicitly. When upgrading to a newer API version, omitting
`object_types` may cause new object types to appear in results that were not returned under
the previous version.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.SearchCatalogObjects(new SearchCatalogObjectsOperationRequest
    {
        Body = new SearchCatalogObjectsRequest(),
    });
    // TODO: Handle 'response' of type SearchCatalogObjectsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchCatalogObjectsOperationRequest](src/Square/Requests/Catalog/SearchCatalogObjectsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchCatalogObjectsResponse](src/Square/Models/SearchCatalogObjectsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateCatalogImageResponse&gt; UpdateCatalogImage(UpdateCatalogImageOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads a new image file to replace the existing one in the specified [CatalogImage](entity:CatalogImage) object.

This `UpdateCatalogImage` endpoint accepts HTTP multipart/form-data requests with a JSON part and an image file part in
JPEG, PJPEG, PNG, or GIF format. The maximum file size is 15MB.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.UpdateCatalogImage(new UpdateCatalogImageOperationRequest
    {
        ImageId = "some example string",
    });
    // TODO: Handle 'response' of type UpdateCatalogImageResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCatalogImageOperationRequest](src/Square/Requests/Catalog/UpdateCatalogImageOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateCatalogImageResponse](src/Square/Models/UpdateCatalogImageResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateItemModifierListsResponse&gt; UpdateItemModifierLists(UpdateItemModifierListsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the [CatalogModifierList](entity:CatalogModifierList) objects
that apply to the targeted [CatalogItem](entity:CatalogItem) without having
to perform an upsert on the entire item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.UpdateItemModifierLists(new UpdateItemModifierListsOperationRequest
    {
        Body = new UpdateItemModifierListsRequest { ItemIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type UpdateItemModifierListsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateItemModifierListsOperationRequest](src/Square/Requests/Catalog/UpdateItemModifierListsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateItemModifierListsResponse](src/Square/Models/UpdateItemModifierListsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateItemTaxesResponse&gt; UpdateItemTaxes(UpdateItemTaxesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the [CatalogTax](entity:CatalogTax) objects that apply to the
targeted [CatalogItem](entity:CatalogItem) without having to perform an
upsert on the entire item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.UpdateItemTaxes(new UpdateItemTaxesOperationRequest
    {
        Body = new UpdateItemTaxesRequest { ItemIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type UpdateItemTaxesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateItemTaxesOperationRequest](src/Square/Requests/Catalog/UpdateItemTaxesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateItemTaxesResponse](src/Square/Models/UpdateItemTaxesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpsertCatalogObjectResponse&gt; UpsertCatalogObject(UpsertCatalogObjectOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new or updates the specified [CatalogObject](entity:CatalogObject).

This endpoint uses full-replacement semantics. The client must send the complete object, and any
field absent from the request is interpreted as an intentional clear. This logic applies to
nested objects as well. For example, omitting inlined children like variations will delete them.

To ensure consistency, only one update request is processed at a time per seller account.
While one (batch or non-batch) update request is being processed, other (batched and non-batched)
update requests are rejected with the `429` error code.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Catalog.UpsertCatalogObject(new UpsertCatalogObjectOperationRequest
    {
        Body = new UpsertCatalogObjectRequest
        {
            IdempotencyKey = "some example string",
            Object = new CatalogObject { Type = CatalogObjectType.Item, Id = "some example string" },
        },
    });
    // TODO: Handle 'response' of type UpsertCatalogObjectResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpsertCatalogObjectOperationRequest](src/Square/Requests/Catalog/UpsertCatalogObjectOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpsertCatalogObjectResponse](src/Square/Models/UpsertCatalogObjectResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Channels

> Source: [Channels](src/Square/Api/Channels.cs)

<details>
<summary><code>Task&lt;BulkRetrieveChannelsResponse&gt; BulkRetrieveChannels(BulkRetrieveChannelsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Channels.BulkRetrieveChannels(new BulkRetrieveChannelsOperationRequest
    {
        Body = new BulkRetrieveChannelsRequest { ChannelIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type BulkRetrieveChannelsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkRetrieveChannelsOperationRequest](src/Square/Requests/Channels/BulkRetrieveChannelsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkRetrieveChannelsResponse](src/Square/Models/BulkRetrieveChannelsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListChannelsResponse&gt; ListChannels(ListChannelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Channels.ListChannels(new ListChannelsRequest());
    // TODO: Handle 'response' of type ListChannelsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListChannelsRequest](src/Square/Requests/Channels/ListChannelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListChannelsResponse](src/Square/Models/ListChannelsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveChannelResponse&gt; RetrieveChannel(RetrieveChannelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Channels.RetrieveChannel(new RetrieveChannelRequest
    {
        ChannelId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveChannelResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveChannelRequest](src/Square/Requests/Channels/RetrieveChannelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveChannelResponse](src/Square/Models/RetrieveChannelResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CheckoutApi

> Source: [CheckoutApi](src/Square/Api/CheckoutApi.cs)

<details>
<summary><code>Task&lt;CreateCheckoutResponse&gt; CreateCheckout(CreateCheckoutOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Links a `checkoutId` to a `checkout_page_url` that customers are
directed to in order to provide their payment information using a
payment processing workflow hosted on connect.squareup.com. 


NOTE: The Checkout API has been updated with new features. 
For more information, see [Checkout API highlights](https://developer.squareup.com/docs/checkout-api#checkout-api-highlights).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutApi.CreateCheckout(new CreateCheckoutOperationRequest
    {
        LocationId = "some example string",
        Body = new CreateCheckoutRequest { IdempotencyKey = "some example string", Order = new CreateOrderRequest() },
    });
    // TODO: Handle 'response' of type CreateCheckoutResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCheckoutOperationRequest](src/Square/Requests/CheckoutApi/CreateCheckoutOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCheckoutResponse](src/Square/Models/CreateCheckoutResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreatePaymentLinkResponse&gt; CreatePaymentLink(CreatePaymentLinkOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a Square-hosted checkout page. Applications can share the resulting payment link with their buyer to pay for goods and services.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutApi.CreatePaymentLink(new CreatePaymentLinkOperationRequest
    {
        Body = new CreatePaymentLinkRequest(),
    });
    // TODO: Handle 'response' of type CreatePaymentLinkResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreatePaymentLinkOperationRequest](src/Square/Requests/CheckoutApi/CreatePaymentLinkOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreatePaymentLinkResponse](src/Square/Models/CreatePaymentLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeletePaymentLinkResponse&gt; DeletePaymentLink(DeletePaymentLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a payment link.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutApi.DeletePaymentLink(new DeletePaymentLinkRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeletePaymentLinkResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeletePaymentLinkRequest](src/Square/Requests/CheckoutApi/DeletePaymentLinkRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeletePaymentLinkResponse](src/Square/Models/DeletePaymentLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListPaymentLinksResponse&gt; ListPaymentLinks(ListPaymentLinksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all payment links.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutApi.ListPaymentLinks(new ListPaymentLinksRequest());
    // TODO: Handle 'response' of type ListPaymentLinksResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListPaymentLinksRequest](src/Square/Requests/CheckoutApi/ListPaymentLinksRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListPaymentLinksResponse](src/Square/Models/ListPaymentLinksResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLocationSettingsResponse&gt; RetrieveLocationSettings(RetrieveLocationSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the location-level settings for a Square-hosted checkout page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutApi.RetrieveLocationSettings(new RetrieveLocationSettingsRequest
    {
        LocationId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveLocationSettingsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveLocationSettingsRequest](src/Square/Requests/CheckoutApi/RetrieveLocationSettingsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLocationSettingsResponse](src/Square/Models/RetrieveLocationSettingsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveMerchantSettingsResponse&gt; RetrieveMerchantSettings(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the merchant-level settings for a Square-hosted checkout page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutApi.RetrieveMerchantSettings();
    // TODO: Handle 'response' of type RetrieveMerchantSettingsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveMerchantSettingsResponse](src/Square/Models/RetrieveMerchantSettingsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrievePaymentLinkResponse&gt; RetrievePaymentLink(RetrievePaymentLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a payment link.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutApi.RetrievePaymentLink(new RetrievePaymentLinkRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type RetrievePaymentLinkResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrievePaymentLinkRequest](src/Square/Requests/CheckoutApi/RetrievePaymentLinkRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrievePaymentLinkResponse](src/Square/Models/RetrievePaymentLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateLocationSettingsResponse&gt; UpdateLocationSettings(UpdateLocationSettingsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the location-level settings for a Square-hosted checkout page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutApi.UpdateLocationSettings(new UpdateLocationSettingsOperationRequest
    {
        LocationId = "some example string",
        Body = new UpdateLocationSettingsRequest { LocationSettings = new CheckoutLocationSettings() },
    });
    // TODO: Handle 'response' of type UpdateLocationSettingsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateLocationSettingsOperationRequest](src/Square/Requests/CheckoutApi/UpdateLocationSettingsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateLocationSettingsResponse](src/Square/Models/UpdateLocationSettingsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateMerchantSettingsResponse&gt; UpdateMerchantSettings(UpdateMerchantSettingsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the merchant-level settings for a Square-hosted checkout page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutApi.UpdateMerchantSettings(new UpdateMerchantSettingsOperationRequest
    {
        Body = new UpdateMerchantSettingsRequest { MerchantSettings = new CheckoutMerchantSettings() },
    });
    // TODO: Handle 'response' of type UpdateMerchantSettingsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantSettingsOperationRequest](src/Square/Requests/CheckoutApi/UpdateMerchantSettingsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateMerchantSettingsResponse](src/Square/Models/UpdateMerchantSettingsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdatePaymentLinkResponse&gt; UpdatePaymentLink(UpdatePaymentLinkOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a payment link. You can update the `payment_link` fields such as
`description`, `checkout_options`, and  `pre_populated_data`.
You cannot update other fields such as the `order_id`, `version`, `URL`, or `timestamp` field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CheckoutApi.UpdatePaymentLink(new UpdatePaymentLinkOperationRequest
    {
        Id = "some example string",
        Body = new UpdatePaymentLinkRequest { PaymentLink = new PaymentLink { Version = 1 } },
    });
    // TODO: Handle 'response' of type UpdatePaymentLinkResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdatePaymentLinkOperationRequest](src/Square/Requests/CheckoutApi/UpdatePaymentLinkOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdatePaymentLinkResponse](src/Square/Models/UpdatePaymentLinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CustomerCustomAttributes

> Source: [CustomerCustomAttributes](src/Square/Api/CustomerCustomAttributes.cs)

<details>
<summary><code>Task&lt;BulkUpsertCustomerCustomAttributesResponse&gt; BulkUpsertCustomerCustomAttributes(BulkUpsertCustomerCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates [custom attributes](entity:CustomAttribute) for customer profiles as a bulk operation.

Use this endpoint to set the value of one or more custom attributes for one or more customer profiles.
A custom attribute is based on a custom attribute definition in a Square seller account, which is
created using the [CreateCustomerCustomAttributeDefinition](api-endpoint:CustomerCustomAttributes-CreateCustomerCustomAttributeDefinition) endpoint.

This `BulkUpsertCustomerCustomAttributes` endpoint accepts a map of 1 to 25 individual upsert
requests and returns a map of individual upsert responses. Each upsert request has a unique ID
and provides a customer ID and custom attribute. Each upsert response is returned with the ID
of the corresponding request.

To create or update a custom attribute owned by another application, the `visibility` setting
must be `VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
(also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerCustomAttributes.BulkUpsertCustomerCustomAttributes(
        new BulkUpsertCustomerCustomAttributesOperationRequest
        {
            Body = new BulkUpsertCustomerCustomAttributesRequest
            {
                Values = new Dictionary<string, BulkUpsertCustomerCustomAttributesRequestCustomerCustomAttributeUpsertRequest>
                {
                    ["key"] = new BulkUpsertCustomerCustomAttributesRequestCustomerCustomAttributeUpsertRequest
                    {
                        CustomerId = "some example string",
                        CustomAttribute = new CustomAttribute(),
                    },
                },
            },
        });
    // TODO: Handle 'response' of type BulkUpsertCustomerCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkUpsertCustomerCustomAttributesOperationRequest](src/Square/Requests/CustomerCustomAttributes/BulkUpsertCustomerCustomAttributesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkUpsertCustomerCustomAttributesResponse](src/Square/Models/BulkUpsertCustomerCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCustomerCustomAttributeDefinitionResponse&gt; CreateCustomerCustomAttributeDefinition(CreateCustomerCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a customer-related [custom attribute definition](entity:CustomAttributeDefinition) for a Square seller account.
Use this endpoint to define a custom attribute that can be associated with customer profiles.

A custom attribute definition specifies the `key`, `visibility`, `schema`, and other properties
for a custom attribute. After the definition is created, you can call
[UpsertCustomerCustomAttribute](api-endpoint:CustomerCustomAttributes-UpsertCustomerCustomAttribute) or
[BulkUpsertCustomerCustomAttributes](api-endpoint:CustomerCustomAttributes-BulkUpsertCustomerCustomAttributes)
to set the custom attribute for customer profiles in the seller's Customer Directory.

Sellers can view all custom attributes in exported customer data, including those set to
`VISIBILITY_HIDDEN`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerCustomAttributes.CreateCustomerCustomAttributeDefinition(
        new CreateCustomerCustomAttributeDefinitionOperationRequest
        {
            Body = new CreateCustomerCustomAttributeDefinitionRequest
            {
                CustomAttributeDefinition = new CustomAttributeDefinition(),
            },
        });
    // TODO: Handle 'response' of type CreateCustomerCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCustomerCustomAttributeDefinitionOperationRequest](src/Square/Requests/CustomerCustomAttributes/CreateCustomerCustomAttributeDefinitionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCustomerCustomAttributeDefinitionResponse](src/Square/Models/CreateCustomerCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteCustomerCustomAttributeResponse&gt; DeleteCustomerCustomAttribute(DeleteCustomerCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a [custom attribute](entity:CustomAttribute) associated with a customer profile.

To delete a custom attribute owned by another application, the `visibility` setting must be
`VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
(also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerCustomAttributes.DeleteCustomerCustomAttribute(
        new DeleteCustomerCustomAttributeRequest { CustomerId = "some example string", Key = "some example string" });
    // TODO: Handle 'response' of type DeleteCustomerCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCustomerCustomAttributeRequest](src/Square/Requests/CustomerCustomAttributes/DeleteCustomerCustomAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteCustomerCustomAttributeResponse](src/Square/Models/DeleteCustomerCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteCustomerCustomAttributeDefinitionResponse&gt; DeleteCustomerCustomAttributeDefinition(DeleteCustomerCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a customer-related [custom attribute definition](entity:CustomAttributeDefinition) from a Square seller account.

Deleting a custom attribute definition also deletes the corresponding custom attribute from
all customer profiles in the seller's Customer Directory.

Only the definition owner can delete a custom attribute definition.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerCustomAttributes.DeleteCustomerCustomAttributeDefinition(
        new DeleteCustomerCustomAttributeDefinitionRequest { Key = "some example string" });
    // TODO: Handle 'response' of type DeleteCustomerCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCustomerCustomAttributeDefinitionRequest](src/Square/Requests/CustomerCustomAttributes/DeleteCustomerCustomAttributeDefinitionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteCustomerCustomAttributeDefinitionResponse](src/Square/Models/DeleteCustomerCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCustomerCustomAttributeDefinitionsResponse&gt; ListCustomerCustomAttributeDefinitions(ListCustomerCustomAttributeDefinitionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the customer-related [custom attribute definitions](entity:CustomAttributeDefinition) that belong to a Square seller account.

When all response pages are retrieved, the results include all custom attribute definitions
that are visible to the requesting application, including those that are created by other
applications and set to `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`. Note that
seller-defined custom attributes (also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerCustomAttributes.ListCustomerCustomAttributeDefinitions(
        new ListCustomerCustomAttributeDefinitionsRequest());
    // TODO: Handle 'response' of type ListCustomerCustomAttributeDefinitionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCustomerCustomAttributeDefinitionsRequest](src/Square/Requests/CustomerCustomAttributes/ListCustomerCustomAttributeDefinitionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCustomerCustomAttributeDefinitionsResponse](src/Square/Models/ListCustomerCustomAttributeDefinitionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCustomerCustomAttributesResponse&gt; ListCustomerCustomAttributes(ListCustomerCustomAttributesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the [custom attributes](entity:CustomAttribute) associated with a customer profile.

You can use the `with_definitions` query parameter to also retrieve custom attribute definitions
in the same call.

When all response pages are retrieved, the results include all custom attributes that are
visible to the requesting application, including those that are owned by other applications
and set to `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerCustomAttributes.ListCustomerCustomAttributes(
        new ListCustomerCustomAttributesRequest { CustomerId = "some example string" });
    // TODO: Handle 'response' of type ListCustomerCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCustomerCustomAttributesRequest](src/Square/Requests/CustomerCustomAttributes/ListCustomerCustomAttributesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCustomerCustomAttributesResponse](src/Square/Models/ListCustomerCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCustomerCustomAttributeResponse&gt; RetrieveCustomerCustomAttribute(RetrieveCustomerCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a [custom attribute](entity:CustomAttribute) associated with a customer profile.

You can use the `with_definition` query parameter to also retrieve the custom attribute definition
in the same call.

To retrieve a custom attribute owned by another application, the `visibility` setting must be
`VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
(also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerCustomAttributes.RetrieveCustomerCustomAttribute(
        new RetrieveCustomerCustomAttributeRequest { CustomerId = "some example string", Key = "some example string" });
    // TODO: Handle 'response' of type RetrieveCustomerCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveCustomerCustomAttributeRequest](src/Square/Requests/CustomerCustomAttributes/RetrieveCustomerCustomAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCustomerCustomAttributeResponse](src/Square/Models/RetrieveCustomerCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCustomerCustomAttributeDefinitionResponse&gt; RetrieveCustomerCustomAttributeDefinition(RetrieveCustomerCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a customer-related [custom attribute definition](entity:CustomAttributeDefinition) from a Square seller account.

To retrieve a custom attribute definition created by another application, the `visibility`
setting must be `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
(also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerCustomAttributes.RetrieveCustomerCustomAttributeDefinition(
        new RetrieveCustomerCustomAttributeDefinitionRequest { Key = "some example string" });
    // TODO: Handle 'response' of type RetrieveCustomerCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveCustomerCustomAttributeDefinitionRequest](src/Square/Requests/CustomerCustomAttributes/RetrieveCustomerCustomAttributeDefinitionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCustomerCustomAttributeDefinitionResponse](src/Square/Models/RetrieveCustomerCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateCustomerCustomAttributeDefinitionResponse&gt; UpdateCustomerCustomAttributeDefinition(UpdateCustomerCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a customer-related [custom attribute definition](entity:CustomAttributeDefinition) for a Square seller account.

Use this endpoint to update the following fields: `name`, `description`, `visibility`, or the
`schema` for a `Selection` data type.

Only the definition owner can update a custom attribute definition. Note that sellers can view
all custom attributes in exported customer data, including those set to `VISIBILITY_HIDDEN`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerCustomAttributes.UpdateCustomerCustomAttributeDefinition(
        new UpdateCustomerCustomAttributeDefinitionOperationRequest
        {
            Key = "some example string",
            Body = new UpdateCustomerCustomAttributeDefinitionRequest
            {
                CustomAttributeDefinition = new CustomAttributeDefinition(),
            },
        });
    // TODO: Handle 'response' of type UpdateCustomerCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCustomerCustomAttributeDefinitionOperationRequest](src/Square/Requests/CustomerCustomAttributes/UpdateCustomerCustomAttributeDefinitionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateCustomerCustomAttributeDefinitionResponse](src/Square/Models/UpdateCustomerCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpsertCustomerCustomAttributeResponse&gt; UpsertCustomerCustomAttribute(UpsertCustomerCustomAttributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates a [custom attribute](entity:CustomAttribute) for a customer profile.

Use this endpoint to set the value of a custom attribute for a specified customer profile.
A custom attribute is based on a custom attribute definition in a Square seller account, which
is created using the [CreateCustomerCustomAttributeDefinition](api-endpoint:CustomerCustomAttributes-CreateCustomerCustomAttributeDefinition) endpoint.

To create or update a custom attribute owned by another application, the `visibility` setting
must be `VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
(also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerCustomAttributes.UpsertCustomerCustomAttribute(
        new UpsertCustomerCustomAttributeOperationRequest
        {
            CustomerId = "some example string",
            Key = "some example string",
            Body = new UpsertCustomerCustomAttributeRequest { CustomAttribute = new CustomAttribute() },
        });
    // TODO: Handle 'response' of type UpsertCustomerCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpsertCustomerCustomAttributeOperationRequest](src/Square/Requests/CustomerCustomAttributes/UpsertCustomerCustomAttributeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpsertCustomerCustomAttributeResponse](src/Square/Models/UpsertCustomerCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CustomerGroups

> Source: [CustomerGroups](src/Square/Api/CustomerGroups.cs)

<details>
<summary><code>Task&lt;CreateCustomerGroupResponse&gt; CreateCustomerGroup(CreateCustomerGroupOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new customer group for a business.

The request must include the `name` value of the group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerGroups.CreateCustomerGroup(new CreateCustomerGroupOperationRequest
    {
        Body = new CreateCustomerGroupRequest { Group = new CustomerGroup { Name = "some example string" } },
    });
    // TODO: Handle 'response' of type CreateCustomerGroupResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCustomerGroupOperationRequest](src/Square/Requests/CustomerGroups/CreateCustomerGroupOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCustomerGroupResponse](src/Square/Models/CreateCustomerGroupResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteCustomerGroupResponse&gt; DeleteCustomerGroup(DeleteCustomerGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a customer group as identified by the `group_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerGroups.DeleteCustomerGroup(new DeleteCustomerGroupRequest
    {
        GroupId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteCustomerGroupResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCustomerGroupRequest](src/Square/Requests/CustomerGroups/DeleteCustomerGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteCustomerGroupResponse](src/Square/Models/DeleteCustomerGroupResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCustomerGroupsResponse&gt; ListCustomerGroups(ListCustomerGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the list of customer groups of a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerGroups.ListCustomerGroups(new ListCustomerGroupsRequest());
    // TODO: Handle 'response' of type ListCustomerGroupsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCustomerGroupsRequest](src/Square/Requests/CustomerGroups/ListCustomerGroupsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCustomerGroupsResponse](src/Square/Models/ListCustomerGroupsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCustomerGroupResponse&gt; RetrieveCustomerGroup(RetrieveCustomerGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific customer group as identified by the `group_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerGroups.RetrieveCustomerGroup(new RetrieveCustomerGroupRequest
    {
        GroupId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveCustomerGroupResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveCustomerGroupRequest](src/Square/Requests/CustomerGroups/RetrieveCustomerGroupRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCustomerGroupResponse](src/Square/Models/RetrieveCustomerGroupResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateCustomerGroupResponse&gt; UpdateCustomerGroup(UpdateCustomerGroupOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a customer group as identified by the `group_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerGroups.UpdateCustomerGroup(new UpdateCustomerGroupOperationRequest
    {
        GroupId = "some example string",
        Body = new UpdateCustomerGroupRequest { Group = new CustomerGroup { Name = "some example string" } },
    });
    // TODO: Handle 'response' of type UpdateCustomerGroupResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCustomerGroupOperationRequest](src/Square/Requests/CustomerGroups/UpdateCustomerGroupOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateCustomerGroupResponse](src/Square/Models/UpdateCustomerGroupResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CustomerSegments

> Source: [CustomerSegments](src/Square/Api/CustomerSegments.cs)

<details>
<summary><code>Task&lt;ListCustomerSegmentsResponse&gt; ListCustomerSegments(ListCustomerSegmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the list of customer segments of a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerSegments.ListCustomerSegments(new ListCustomerSegmentsRequest());
    // TODO: Handle 'response' of type ListCustomerSegmentsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCustomerSegmentsRequest](src/Square/Requests/CustomerSegments/ListCustomerSegmentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCustomerSegmentsResponse](src/Square/Models/ListCustomerSegmentsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCustomerSegmentResponse&gt; RetrieveCustomerSegment(RetrieveCustomerSegmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific customer segment as identified by the `segment_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerSegments.RetrieveCustomerSegment(new RetrieveCustomerSegmentRequest
    {
        SegmentId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveCustomerSegmentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveCustomerSegmentRequest](src/Square/Requests/CustomerSegments/RetrieveCustomerSegmentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCustomerSegmentResponse](src/Square/Models/RetrieveCustomerSegmentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Customers

> Source: [Customers](src/Square/Api/Customers.cs)

<details>
<summary><code>Task&lt;AddGroupToCustomerResponse&gt; AddGroupToCustomer(AddGroupToCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a group membership to a customer.

The customer is identified by the `customer_id` value
and the customer group is identified by the `group_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.AddGroupToCustomer(new AddGroupToCustomerRequest
    {
        CustomerId = "some example string",
        GroupId = "some example string",
    });
    // TODO: Handle 'response' of type AddGroupToCustomerResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddGroupToCustomerRequest](src/Square/Requests/Customers/AddGroupToCustomerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AddGroupToCustomerResponse](src/Square/Models/AddGroupToCustomerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkCreateCustomersResponse&gt; BulkCreateCustomers(BulkCreateCustomersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates multiple [customer profiles](entity:Customer) for a business.

This endpoint takes a map of individual create requests and returns a map of responses.

You must provide at least one of the following values in each create request:

- `given_name`
- `family_name`
- `company_name`
- `email_address`
- `phone_number`

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.BulkCreateCustomers(new BulkCreateCustomersOperationRequest
    {
        Body = new BulkCreateCustomersRequest
        {
            Customers = new Dictionary<string, BulkCreateCustomerData> { ["key"] = new BulkCreateCustomerData() },
        },
    });
    // TODO: Handle 'response' of type BulkCreateCustomersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkCreateCustomersOperationRequest](src/Square/Requests/Customers/BulkCreateCustomersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkCreateCustomersResponse](src/Square/Models/BulkCreateCustomersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkDeleteCustomersResponse&gt; BulkDeleteCustomers(BulkDeleteCustomersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes multiple customer profiles.

The endpoint takes a list of customer IDs and returns a map of responses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.BulkDeleteCustomers(new BulkDeleteCustomersOperationRequest
    {
        Body = new BulkDeleteCustomersRequest { CustomerIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type BulkDeleteCustomersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkDeleteCustomersOperationRequest](src/Square/Requests/Customers/BulkDeleteCustomersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkDeleteCustomersResponse](src/Square/Models/BulkDeleteCustomersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkRetrieveCustomersResponse&gt; BulkRetrieveCustomers(BulkRetrieveCustomersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves multiple customer profiles.

This endpoint takes a list of customer IDs and returns a map of responses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.BulkRetrieveCustomers(new BulkRetrieveCustomersOperationRequest
    {
        Body = new BulkRetrieveCustomersRequest { CustomerIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type BulkRetrieveCustomersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkRetrieveCustomersOperationRequest](src/Square/Requests/Customers/BulkRetrieveCustomersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkRetrieveCustomersResponse](src/Square/Models/BulkRetrieveCustomersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkUpdateCustomersResponse&gt; BulkUpdateCustomers(BulkUpdateCustomersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates multiple customer profiles.

This endpoint takes a map of individual update requests and returns a map of responses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.BulkUpdateCustomers(new BulkUpdateCustomersOperationRequest
    {
        Body = new BulkUpdateCustomersRequest
        {
            Customers = new Dictionary<string, BulkUpdateCustomerData> { ["key"] = new BulkUpdateCustomerData() },
        },
    });
    // TODO: Handle 'response' of type BulkUpdateCustomersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkUpdateCustomersOperationRequest](src/Square/Requests/Customers/BulkUpdateCustomersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkUpdateCustomersResponse](src/Square/Models/BulkUpdateCustomersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCustomerResponse&gt; CreateCustomer(CreateCustomerOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new customer for a business.

You must provide at least one of the following values in your request to this
endpoint:

- `given_name`
- `family_name`
- `company_name`
- `email_address`
- `phone_number`

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.CreateCustomer(new CreateCustomerOperationRequest
    {
        Body = new CreateCustomerRequest(),
    });
    // TODO: Handle 'response' of type CreateCustomerResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCustomerOperationRequest](src/Square/Requests/Customers/CreateCustomerOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCustomerResponse](src/Square/Models/CreateCustomerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateCustomerCardResponse&gt; CreateCustomerCard(CreateCustomerCardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a card on file to an existing customer.

As with charges, calls to `CreateCustomerCard` are idempotent. Multiple
calls with the same card nonce return the same card record that was created
with the provided nonce during the _first_ call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.CreateCustomerCard(new CreateCustomerCardOperationRequest
    {
        CustomerId = "some example string",
        Body = new CreateCustomerCardRequest { CardNonce = "some example string" },
    });
    // TODO: Handle 'response' of type CreateCustomerCardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateCustomerCardOperationRequest](src/Square/Requests/Customers/CreateCustomerCardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateCustomerCardResponse](src/Square/Models/CreateCustomerCardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteCustomerResponse&gt; DeleteCustomer(DeleteCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a customer profile from a business.

To delete a customer profile that was created by merging existing profiles, you must use the ID of the newly created profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.DeleteCustomer(new DeleteCustomerRequest
    {
        CustomerId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteCustomerResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCustomerRequest](src/Square/Requests/Customers/DeleteCustomerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteCustomerResponse](src/Square/Models/DeleteCustomerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteCustomerCardResponse&gt; DeleteCustomerCard(DeleteCustomerCardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a card on file from a customer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.DeleteCustomerCard(new DeleteCustomerCardRequest
    {
        CustomerId = "some example string",
        CardId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteCustomerCardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteCustomerCardRequest](src/Square/Requests/Customers/DeleteCustomerCardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteCustomerCardResponse](src/Square/Models/DeleteCustomerCardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListCustomersResponse&gt; ListCustomers(ListCustomersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists customer profiles associated with a Square account.

Under normal operating conditions, newly created or updated customer profiles become available
for the listing operation in well under 30 seconds. Occasionally, propagation of the new or updated
profiles can take closer to one minute or longer, especially during network incidents and outages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.ListCustomers(new ListCustomersRequest());
    // TODO: Handle 'response' of type ListCustomersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCustomersRequest](src/Square/Requests/Customers/ListCustomersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListCustomersResponse](src/Square/Models/ListCustomersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RemoveGroupFromCustomerResponse&gt; RemoveGroupFromCustomer(RemoveGroupFromCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a group membership from a customer.

The customer is identified by the `customer_id` value
and the customer group is identified by the `group_id` value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.RemoveGroupFromCustomer(new RemoveGroupFromCustomerRequest
    {
        CustomerId = "some example string",
        GroupId = "some example string",
    });
    // TODO: Handle 'response' of type RemoveGroupFromCustomerResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemoveGroupFromCustomerRequest](src/Square/Requests/Customers/RemoveGroupFromCustomerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RemoveGroupFromCustomerResponse](src/Square/Models/RemoveGroupFromCustomerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveCustomerResponse&gt; RetrieveCustomer(RetrieveCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details for a single customer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.RetrieveCustomer(new RetrieveCustomerRequest
    {
        CustomerId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveCustomerResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveCustomerRequest](src/Square/Requests/Customers/RetrieveCustomerRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveCustomerResponse](src/Square/Models/RetrieveCustomerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchCustomersResponse&gt; SearchCustomers(SearchCustomersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches the customer profiles associated with a Square account using one or more supported query filters.

Calling `SearchCustomers` without any explicit query filter returns all
customer profiles ordered alphabetically based on `given_name` and
`family_name`.

Under normal operating conditions, newly created or updated customer profiles become available
for the search operation in well under 30 seconds. Occasionally, propagation of the new or updated
profiles can take closer to one minute or longer, especially during network incidents and outages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.SearchCustomers(new SearchCustomersOperationRequest
    {
        Body = new SearchCustomersRequest(),
    });
    // TODO: Handle 'response' of type SearchCustomersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchCustomersOperationRequest](src/Square/Requests/Customers/SearchCustomersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchCustomersResponse](src/Square/Models/SearchCustomersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateCustomerResponse&gt; UpdateCustomer(UpdateCustomerOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a customer profile. This endpoint supports sparse updates, so only new or changed fields are required in the request.
To add or update a field, specify the new value. To remove a field, specify `null`.

To update a customer profile that was created by merging existing profiles, you must use the ID of the newly created profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Customers.UpdateCustomer(new UpdateCustomerOperationRequest
    {
        CustomerId = "some example string",
        Body = new UpdateCustomerRequest(),
    });
    // TODO: Handle 'response' of type UpdateCustomerResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateCustomerOperationRequest](src/Square/Requests/Customers/UpdateCustomerOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateCustomerResponse](src/Square/Models/UpdateCustomerResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Devices

> Source: [Devices](src/Square/Api/Devices.cs)

<details>
<summary><code>Task&lt;CreateDeviceCodeResponse&gt; CreateDeviceCode(CreateDeviceCodeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a DeviceCode that can be used to login to a Square Terminal device to enter the connected
terminal mode.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Devices.CreateDeviceCode(new CreateDeviceCodeOperationRequest
    {
        Body = new CreateDeviceCodeRequest
        {
            IdempotencyKey = "some example string",
            DeviceCode = new DeviceCode { ProductType = ProductType.TerminalApi },
        },
    });
    // TODO: Handle 'response' of type CreateDeviceCodeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateDeviceCodeOperationRequest](src/Square/Requests/Devices/CreateDeviceCodeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateDeviceCodeResponse](src/Square/Models/CreateDeviceCodeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetDeviceResponse&gt; GetDevice(GetDeviceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves Device with the associated `device_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Devices.GetDevice(new GetDeviceRequest { DeviceId = "some example string" });
    // TODO: Handle 'response' of type GetDeviceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDeviceRequest](src/Square/Requests/Devices/GetDeviceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetDeviceResponse](src/Square/Models/GetDeviceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetDeviceCodeResponse&gt; GetDeviceCode(GetDeviceCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves DeviceCode with the associated ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Devices.GetDeviceCode(new GetDeviceCodeRequest { Id = "some example string" });
    // TODO: Handle 'response' of type GetDeviceCodeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetDeviceCodeRequest](src/Square/Requests/Devices/GetDeviceCodeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetDeviceCodeResponse](src/Square/Models/GetDeviceCodeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListDeviceCodesResponse&gt; ListDeviceCodes(ListDeviceCodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all DeviceCodes associated with the merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Devices.ListDeviceCodes(new ListDeviceCodesRequest());
    // TODO: Handle 'response' of type ListDeviceCodesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDeviceCodesRequest](src/Square/Requests/Devices/ListDeviceCodesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListDeviceCodesResponse](src/Square/Models/ListDeviceCodesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListDevicesResponse&gt; ListDevices(ListDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List devices associated with the merchant. Currently, only Terminal API
devices are supported.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Devices.ListDevices(new ListDevicesRequest());
    // TODO: Handle 'response' of type ListDevicesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDevicesRequest](src/Square/Requests/Devices/ListDevicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListDevicesResponse](src/Square/Models/ListDevicesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Disputes

> Source: [Disputes](src/Square/Api/Disputes.cs)

<details>
<summary><code>Task&lt;AcceptDisputeResponse&gt; AcceptDispute(AcceptDisputeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Accepts the loss on a dispute. Square returns the disputed amount to the cardholder and
updates the dispute state to ACCEPTED.

Square debits the disputed amount from the seller’s Square account. If the Square account
does not have sufficient funds, Square debits the associated bank account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.AcceptDispute(new AcceptDisputeRequest { DisputeId = "some example string" });
    // TODO: Handle 'response' of type AcceptDisputeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AcceptDisputeRequest](src/Square/Requests/Disputes/AcceptDisputeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AcceptDisputeResponse](src/Square/Models/AcceptDisputeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateDisputeEvidenceFileResponse&gt; CreateDisputeEvidenceFile(CreateDisputeEvidenceFileOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads a file to use as evidence in a dispute challenge. The endpoint accepts HTTP
multipart/form-data file uploads in HEIC, HEIF, JPEG, PDF, PNG, and TIFF formats.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.CreateDisputeEvidenceFile(new CreateDisputeEvidenceFileOperationRequest
    {
        DisputeId = "some example string",
    });
    // TODO: Handle 'response' of type CreateDisputeEvidenceFileResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateDisputeEvidenceFileOperationRequest](src/Square/Requests/Disputes/CreateDisputeEvidenceFileOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateDisputeEvidenceFileResponse](src/Square/Models/CreateDisputeEvidenceFileResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateDisputeEvidenceTextResponse&gt; CreateDisputeEvidenceText(CreateDisputeEvidenceTextOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads text to use as evidence for a dispute challenge.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.CreateDisputeEvidenceText(new CreateDisputeEvidenceTextOperationRequest
    {
        DisputeId = "some example string",
        Body = new CreateDisputeEvidenceTextRequest
        {
            IdempotencyKey = "some example string",
            EvidenceText = "some example string",
        },
    });
    // TODO: Handle 'response' of type CreateDisputeEvidenceTextResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateDisputeEvidenceTextOperationRequest](src/Square/Requests/Disputes/CreateDisputeEvidenceTextOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateDisputeEvidenceTextResponse](src/Square/Models/CreateDisputeEvidenceTextResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteDisputeEvidenceResponse&gt; DeleteDisputeEvidence(DeleteDisputeEvidenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes specified evidence from a dispute.
Square does not send the bank any evidence that is removed.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.DeleteDisputeEvidence(new DeleteDisputeEvidenceRequest
    {
        DisputeId = "some example string",
        EvidenceId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteDisputeEvidenceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteDisputeEvidenceRequest](src/Square/Requests/Disputes/DeleteDisputeEvidenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteDisputeEvidenceResponse](src/Square/Models/DeleteDisputeEvidenceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListDisputeEvidenceResponse&gt; ListDisputeEvidence(ListDisputeEvidenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of evidence associated with a dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.ListDisputeEvidence(new ListDisputeEvidenceRequest
    {
        DisputeId = "some example string",
    });
    // TODO: Handle 'response' of type ListDisputeEvidenceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDisputeEvidenceRequest](src/Square/Requests/Disputes/ListDisputeEvidenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListDisputeEvidenceResponse](src/Square/Models/ListDisputeEvidenceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListDisputesResponse&gt; ListDisputes(ListDisputesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of disputes associated with a particular account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.ListDisputes(new ListDisputesRequest());
    // TODO: Handle 'response' of type ListDisputesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListDisputesRequest](src/Square/Requests/Disputes/ListDisputesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListDisputesResponse](src/Square/Models/ListDisputesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveDisputeResponse&gt; RetrieveDispute(RetrieveDisputeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details about a specific dispute.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.RetrieveDispute(new RetrieveDisputeRequest
    {
        DisputeId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveDisputeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveDisputeRequest](src/Square/Requests/Disputes/RetrieveDisputeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveDisputeResponse](src/Square/Models/RetrieveDisputeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveDisputeEvidenceResponse&gt; RetrieveDisputeEvidence(RetrieveDisputeEvidenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the metadata for the evidence specified in the request URL path.

You must maintain a copy of any evidence uploaded if you want to reference it later. Evidence cannot be downloaded after you upload it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.RetrieveDisputeEvidence(new RetrieveDisputeEvidenceRequest
    {
        DisputeId = "some example string",
        EvidenceId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveDisputeEvidenceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveDisputeEvidenceRequest](src/Square/Requests/Disputes/RetrieveDisputeEvidenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveDisputeEvidenceResponse](src/Square/Models/RetrieveDisputeEvidenceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubmitEvidenceResponse&gt; SubmitEvidence(SubmitEvidenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits evidence to the cardholder's bank.

The evidence submitted by this endpoint includes evidence uploaded
using the [CreateDisputeEvidenceFile](api-endpoint:Disputes-CreateDisputeEvidenceFile) and
[CreateDisputeEvidenceText](api-endpoint:Disputes-CreateDisputeEvidenceText) endpoints and
evidence automatically provided by Square, when available. Evidence cannot be removed from
a dispute after submission.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Disputes.SubmitEvidence(new SubmitEvidenceRequest
    {
        DisputeId = "some example string",
    });
    // TODO: Handle 'response' of type SubmitEvidenceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubmitEvidenceRequest](src/Square/Requests/Disputes/SubmitEvidenceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubmitEvidenceResponse](src/Square/Models/SubmitEvidenceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Employees

> Source: [Employees](src/Square/Api/Employees.cs)

<details>
<summary><code>Task&lt;ListEmployeesResponse&gt; ListEmployees(ListEmployeesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Employees.ListEmployees(new ListEmployeesRequest());
    // TODO: Handle 'response' of type ListEmployeesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListEmployeesRequest](src/Square/Requests/Employees/ListEmployeesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListEmployeesResponse](src/Square/Models/ListEmployeesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveEmployeeResponse&gt; RetrieveEmployee(RetrieveEmployeeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Employees.RetrieveEmployee(new RetrieveEmployeeRequest { Id = "some example string" });
    // TODO: Handle 'response' of type RetrieveEmployeeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveEmployeeRequest](src/Square/Requests/Employees/RetrieveEmployeeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveEmployeeResponse](src/Square/Models/RetrieveEmployeeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Events

> Source: [Events](src/Square/Api/Events.cs)

<details>
<summary><code>Task&lt;DisableEventsResponse&gt; DisableEvents(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Disables events to prevent them from being searchable.
All events are disabled by default. You must enable events to make them searchable.
Disabling events for a specific time period prevents them from being searchable, even if you re-enable them later.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Events.DisableEvents();
    // TODO: Handle 'response' of type DisableEventsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DisableEventsResponse](src/Square/Models/DisableEventsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EnableEventsResponse&gt; EnableEvents(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables events to make them searchable. Only events that occur while in the enabled state are searchable.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Events.EnableEvents();
    // TODO: Handle 'response' of type EnableEventsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EnableEventsResponse](src/Square/Models/EnableEventsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListEventTypesResponse&gt; ListEventTypes(ListEventTypesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all event types that you can subscribe to as webhooks or query using the Events API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Events.ListEventTypes(new ListEventTypesRequest());
    // TODO: Handle 'response' of type ListEventTypesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListEventTypesRequest](src/Square/Requests/Events/ListEventTypesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListEventTypesResponse](src/Square/Models/ListEventTypesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchEventsResponse&gt; SearchEvents(SearchEventsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for Square API events that occur within a 28-day timeframe.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Events.SearchEvents(new SearchEventsOperationRequest
    {
        Body = new SearchEventsRequest(),
    });
    // TODO: Handle 'response' of type SearchEventsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchEventsOperationRequest](src/Square/Requests/Events/SearchEventsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchEventsResponse](src/Square/Models/SearchEventsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GiftCardActivities

> Source: [GiftCardActivities](src/Square/Api/GiftCardActivities.cs)

<details>
<summary><code>Task&lt;CreateGiftCardActivityResponse&gt; CreateGiftCardActivity(CreateGiftCardActivityOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a gift card activity to manage the balance or state of a [gift card](entity:GiftCard).
For example, create an `ACTIVATE` activity to activate a gift card with an initial balance before first use.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCardActivities.CreateGiftCardActivity(new CreateGiftCardActivityOperationRequest
    {
        Body = new CreateGiftCardActivityRequest
        {
            IdempotencyKey = "some example string",
            GiftCardActivity = new GiftCardActivity
            {
                Type = GiftCardActivityType.Activate,
                LocationId = "some example string",
            },
        },
    });
    // TODO: Handle 'response' of type CreateGiftCardActivityResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateGiftCardActivityOperationRequest](src/Square/Requests/GiftCardActivities/CreateGiftCardActivityOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateGiftCardActivityResponse](src/Square/Models/CreateGiftCardActivityResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListGiftCardActivitiesResponse&gt; ListGiftCardActivities(ListGiftCardActivitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists gift card activities. By default, you get gift card activities for all
gift cards in the seller's account. You can optionally specify query parameters to
filter the list. For example, you can get a list of gift card activities for a gift card,
for all gift cards in a specific region, or for activities within a time window.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCardActivities.ListGiftCardActivities(new ListGiftCardActivitiesRequest());
    // TODO: Handle 'response' of type ListGiftCardActivitiesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListGiftCardActivitiesRequest](src/Square/Requests/GiftCardActivities/ListGiftCardActivitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListGiftCardActivitiesResponse](src/Square/Models/ListGiftCardActivitiesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GiftCards

> Source: [GiftCards](src/Square/Api/GiftCards.cs)

<details>
<summary><code>Task&lt;CreateGiftCardResponse&gt; CreateGiftCard(CreateGiftCardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a digital gift card or registers a physical (plastic) gift card. The resulting gift card
has a `PENDING` state. To activate a gift card so that it can be redeemed for purchases, call
[CreateGiftCardActivity](api-endpoint:GiftCardActivities-CreateGiftCardActivity) and create an `ACTIVATE`
activity with the initial balance. Alternatively, you can use [RefundPayment](api-endpoint:Refunds-RefundPayment)
to refund a payment to the new gift card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.CreateGiftCard(new CreateGiftCardOperationRequest
    {
        Body = new CreateGiftCardRequest
        {
            IdempotencyKey = "some example string",
            LocationId = "some example string",
            GiftCard = new GiftCard { Type = GiftCardType.Physical },
        },
    });
    // TODO: Handle 'response' of type CreateGiftCardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateGiftCardOperationRequest](src/Square/Requests/GiftCards/CreateGiftCardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateGiftCardResponse](src/Square/Models/CreateGiftCardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LinkCustomerToGiftCardResponse&gt; LinkCustomerToGiftCard(LinkCustomerToGiftCardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Links a customer to a gift card, which is also referred to as adding a card on file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.LinkCustomerToGiftCard(new LinkCustomerToGiftCardOperationRequest
    {
        GiftCardId = "some example string",
        Body = new LinkCustomerToGiftCardRequest { CustomerId = "some example string" },
    });
    // TODO: Handle 'response' of type LinkCustomerToGiftCardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LinkCustomerToGiftCardOperationRequest](src/Square/Requests/GiftCards/LinkCustomerToGiftCardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LinkCustomerToGiftCardResponse](src/Square/Models/LinkCustomerToGiftCardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListGiftCardsResponse&gt; ListGiftCards(ListGiftCardsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all gift cards. You can specify optional filters to retrieve 
a subset of the gift cards. Results are sorted by `created_at` in ascending order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.ListGiftCards(new ListGiftCardsRequest());
    // TODO: Handle 'response' of type ListGiftCardsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListGiftCardsRequest](src/Square/Requests/GiftCards/ListGiftCardsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListGiftCardsResponse](src/Square/Models/ListGiftCardsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveGiftCardResponse&gt; RetrieveGiftCard(RetrieveGiftCardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a gift card using the gift card ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.RetrieveGiftCard(new RetrieveGiftCardRequest { Id = "some example string" });
    // TODO: Handle 'response' of type RetrieveGiftCardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveGiftCardRequest](src/Square/Requests/GiftCards/RetrieveGiftCardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveGiftCardResponse](src/Square/Models/RetrieveGiftCardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveGiftCardFromGanResponse&gt; RetrieveGiftCardFromGan(RetrieveGiftCardFromGanOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a gift card using the gift card account number (GAN).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.RetrieveGiftCardFromGan(new RetrieveGiftCardFromGanOperationRequest
    {
        Body = new RetrieveGiftCardFromGanRequest { Gan = "some example string" },
    });
    // TODO: Handle 'response' of type RetrieveGiftCardFromGanResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveGiftCardFromGanOperationRequest](src/Square/Requests/GiftCards/RetrieveGiftCardFromGanOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveGiftCardFromGanResponse](src/Square/Models/RetrieveGiftCardFromGanResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveGiftCardFromNonceResponse&gt; RetrieveGiftCardFromNonce(RetrieveGiftCardFromNonceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a gift card using a secure payment token that represents the gift card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.RetrieveGiftCardFromNonce(new RetrieveGiftCardFromNonceOperationRequest
    {
        Body = new RetrieveGiftCardFromNonceRequest { Nonce = "some example string" },
    });
    // TODO: Handle 'response' of type RetrieveGiftCardFromNonceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveGiftCardFromNonceOperationRequest](src/Square/Requests/GiftCards/RetrieveGiftCardFromNonceOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveGiftCardFromNonceResponse](src/Square/Models/RetrieveGiftCardFromNonceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UnlinkCustomerFromGiftCardResponse&gt; UnlinkCustomerFromGiftCard(UnlinkCustomerFromGiftCardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Unlinks a customer from a gift card, which is also referred to as removing a card on file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GiftCards.UnlinkCustomerFromGiftCard(new UnlinkCustomerFromGiftCardOperationRequest
    {
        GiftCardId = "some example string",
        Body = new UnlinkCustomerFromGiftCardRequest { CustomerId = "some example string" },
    });
    // TODO: Handle 'response' of type UnlinkCustomerFromGiftCardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UnlinkCustomerFromGiftCardOperationRequest](src/Square/Requests/GiftCards/UnlinkCustomerFromGiftCardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UnlinkCustomerFromGiftCardResponse](src/Square/Models/UnlinkCustomerFromGiftCardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Inventory

> Source: [Inventory](src/Square/Api/Inventory.cs)

<details>
<summary><code>Task&lt;BatchChangeInventoryResponse&gt; BatchChangeInventory(BatchChangeInventoryOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Applies adjustments and counts to the provided item quantities.

On success: returns the current calculated counts for all objects
referenced in the request.
On failure: returns a list of related errors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.BatchChangeInventory(new BatchChangeInventoryOperationRequest
    {
        Body = new BatchChangeInventoryRequest { IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type BatchChangeInventoryResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BatchChangeInventoryOperationRequest](src/Square/Requests/Inventory/BatchChangeInventoryOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchChangeInventoryResponse](src/Square/Models/BatchChangeInventoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchRetrieveInventoryChangesResponse&gt; BatchRetrieveInventoryChanges(BatchRetrieveInventoryChangesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns historical physical counts and adjustments based on the
provided filter criteria.

Results are paginated and sorted in ascending order according their
`occurred_at` timestamp (oldest first).

BatchRetrieveInventoryChanges is a catch-all query endpoint for queries
that cannot be handled by other, simpler endpoints.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.BatchRetrieveInventoryChanges(
        new BatchRetrieveInventoryChangesOperationRequest { Body = new BatchRetrieveInventoryChangesRequest() });
    // TODO: Handle 'response' of type BatchRetrieveInventoryChangesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BatchRetrieveInventoryChangesOperationRequest](src/Square/Requests/Inventory/BatchRetrieveInventoryChangesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveInventoryChangesResponse](src/Square/Models/BatchRetrieveInventoryChangesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchRetrieveInventoryCountsResponse&gt; BatchRetrieveInventoryCounts(BatchRetrieveInventoryCountsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns current counts for the provided
[CatalogObject](entity:CatalogObject)s at the requested
[Location](entity:Location)s.

Results are paginated and sorted in descending order according to their
`calculated_at` timestamp (newest first).

When `updated_after` is specified, only counts that have changed since that
time (based on the server timestamp for the most recent change) are
returned. This allows clients to perform a "sync" operation, for example
in response to receiving a Webhook notification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.BatchRetrieveInventoryCounts(new BatchRetrieveInventoryCountsOperationRequest
    {
        Body = new BatchRetrieveInventoryCountsRequest(),
    });
    // TODO: Handle 'response' of type BatchRetrieveInventoryCountsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BatchRetrieveInventoryCountsOperationRequest](src/Square/Requests/Inventory/BatchRetrieveInventoryCountsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveInventoryCountsResponse](src/Square/Models/BatchRetrieveInventoryCountsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateInventoryAdjustmentReasonResponse&gt; CreateInventoryAdjustmentReason(CreateInventoryAdjustmentReasonOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a custom inventory adjustment reason.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.CreateInventoryAdjustmentReason(
        new CreateInventoryAdjustmentReasonOperationRequest
        {
            Body = new CreateInventoryAdjustmentReasonRequest
            {
                IdempotencyKey = "some example string",
                AdjustmentReason = new InventoryAdjustmentReason
                {
                    Id = new InventoryAdjustmentReasonId { Type = InventoryAdjustmentReasonIdType.Received },
                },
            },
        });
    // TODO: Handle 'response' of type CreateInventoryAdjustmentReasonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateInventoryAdjustmentReasonOperationRequest](src/Square/Requests/Inventory/CreateInventoryAdjustmentReasonOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateInventoryAdjustmentReasonResponse](src/Square/Models/CreateInventoryAdjustmentReasonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteInventoryAdjustmentReasonResponse&gt; DeleteInventoryAdjustmentReason(DeleteInventoryAdjustmentReasonOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Soft deletes a custom inventory adjustment reason.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeleteInventoryAdjustmentReason(
        new DeleteInventoryAdjustmentReasonOperationRequest
        {
            Body = new DeleteInventoryAdjustmentReasonRequest
            {
                ReasonId = new InventoryAdjustmentReasonId { Type = InventoryAdjustmentReasonIdType.Received },
            },
        });
    // TODO: Handle 'response' of type DeleteInventoryAdjustmentReasonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteInventoryAdjustmentReasonOperationRequest](src/Square/Requests/Inventory/DeleteInventoryAdjustmentReasonOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteInventoryAdjustmentReasonResponse](src/Square/Models/DeleteInventoryAdjustmentReasonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchChangeInventoryResponse&gt; DeprecatedBatchChangeInventory(DeprecatedBatchChangeInventoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated version of [BatchChangeInventory](api-endpoint:Inventory-BatchChangeInventory) after the endpoint URL
is updated to conform to the standard convention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeprecatedBatchChangeInventory(new DeprecatedBatchChangeInventoryRequest
    {
        Body = new BatchChangeInventoryRequest { IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type BatchChangeInventoryResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeprecatedBatchChangeInventoryRequest](src/Square/Requests/Inventory/DeprecatedBatchChangeInventoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchChangeInventoryResponse](src/Square/Models/BatchChangeInventoryResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchRetrieveInventoryChangesResponse&gt; DeprecatedBatchRetrieveInventoryChanges(DeprecatedBatchRetrieveInventoryChangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated version of [BatchRetrieveInventoryChanges](api-endpoint:Inventory-BatchRetrieveInventoryChanges) after the endpoint URL
is updated to conform to the standard convention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeprecatedBatchRetrieveInventoryChanges(
        new DeprecatedBatchRetrieveInventoryChangesRequest { Body = new BatchRetrieveInventoryChangesRequest() });
    // TODO: Handle 'response' of type BatchRetrieveInventoryChangesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeprecatedBatchRetrieveInventoryChangesRequest](src/Square/Requests/Inventory/DeprecatedBatchRetrieveInventoryChangesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveInventoryChangesResponse](src/Square/Models/BatchRetrieveInventoryChangesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchRetrieveInventoryCountsResponse&gt; DeprecatedBatchRetrieveInventoryCounts(DeprecatedBatchRetrieveInventoryCountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated version of [BatchRetrieveInventoryCounts](api-endpoint:Inventory-BatchRetrieveInventoryCounts) after the endpoint URL
is updated to conform to the standard convention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeprecatedBatchRetrieveInventoryCounts(
        new DeprecatedBatchRetrieveInventoryCountsRequest { Body = new BatchRetrieveInventoryCountsRequest() });
    // TODO: Handle 'response' of type BatchRetrieveInventoryCountsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeprecatedBatchRetrieveInventoryCountsRequest](src/Square/Requests/Inventory/DeprecatedBatchRetrieveInventoryCountsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveInventoryCountsResponse](src/Square/Models/BatchRetrieveInventoryCountsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryAdjustmentResponse&gt; DeprecatedRetrieveInventoryAdjustment(DeprecatedRetrieveInventoryAdjustmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated version of [RetrieveInventoryAdjustment](api-endpoint:Inventory-RetrieveInventoryAdjustment) after the endpoint URL
is updated to conform to the standard convention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeprecatedRetrieveInventoryAdjustment(
        new DeprecatedRetrieveInventoryAdjustmentRequest { AdjustmentId = "some example string" });
    // TODO: Handle 'response' of type RetrieveInventoryAdjustmentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeprecatedRetrieveInventoryAdjustmentRequest](src/Square/Requests/Inventory/DeprecatedRetrieveInventoryAdjustmentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryAdjustmentResponse](src/Square/Models/RetrieveInventoryAdjustmentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryPhysicalCountResponse&gt; DeprecatedRetrieveInventoryPhysicalCount(DeprecatedRetrieveInventoryPhysicalCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated version of [RetrieveInventoryPhysicalCount](api-endpoint:Inventory-RetrieveInventoryPhysicalCount) after the endpoint URL
is updated to conform to the standard convention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.DeprecatedRetrieveInventoryPhysicalCount(
        new DeprecatedRetrieveInventoryPhysicalCountRequest { PhysicalCountId = "some example string" });
    // TODO: Handle 'response' of type RetrieveInventoryPhysicalCountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeprecatedRetrieveInventoryPhysicalCountRequest](src/Square/Requests/Inventory/DeprecatedRetrieveInventoryPhysicalCountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryPhysicalCountResponse](src/Square/Models/RetrieveInventoryPhysicalCountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListInventoryAdjustmentReasonsResponse&gt; ListInventoryAdjustmentReasons(ListInventoryAdjustmentReasonsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the standard and custom inventory adjustment reasons available
to the seller.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.ListInventoryAdjustmentReasons(new ListInventoryAdjustmentReasonsRequest());
    // TODO: Handle 'response' of type ListInventoryAdjustmentReasonsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListInventoryAdjustmentReasonsRequest](src/Square/Requests/Inventory/ListInventoryAdjustmentReasonsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListInventoryAdjustmentReasonsResponse](src/Square/Models/ListInventoryAdjustmentReasonsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RestoreInventoryAdjustmentReasonResponse&gt; RestoreInventoryAdjustmentReason(RestoreInventoryAdjustmentReasonOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Restores a soft-deleted custom inventory adjustment reason.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RestoreInventoryAdjustmentReason(
        new RestoreInventoryAdjustmentReasonOperationRequest
        {
            Body = new RestoreInventoryAdjustmentReasonRequest
            {
                ReasonId = new InventoryAdjustmentReasonId { Type = InventoryAdjustmentReasonIdType.Received },
            },
        });
    // TODO: Handle 'response' of type RestoreInventoryAdjustmentReasonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RestoreInventoryAdjustmentReasonOperationRequest](src/Square/Requests/Inventory/RestoreInventoryAdjustmentReasonOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RestoreInventoryAdjustmentReasonResponse](src/Square/Models/RestoreInventoryAdjustmentReasonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryAdjustmentResponse&gt; RetrieveInventoryAdjustment(RetrieveInventoryAdjustmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [InventoryAdjustment](entity:InventoryAdjustment) object
with the provided `adjustment_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RetrieveInventoryAdjustment(new RetrieveInventoryAdjustmentRequest
    {
        AdjustmentId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveInventoryAdjustmentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveInventoryAdjustmentRequest](src/Square/Requests/Inventory/RetrieveInventoryAdjustmentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryAdjustmentResponse](src/Square/Models/RetrieveInventoryAdjustmentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryAdjustmentReasonResponse&gt; RetrieveInventoryAdjustmentReason(RetrieveInventoryAdjustmentReasonOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the inventory adjustment reason identified by the provided
`reason_id`. Deleted custom reasons can be retrieved by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RetrieveInventoryAdjustmentReason(
        new RetrieveInventoryAdjustmentReasonOperationRequest
        {
            Body = new RetrieveInventoryAdjustmentReasonRequest
            {
                ReasonId = new InventoryAdjustmentReasonId { Type = InventoryAdjustmentReasonIdType.Received },
            },
        });
    // TODO: Handle 'response' of type RetrieveInventoryAdjustmentReasonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveInventoryAdjustmentReasonOperationRequest](src/Square/Requests/Inventory/RetrieveInventoryAdjustmentReasonOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryAdjustmentReasonResponse](src/Square/Models/RetrieveInventoryAdjustmentReasonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryChangesResponse&gt; RetrieveInventoryChanges(RetrieveInventoryChangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a set of physical counts and inventory adjustments for the
provided [CatalogObject](entity:CatalogObject) at the requested
[Location](entity:Location)s.

You can achieve the same result by calling [BatchRetrieveInventoryChanges](api-endpoint:Inventory-BatchRetrieveInventoryChanges)
and having the `catalog_object_ids` list contain a single element of the `CatalogObject` ID.

Results are paginated and sorted in descending order according to their
`occurred_at` timestamp (newest first).

There are no limits on how far back the caller can page. This endpoint can be
used to display recent changes for a specific item. For more
sophisticated queries, use a batch endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RetrieveInventoryChanges(new RetrieveInventoryChangesRequest
    {
        CatalogObjectId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveInventoryChangesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveInventoryChangesRequest](src/Square/Requests/Inventory/RetrieveInventoryChangesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryChangesResponse](src/Square/Models/RetrieveInventoryChangesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryCountResponse&gt; RetrieveInventoryCount(RetrieveInventoryCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current calculated stock count for a given
[CatalogObject](entity:CatalogObject) at a given set of
[Location](entity:Location)s. Responses are paginated and unsorted.
For more sophisticated queries, use a batch endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RetrieveInventoryCount(new RetrieveInventoryCountRequest
    {
        CatalogObjectId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveInventoryCountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveInventoryCountRequest](src/Square/Requests/Inventory/RetrieveInventoryCountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryCountResponse](src/Square/Models/RetrieveInventoryCountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveInventoryPhysicalCountResponse&gt; RetrieveInventoryPhysicalCount(RetrieveInventoryPhysicalCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the [InventoryPhysicalCount](entity:InventoryPhysicalCount)
object with the provided `physical_count_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.RetrieveInventoryPhysicalCount(new RetrieveInventoryPhysicalCountRequest
    {
        PhysicalCountId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveInventoryPhysicalCountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveInventoryPhysicalCountRequest](src/Square/Requests/Inventory/RetrieveInventoryPhysicalCountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveInventoryPhysicalCountResponse](src/Square/Models/RetrieveInventoryPhysicalCountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateInventoryAdjustmentResponse&gt; UpdateInventoryAdjustment(UpdateInventoryAdjustmentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Applies an update to the provided adjustment.

On success: returns the newly updated adjustment.
On failure: returns a list of related errors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.UpdateInventoryAdjustment(new UpdateInventoryAdjustmentOperationRequest
    {
        Body = new UpdateInventoryAdjustmentRequest
        {
            IdempotencyKey = "some example string",
            Adjustment = new InventoryAdjustment(),
        },
    });
    // TODO: Handle 'response' of type UpdateInventoryAdjustmentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateInventoryAdjustmentOperationRequest](src/Square/Requests/Inventory/UpdateInventoryAdjustmentOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateInventoryAdjustmentResponse](src/Square/Models/UpdateInventoryAdjustmentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateInventoryAdjustmentReasonResponse&gt; UpdateInventoryAdjustmentReason(UpdateInventoryAdjustmentReasonOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a custom inventory adjustment reason.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Inventory.UpdateInventoryAdjustmentReason(
        new UpdateInventoryAdjustmentReasonOperationRequest
        {
            Body = new UpdateInventoryAdjustmentReasonRequest
            {
                ReasonId = new InventoryAdjustmentReasonId { Type = InventoryAdjustmentReasonIdType.Received },
                AdjustmentReason = new InventoryAdjustmentReason
                {
                    Id = new InventoryAdjustmentReasonId { Type = InventoryAdjustmentReasonIdType.Received },
                },
            },
        });
    // TODO: Handle 'response' of type UpdateInventoryAdjustmentReasonResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateInventoryAdjustmentReasonOperationRequest](src/Square/Requests/Inventory/UpdateInventoryAdjustmentReasonOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateInventoryAdjustmentReasonResponse](src/Square/Models/UpdateInventoryAdjustmentReasonResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Invoices

> Source: [Invoices](src/Square/Api/Invoices.cs)

<details>
<summary><code>Task&lt;CancelInvoiceResponse&gt; CancelInvoice(CancelInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an invoice. The seller cannot collect payments for 
the canceled invoice.

You cannot cancel an invoice in the `DRAFT` state or in a terminal state: `PAID`, `REFUNDED`, `CANCELED`, or `FAILED`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.CancelInvoice(new CancelInvoiceOperationRequest
    {
        InvoiceId = "some example string",
        Body = new CancelInvoiceRequest { Version = 1 },
    });
    // TODO: Handle 'response' of type CancelInvoiceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelInvoiceOperationRequest](src/Square/Requests/Invoices/CancelInvoiceOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelInvoiceResponse](src/Square/Models/CancelInvoiceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateInvoiceResponse&gt; CreateInvoice(CreateInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a draft [invoice](entity:Invoice) 
for an order created using the Orders API.

A draft invoice remains in your account and no action is taken. 
You must publish the invoice before Square can process it (send it to the customer's email address or charge the customer’s card on file).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.CreateInvoice(new CreateInvoiceOperationRequest
    {
        Body = new CreateInvoiceRequest { Invoice = new Invoice() },
    });
    // TODO: Handle 'response' of type CreateInvoiceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateInvoiceOperationRequest](src/Square/Requests/Invoices/CreateInvoiceOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateInvoiceResponse](src/Square/Models/CreateInvoiceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateInvoiceAttachmentResponse&gt; CreateInvoiceAttachment(CreateInvoiceAttachmentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Uploads a file and attaches it to an invoice. This endpoint accepts HTTP multipart/form-data file uploads
with a JSON `request` part and a `file` part. The `file` part must be a `readable stream` that contains a file
in a supported format: GIF, JPEG, PNG, TIFF, BMP, or PDF.

Invoices can have up to 10 attachments with a total file size of 25 MB. Attachments can be added only to invoices
in the `DRAFT`, `SCHEDULED`, `UNPAID`, or `PARTIALLY_PAID` state.

__NOTE:__ When testing in the Sandbox environment, the total file size is limited to 1 KB.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.CreateInvoiceAttachment(new CreateInvoiceAttachmentOperationRequest
    {
        InvoiceId = "some example string",
    });
    // TODO: Handle 'response' of type CreateInvoiceAttachmentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateInvoiceAttachmentOperationRequest](src/Square/Requests/Invoices/CreateInvoiceAttachmentOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateInvoiceAttachmentResponse](src/Square/Models/CreateInvoiceAttachmentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteInvoiceResponse&gt; DeleteInvoice(DeleteInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the specified invoice. When an invoice is deleted, the 
associated order status changes to CANCELED. You can only delete a draft 
invoice (you cannot delete a published invoice, including one that is scheduled for processing).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.DeleteInvoice(new DeleteInvoiceRequest { InvoiceId = "some example string" });
    // TODO: Handle 'response' of type DeleteInvoiceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteInvoiceRequest](src/Square/Requests/Invoices/DeleteInvoiceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteInvoiceResponse](src/Square/Models/DeleteInvoiceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteInvoiceAttachmentResponse&gt; DeleteInvoiceAttachment(DeleteInvoiceAttachmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes an attachment from an invoice and permanently deletes the file. Attachments can be removed only
from invoices in the `DRAFT`, `SCHEDULED`, `UNPAID`, or `PARTIALLY_PAID` state.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.DeleteInvoiceAttachment(new DeleteInvoiceAttachmentRequest
    {
        InvoiceId = "some example string",
        AttachmentId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteInvoiceAttachmentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteInvoiceAttachmentRequest](src/Square/Requests/Invoices/DeleteInvoiceAttachmentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteInvoiceAttachmentResponse](src/Square/Models/DeleteInvoiceAttachmentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetInvoiceResponse&gt; GetInvoice(GetInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an invoice by invoice ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.GetInvoice(new GetInvoiceRequest { InvoiceId = "some example string" });
    // TODO: Handle 'response' of type GetInvoiceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInvoiceRequest](src/Square/Requests/Invoices/GetInvoiceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetInvoiceResponse](src/Square/Models/GetInvoiceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListInvoicesResponse&gt; ListInvoices(ListInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of invoices for a given location. The response 
is paginated. If truncated, the response includes a `cursor` that you    
use in a subsequent request to retrieve the next set of invoices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.ListInvoices(new ListInvoicesRequest { LocationId = "some example string" });
    // TODO: Handle 'response' of type ListInvoicesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListInvoicesRequest](src/Square/Requests/Invoices/ListInvoicesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListInvoicesResponse](src/Square/Models/ListInvoicesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PublishInvoiceResponse&gt; PublishInvoice(PublishInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Publishes the specified draft invoice. 

After an invoice is published, Square 
follows up based on the invoice configuration. For example, Square 
sends the invoice to the customer's email address, charges the customer's card on file, or does 
nothing. Square also makes the invoice available on a Square-hosted invoice page. 

The invoice `status` also changes from `DRAFT` to a status 
based on the invoice configuration. For example, the status changes to `UNPAID` if 
Square emails the invoice or `PARTIALLY_PAID` if Square charges a card on file for a portion of the 
invoice amount.

In addition to the required `ORDERS_WRITE` and `INVOICES_WRITE` permissions, `CUSTOMERS_READ`
and `PAYMENTS_WRITE` are required when publishing invoices configured for card-on-file payments.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.PublishInvoice(new PublishInvoiceOperationRequest
    {
        InvoiceId = "some example string",
        Body = new PublishInvoiceRequest { Version = 1 },
    });
    // TODO: Handle 'response' of type PublishInvoiceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PublishInvoiceOperationRequest](src/Square/Requests/Invoices/PublishInvoiceOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublishInvoiceResponse](src/Square/Models/PublishInvoiceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchInvoicesResponse&gt; SearchInvoices(SearchInvoicesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for invoices from a location specified in 
the filter. You can optionally specify customers in the filter for whom to 
retrieve invoices. In the current implementation, you can only specify one location and 
optionally one customer.

The response is paginated. If truncated, the response includes a `cursor` 
that you use in a subsequent request to retrieve the next set of invoices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.SearchInvoices(new SearchInvoicesOperationRequest
    {
        Body = new SearchInvoicesRequest
        {
            Query = new InvoiceQuery { Filter = new InvoiceFilter { LocationIds = ["some example string"] } },
        },
    });
    // TODO: Handle 'response' of type SearchInvoicesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchInvoicesOperationRequest](src/Square/Requests/Invoices/SearchInvoicesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchInvoicesResponse](src/Square/Models/SearchInvoicesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateInvoiceResponse&gt; UpdateInvoice(UpdateInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an invoice. This endpoint supports sparse updates, so you only need
to specify the fields you want to change along with the required `version` field.
Some restrictions apply to updating invoices. For example, you cannot change the
`order_id` or `location_id` field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.UpdateInvoice(new UpdateInvoiceOperationRequest
    {
        InvoiceId = "some example string",
        Body = new UpdateInvoiceRequest { Invoice = new Invoice() },
    });
    // TODO: Handle 'response' of type UpdateInvoiceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateInvoiceOperationRequest](src/Square/Requests/Invoices/UpdateInvoiceOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateInvoiceResponse](src/Square/Models/UpdateInvoiceResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Labor

> Source: [Labor](src/Square/Api/Labor.cs)

<details>
<summary><code>Task&lt;BulkPublishScheduledShiftsResponse&gt; BulkPublishScheduledShifts(BulkPublishScheduledShiftsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Publishes 1 - 100 scheduled shifts. This endpoint takes a map of individual publish
requests and returns a map of responses. When a scheduled shift is published, Square keeps
the `draft_shift_details` field as is and copies it to the `published_shift_details` field.

The minimum `start_at` and maximum `end_at` timestamps of all shifts in a
`BulkPublishScheduledShifts` request must fall within a two-week period.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.BulkPublishScheduledShifts(new BulkPublishScheduledShiftsOperationRequest
    {
        Body = new BulkPublishScheduledShiftsRequest
        {
            ScheduledShifts = new Dictionary<string, BulkPublishScheduledShiftsData>
            {
                ["key"] = new BulkPublishScheduledShiftsData(),
            },
        },
    });
    // TODO: Handle 'response' of type BulkPublishScheduledShiftsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkPublishScheduledShiftsOperationRequest](src/Square/Requests/Labor/BulkPublishScheduledShiftsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkPublishScheduledShiftsResponse](src/Square/Models/BulkPublishScheduledShiftsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateBreakTypeResponse&gt; CreateBreakType(CreateBreakTypeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new `BreakType`.

A `BreakType` is a template for creating `Break` objects.
You must provide the following values in your request to this
endpoint:

- `location_id`
- `break_name`
- `expected_duration`
- `is_paid`

You can only have three `BreakType` instances per location. If you attempt to add a fourth
`BreakType` for a location, an `INVALID_REQUEST_ERROR` "Exceeded limit of 3 breaks per location."
is returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.CreateBreakType(new CreateBreakTypeOperationRequest
    {
        Body = new CreateBreakTypeRequest
        {
            BreakType = new BreakType
            {
                LocationId = "some example string",
                BreakName = "some example string",
                ExpectedDuration = "some example string",
                IsPaid = true,
            },
        },
    });
    // TODO: Handle 'response' of type CreateBreakTypeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateBreakTypeOperationRequest](src/Square/Requests/Labor/CreateBreakTypeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateBreakTypeResponse](src/Square/Models/CreateBreakTypeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateScheduledShiftResponse&gt; CreateScheduledShift(CreateScheduledShiftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a scheduled shift by providing draft shift details such as job ID,
team member assignment, and start and end times.

The following `draft_shift_details` fields are required:
- `location_id`
- `job_id`
- `start_at`
- `end_at`

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.CreateScheduledShift(new CreateScheduledShiftOperationRequest
    {
        Body = new CreateScheduledShiftRequest { ScheduledShift = new ScheduledShift() },
    });
    // TODO: Handle 'response' of type CreateScheduledShiftResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateScheduledShiftOperationRequest](src/Square/Requests/Labor/CreateScheduledShiftOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateScheduledShiftResponse](src/Square/Models/CreateScheduledShiftResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateShiftResponse&gt; CreateShift(CreateShiftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new `Shift`.

A `Shift` represents a complete workday for a single team member.
You must provide the following values in your request to this
endpoint:

- `location_id`
- `team_member_id`
- `start_at`

An attempt to create a new `Shift` can result in a `BAD_REQUEST` error when:
- The `status` of the new `Shift` is `OPEN` and the team member has another
shift with an `OPEN` status.
- The `start_at` date is in the future.
- The `start_at` or `end_at` date overlaps another shift for the same team member.
- The `Break` instances are set in the request and a break `start_at`
is before the `Shift.start_at`, a break `end_at` is after
the `Shift.end_at`, or both.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.CreateShift(new CreateShiftOperationRequest
    {
        Body = new CreateShiftRequest
        {
            Shift = new Shift { LocationId = "some example string", StartAt = "some example string" },
        },
    });
    // TODO: Handle 'response' of type CreateShiftResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateShiftOperationRequest](src/Square/Requests/Labor/CreateShiftOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateShiftResponse](src/Square/Models/CreateShiftResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTimecardResponse&gt; CreateTimecard(CreateTimecardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new `Timecard`.

A `Timecard` represents a complete workday for a single team member.
You must provide the following values in your request to this
endpoint:

- `location_id`
- `team_member_id`
- `start_at`

An attempt to create a new `Timecard` can result in a `BAD_REQUEST` error when:
- The `status` of the new `Timecard` is `OPEN` and the team member has another
timecard with an `OPEN` status.
- The `start_at` date is in the future.
- The `start_at` or `end_at` date overlaps another timecard for the same team member.
- The `Break` instances are set in the request and a break `start_at`
is before the `Timecard.start_at`, a break `end_at` is after
the `Timecard.end_at`, or both.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.CreateTimecard(new CreateTimecardOperationRequest
    {
        Body = new CreateTimecardRequest
        {
            Timecard = new Timecard
            {
                LocationId = "some example string",
                StartAt = "some example string",
                TeamMemberId = "some example string",
            },
        },
    });
    // TODO: Handle 'response' of type CreateTimecardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTimecardOperationRequest](src/Square/Requests/Labor/CreateTimecardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTimecardResponse](src/Square/Models/CreateTimecardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteBreakTypeResponse&gt; DeleteBreakType(DeleteBreakTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an existing `BreakType`.

A `BreakType` can be deleted even if it is referenced from a `Shift`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.DeleteBreakType(new DeleteBreakTypeRequest { Id = "some example string" });
    // TODO: Handle 'response' of type DeleteBreakTypeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteBreakTypeRequest](src/Square/Requests/Labor/DeleteBreakTypeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteBreakTypeResponse](src/Square/Models/DeleteBreakTypeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteShiftResponse&gt; DeleteShift(DeleteShiftRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a `Shift`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.DeleteShift(new DeleteShiftRequest { Id = "some example string" });
    // TODO: Handle 'response' of type DeleteShiftResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteShiftRequest](src/Square/Requests/Labor/DeleteShiftRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteShiftResponse](src/Square/Models/DeleteShiftResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteTimecardResponse&gt; DeleteTimecard(DeleteTimecardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a `Timecard`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.DeleteTimecard(new DeleteTimecardRequest { Id = "some example string" });
    // TODO: Handle 'response' of type DeleteTimecardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTimecardRequest](src/Square/Requests/Labor/DeleteTimecardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteTimecardResponse](src/Square/Models/DeleteTimecardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetBreakTypeResponse&gt; GetBreakType(GetBreakTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single `BreakType` specified by `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.GetBreakType(new GetBreakTypeRequest { Id = "some example string" });
    // TODO: Handle 'response' of type GetBreakTypeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBreakTypeRequest](src/Square/Requests/Labor/GetBreakTypeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetBreakTypeResponse](src/Square/Models/GetBreakTypeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetEmployeeWageResponse&gt; GetEmployeeWage(GetEmployeeWageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single `EmployeeWage` specified by `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.GetEmployeeWage(new GetEmployeeWageRequest { Id = "some example string" });
    // TODO: Handle 'response' of type GetEmployeeWageResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEmployeeWageRequest](src/Square/Requests/Labor/GetEmployeeWageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetEmployeeWageResponse](src/Square/Models/GetEmployeeWageResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetShiftResponse&gt; GetShift(GetShiftRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single `Shift` specified by `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.GetShift(new GetShiftRequest { Id = "some example string" });
    // TODO: Handle 'response' of type GetShiftResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetShiftRequest](src/Square/Requests/Labor/GetShiftRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetShiftResponse](src/Square/Models/GetShiftResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTeamMemberWageResponse&gt; GetTeamMemberWage(GetTeamMemberWageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single `TeamMemberWage` specified by `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.GetTeamMemberWage(new GetTeamMemberWageRequest { Id = "some example string" });
    // TODO: Handle 'response' of type GetTeamMemberWageResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTeamMemberWageRequest](src/Square/Requests/Labor/GetTeamMemberWageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTeamMemberWageResponse](src/Square/Models/GetTeamMemberWageResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListBreakTypesResponse&gt; ListBreakTypes(ListBreakTypesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `BreakType` instances for a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.ListBreakTypes(new ListBreakTypesRequest());
    // TODO: Handle 'response' of type ListBreakTypesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListBreakTypesRequest](src/Square/Requests/Labor/ListBreakTypesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListBreakTypesResponse](src/Square/Models/ListBreakTypesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListEmployeeWagesResponse&gt; ListEmployeeWages(ListEmployeeWagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `EmployeeWage` instances for a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.ListEmployeeWages(new ListEmployeeWagesRequest());
    // TODO: Handle 'response' of type ListEmployeeWagesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListEmployeeWagesRequest](src/Square/Requests/Labor/ListEmployeeWagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListEmployeeWagesResponse](src/Square/Models/ListEmployeeWagesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListTeamMemberWagesResponse&gt; ListTeamMemberWages(ListTeamMemberWagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `TeamMemberWage` instances for a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.ListTeamMemberWages(new ListTeamMemberWagesRequest());
    // TODO: Handle 'response' of type ListTeamMemberWagesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListTeamMemberWagesRequest](src/Square/Requests/Labor/ListTeamMemberWagesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListTeamMemberWagesResponse](src/Square/Models/ListTeamMemberWagesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListWorkweekConfigsResponse&gt; ListWorkweekConfigs(ListWorkweekConfigsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of `WorkweekConfig` instances for a business.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.ListWorkweekConfigs(new ListWorkweekConfigsRequest());
    // TODO: Handle 'response' of type ListWorkweekConfigsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListWorkweekConfigsRequest](src/Square/Requests/Labor/ListWorkweekConfigsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListWorkweekConfigsResponse](src/Square/Models/ListWorkweekConfigsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PublishScheduledShiftResponse&gt; PublishScheduledShift(PublishScheduledShiftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Publishes a scheduled shift. When a scheduled shift is published, Square keeps the
`draft_shift_details` field as is and copies it to the `published_shift_details` field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.PublishScheduledShift(new PublishScheduledShiftOperationRequest
    {
        Id = "some example string",
        Body = new PublishScheduledShiftRequest { IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type PublishScheduledShiftResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PublishScheduledShiftOperationRequest](src/Square/Requests/Labor/PublishScheduledShiftOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublishScheduledShiftResponse](src/Square/Models/PublishScheduledShiftResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveScheduledShiftResponse&gt; RetrieveScheduledShift(RetrieveScheduledShiftRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a scheduled shift by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.RetrieveScheduledShift(new RetrieveScheduledShiftRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveScheduledShiftResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveScheduledShiftRequest](src/Square/Requests/Labor/RetrieveScheduledShiftRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveScheduledShiftResponse](src/Square/Models/RetrieveScheduledShiftResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveTimecardResponse&gt; RetrieveTimecard(RetrieveTimecardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single `Timecard` specified by `id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.RetrieveTimecard(new RetrieveTimecardRequest { Id = "some example string" });
    // TODO: Handle 'response' of type RetrieveTimecardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveTimecardRequest](src/Square/Requests/Labor/RetrieveTimecardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveTimecardResponse](src/Square/Models/RetrieveTimecardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchScheduledShiftsResponse&gt; SearchScheduledShifts(SearchScheduledShiftsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of scheduled shifts, with optional filter and sort settings.
By default, results are sorted by `start_at` in ascending order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.SearchScheduledShifts(new SearchScheduledShiftsOperationRequest
    {
        Body = new SearchScheduledShiftsRequest(),
    });
    // TODO: Handle 'response' of type SearchScheduledShiftsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchScheduledShiftsOperationRequest](src/Square/Requests/Labor/SearchScheduledShiftsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchScheduledShiftsResponse](src/Square/Models/SearchScheduledShiftsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchShiftsResponse&gt; SearchShifts(SearchShiftsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `Shift` records for a business.
The list to be returned can be filtered by:
- Location IDs
- Team member IDs
- Shift status (`OPEN` or `CLOSED`)
- Shift start
- Shift end
- Workday details

The list can be sorted by:
- `START_AT`
- `END_AT`
- `CREATED_AT`
- `UPDATED_AT`

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.SearchShifts(new SearchShiftsOperationRequest
    {
        Body = new SearchShiftsRequest(),
    });
    // TODO: Handle 'response' of type SearchShiftsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchShiftsOperationRequest](src/Square/Requests/Labor/SearchShiftsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchShiftsResponse](src/Square/Models/SearchShiftsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchTimecardsResponse&gt; SearchTimecards(SearchTimecardsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `Timecard` records for a business.
The list to be returned can be filtered by:
- Location IDs
- Team member IDs
- Timecard status (`OPEN` or `CLOSED`)
- Timecard start
- Timecard end
- Workday details

The list can be sorted by:
- `START_AT`
- `END_AT`
- `CREATED_AT`
- `UPDATED_AT`

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.SearchTimecards(new SearchTimecardsOperationRequest
    {
        Body = new SearchTimecardsRequest(),
    });
    // TODO: Handle 'response' of type SearchTimecardsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchTimecardsOperationRequest](src/Square/Requests/Labor/SearchTimecardsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchTimecardsResponse](src/Square/Models/SearchTimecardsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateBreakTypeResponse&gt; UpdateBreakType(UpdateBreakTypeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing `BreakType`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.UpdateBreakType(new UpdateBreakTypeOperationRequest
    {
        Id = "some example string",
        Body = new UpdateBreakTypeRequest
        {
            BreakType = new BreakType
            {
                LocationId = "some example string",
                BreakName = "some example string",
                ExpectedDuration = "some example string",
                IsPaid = true,
            },
        },
    });
    // TODO: Handle 'response' of type UpdateBreakTypeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateBreakTypeOperationRequest](src/Square/Requests/Labor/UpdateBreakTypeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateBreakTypeResponse](src/Square/Models/UpdateBreakTypeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateScheduledShiftResponse&gt; UpdateScheduledShift(UpdateScheduledShiftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the draft shift details for a scheduled shift. This endpoint supports
sparse updates, so only new, changed, or removed fields are required in the request.
You must publish the shift to make updates public.

You can make the following updates to `draft_shift_details`:
- Change the `location_id`, `job_id`, `start_at`, and `end_at` fields.
- Add, change, or clear the `team_member_id` and `notes` fields. To clear these fields,
set the value to null.
- Change the `is_deleted` field. To delete a scheduled shift, set `is_deleted` to true
and then publish the shift.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.UpdateScheduledShift(new UpdateScheduledShiftOperationRequest
    {
        Id = "some example string",
        Body = new UpdateScheduledShiftRequest { ScheduledShift = new ScheduledShift() },
    });
    // TODO: Handle 'response' of type UpdateScheduledShiftResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateScheduledShiftOperationRequest](src/Square/Requests/Labor/UpdateScheduledShiftOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateScheduledShiftResponse](src/Square/Models/UpdateScheduledShiftResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateShiftResponse&gt; UpdateShift(UpdateShiftOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing `Shift`.

When adding a `Break` to a `Shift`, any earlier `Break` instances in the `Shift` have
the `end_at` property set to a valid RFC-3339 datetime string.

When closing a `Shift`, all `Break` instances in the `Shift` must be complete with `end_at`
set on each `Break`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.UpdateShift(new UpdateShiftOperationRequest
    {
        Id = "some example string",
        Body = new UpdateShiftRequest
        {
            Shift = new Shift { LocationId = "some example string", StartAt = "some example string" },
        },
    });
    // TODO: Handle 'response' of type UpdateShiftResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateShiftOperationRequest](src/Square/Requests/Labor/UpdateShiftOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateShiftResponse](src/Square/Models/UpdateShiftResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateTimecardResponse&gt; UpdateTimecard(UpdateTimecardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing `Timecard`.

When adding a `Break` to a `Timecard`, any earlier `Break` instances in the `Timecard` have
the `end_at` property set to a valid RFC-3339 datetime string.

When closing a `Timecard`, all `Break` instances in the `Timecard` must be complete with `end_at`
set on each `Break`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.UpdateTimecard(new UpdateTimecardOperationRequest
    {
        Id = "some example string",
        Body = new UpdateTimecardRequest
        {
            Timecard = new Timecard
            {
                LocationId = "some example string",
                StartAt = "some example string",
                TeamMemberId = "some example string",
            },
        },
    });
    // TODO: Handle 'response' of type UpdateTimecardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTimecardOperationRequest](src/Square/Requests/Labor/UpdateTimecardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateTimecardResponse](src/Square/Models/UpdateTimecardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateWorkweekConfigResponse&gt; UpdateWorkweekConfig(UpdateWorkweekConfigOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a `WorkweekConfig`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Labor.UpdateWorkweekConfig(new UpdateWorkweekConfigOperationRequest
    {
        Id = "some example string",
        Body = new UpdateWorkweekConfigRequest
        {
            WorkweekConfig = new WorkweekConfig
            {
                StartOfWeek = Weekday.Mon,
                StartOfDayLocalTime = "some example string",
            },
        },
    });
    // TODO: Handle 'response' of type UpdateWorkweekConfigResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateWorkweekConfigOperationRequest](src/Square/Requests/Labor/UpdateWorkweekConfigOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateWorkweekConfigResponse](src/Square/Models/UpdateWorkweekConfigResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LocationCustomAttributes

> Source: [LocationCustomAttributes](src/Square/Api/LocationCustomAttributes.cs)

<details>
<summary><code>Task&lt;BulkDeleteLocationCustomAttributesResponse&gt; BulkDeleteLocationCustomAttributes(BulkDeleteLocationCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes [custom attributes](entity:CustomAttribute) for locations as a bulk operation.
To delete a custom attribute owned by another application, the `visibility` setting must be
`VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.BulkDeleteLocationCustomAttributes(
        new BulkDeleteLocationCustomAttributesOperationRequest
        {
            Body = new BulkDeleteLocationCustomAttributesRequest
            {
                Values = new Dictionary<string, BulkDeleteLocationCustomAttributesRequestLocationCustomAttributeDeleteRequest>
                {
                    ["key"] = new BulkDeleteLocationCustomAttributesRequestLocationCustomAttributeDeleteRequest(),
                },
            },
        });
    // TODO: Handle 'response' of type BulkDeleteLocationCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkDeleteLocationCustomAttributesOperationRequest](src/Square/Requests/LocationCustomAttributes/BulkDeleteLocationCustomAttributesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkDeleteLocationCustomAttributesResponse](src/Square/Models/BulkDeleteLocationCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkUpsertLocationCustomAttributesResponse&gt; BulkUpsertLocationCustomAttributes(BulkUpsertLocationCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates [custom attributes](entity:CustomAttribute) for locations as a bulk operation.
Use this endpoint to set the value of one or more custom attributes for one or more locations.
A custom attribute is based on a custom attribute definition in a Square seller account, which is
created using the [CreateLocationCustomAttributeDefinition](api-endpoint:LocationCustomAttributes-CreateLocationCustomAttributeDefinition) endpoint.
This `BulkUpsertLocationCustomAttributes` endpoint accepts a map of 1 to 25 individual upsert
requests and returns a map of individual upsert responses. Each upsert request has a unique ID
and provides a location ID and custom attribute. Each upsert response is returned with the ID
of the corresponding request.
To create or update a custom attribute owned by another application, the `visibility` setting
must be `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.BulkUpsertLocationCustomAttributes(
        new BulkUpsertLocationCustomAttributesOperationRequest
        {
            Body = new BulkUpsertLocationCustomAttributesRequest
            {
                Values = new Dictionary<string, BulkUpsertLocationCustomAttributesRequestLocationCustomAttributeUpsertRequest>
                {
                    ["key"] = new BulkUpsertLocationCustomAttributesRequestLocationCustomAttributeUpsertRequest
                    {
                        LocationId = "some example string",
                        CustomAttribute = new CustomAttribute(),
                    },
                },
            },
        });
    // TODO: Handle 'response' of type BulkUpsertLocationCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkUpsertLocationCustomAttributesOperationRequest](src/Square/Requests/LocationCustomAttributes/BulkUpsertLocationCustomAttributesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkUpsertLocationCustomAttributesResponse](src/Square/Models/BulkUpsertLocationCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateLocationCustomAttributeDefinitionResponse&gt; CreateLocationCustomAttributeDefinition(CreateLocationCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a location-related [custom attribute definition](entity:CustomAttributeDefinition) for a Square seller account.
Use this endpoint to define a custom attribute that can be associated with locations.
A custom attribute definition specifies the `key`, `visibility`, `schema`, and other properties
for a custom attribute. After the definition is created, you can call
[UpsertLocationCustomAttribute](api-endpoint:LocationCustomAttributes-UpsertLocationCustomAttribute) or
[BulkUpsertLocationCustomAttributes](api-endpoint:LocationCustomAttributes-BulkUpsertLocationCustomAttributes)
to set the custom attribute for locations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.CreateLocationCustomAttributeDefinition(
        new CreateLocationCustomAttributeDefinitionOperationRequest
        {
            Body = new CreateLocationCustomAttributeDefinitionRequest
            {
                CustomAttributeDefinition = new CustomAttributeDefinition(),
            },
        });
    // TODO: Handle 'response' of type CreateLocationCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateLocationCustomAttributeDefinitionOperationRequest](src/Square/Requests/LocationCustomAttributes/CreateLocationCustomAttributeDefinitionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateLocationCustomAttributeDefinitionResponse](src/Square/Models/CreateLocationCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteLocationCustomAttributeResponse&gt; DeleteLocationCustomAttribute(DeleteLocationCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a [custom attribute](entity:CustomAttribute) associated with a location.
To delete a custom attribute owned by another application, the `visibility` setting must be
`VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.DeleteLocationCustomAttribute(
        new DeleteLocationCustomAttributeRequest { LocationId = "some example string", Key = "some example string" });
    // TODO: Handle 'response' of type DeleteLocationCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteLocationCustomAttributeRequest](src/Square/Requests/LocationCustomAttributes/DeleteLocationCustomAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteLocationCustomAttributeResponse](src/Square/Models/DeleteLocationCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteLocationCustomAttributeDefinitionResponse&gt; DeleteLocationCustomAttributeDefinition(DeleteLocationCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a location-related [custom attribute definition](entity:CustomAttributeDefinition) from a Square seller account.
Deleting a custom attribute definition also deletes the corresponding custom attribute from
all locations.
Only the definition owner can delete a custom attribute definition.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.DeleteLocationCustomAttributeDefinition(
        new DeleteLocationCustomAttributeDefinitionRequest { Key = "some example string" });
    // TODO: Handle 'response' of type DeleteLocationCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteLocationCustomAttributeDefinitionRequest](src/Square/Requests/LocationCustomAttributes/DeleteLocationCustomAttributeDefinitionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteLocationCustomAttributeDefinitionResponse](src/Square/Models/DeleteLocationCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListLocationCustomAttributeDefinitionsResponse&gt; ListLocationCustomAttributeDefinitions(ListLocationCustomAttributeDefinitionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the location-related [custom attribute definitions](entity:CustomAttributeDefinition) that belong to a Square seller account.
When all response pages are retrieved, the results include all custom attribute definitions
that are visible to the requesting application, including those that are created by other
applications and set to `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.ListLocationCustomAttributeDefinitions(
        new ListLocationCustomAttributeDefinitionsRequest());
    // TODO: Handle 'response' of type ListLocationCustomAttributeDefinitionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListLocationCustomAttributeDefinitionsRequest](src/Square/Requests/LocationCustomAttributes/ListLocationCustomAttributeDefinitionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListLocationCustomAttributeDefinitionsResponse](src/Square/Models/ListLocationCustomAttributeDefinitionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListLocationCustomAttributesResponse&gt; ListLocationCustomAttributes(ListLocationCustomAttributesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the [custom attributes](entity:CustomAttribute) associated with a location.
You can use the `with_definitions` query parameter to also retrieve custom attribute definitions
in the same call.
When all response pages are retrieved, the results include all custom attributes that are
visible to the requesting application, including those that are owned by other applications
and set to `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.ListLocationCustomAttributes(
        new ListLocationCustomAttributesRequest { LocationId = "some example string" });
    // TODO: Handle 'response' of type ListLocationCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListLocationCustomAttributesRequest](src/Square/Requests/LocationCustomAttributes/ListLocationCustomAttributesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListLocationCustomAttributesResponse](src/Square/Models/ListLocationCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLocationCustomAttributeResponse&gt; RetrieveLocationCustomAttribute(RetrieveLocationCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a [custom attribute](entity:CustomAttribute) associated with a location.
You can use the `with_definition` query parameter to also retrieve the custom attribute definition
in the same call.
To retrieve a custom attribute owned by another application, the `visibility` setting must be
`VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.RetrieveLocationCustomAttribute(
        new RetrieveLocationCustomAttributeRequest { LocationId = "some example string", Key = "some example string" });
    // TODO: Handle 'response' of type RetrieveLocationCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveLocationCustomAttributeRequest](src/Square/Requests/LocationCustomAttributes/RetrieveLocationCustomAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLocationCustomAttributeResponse](src/Square/Models/RetrieveLocationCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLocationCustomAttributeDefinitionResponse&gt; RetrieveLocationCustomAttributeDefinition(RetrieveLocationCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a location-related [custom attribute definition](entity:CustomAttributeDefinition) from a Square seller account.
To retrieve a custom attribute definition created by another application, the `visibility`
setting must be `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.RetrieveLocationCustomAttributeDefinition(
        new RetrieveLocationCustomAttributeDefinitionRequest { Key = "some example string" });
    // TODO: Handle 'response' of type RetrieveLocationCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveLocationCustomAttributeDefinitionRequest](src/Square/Requests/LocationCustomAttributes/RetrieveLocationCustomAttributeDefinitionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLocationCustomAttributeDefinitionResponse](src/Square/Models/RetrieveLocationCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateLocationCustomAttributeDefinitionResponse&gt; UpdateLocationCustomAttributeDefinition(UpdateLocationCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a location-related [custom attribute definition](entity:CustomAttributeDefinition) for a Square seller account.
Use this endpoint to update the following fields: `name`, `description`, `visibility`, or the
`schema` for a `Selection` data type.
Only the definition owner can update a custom attribute definition.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.UpdateLocationCustomAttributeDefinition(
        new UpdateLocationCustomAttributeDefinitionOperationRequest
        {
            Key = "some example string",
            Body = new UpdateLocationCustomAttributeDefinitionRequest
            {
                CustomAttributeDefinition = new CustomAttributeDefinition(),
            },
        });
    // TODO: Handle 'response' of type UpdateLocationCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateLocationCustomAttributeDefinitionOperationRequest](src/Square/Requests/LocationCustomAttributes/UpdateLocationCustomAttributeDefinitionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateLocationCustomAttributeDefinitionResponse](src/Square/Models/UpdateLocationCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpsertLocationCustomAttributeResponse&gt; UpsertLocationCustomAttribute(UpsertLocationCustomAttributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates a [custom attribute](entity:CustomAttribute) for a location.
Use this endpoint to set the value of a custom attribute for a specified location.
A custom attribute is based on a custom attribute definition in a Square seller account, which
is created using the [CreateLocationCustomAttributeDefinition](api-endpoint:LocationCustomAttributes-CreateLocationCustomAttributeDefinition) endpoint.
To create or update a custom attribute owned by another application, the `visibility` setting
must be `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LocationCustomAttributes.UpsertLocationCustomAttribute(
        new UpsertLocationCustomAttributeOperationRequest
        {
            LocationId = "some example string",
            Key = "some example string",
            Body = new UpsertLocationCustomAttributeRequest { CustomAttribute = new CustomAttribute() },
        });
    // TODO: Handle 'response' of type UpsertLocationCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpsertLocationCustomAttributeOperationRequest](src/Square/Requests/LocationCustomAttributes/UpsertLocationCustomAttributeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpsertLocationCustomAttributeResponse](src/Square/Models/UpsertLocationCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Locations

> Source: [Locations](src/Square/Api/Locations.cs)

<details>
<summary><code>Task&lt;CreateLocationResponse&gt; CreateLocation(CreateLocationOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a [location](https://developer.squareup.com/docs/locations-api).
Creating new locations allows for separate configuration of receipt layouts, item prices,
and sales reports. Developers can use locations to separate sales activity through applications
that integrate with Square from sales activity elsewhere in a seller's account.
Locations created programmatically with the Locations API last forever and
are visible to the seller for their own management. Therefore, ensure that
each location has a sensible and unique name.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Locations.CreateLocation(new CreateLocationOperationRequest
    {
        Body = new CreateLocationRequest(),
    });
    // TODO: Handle 'response' of type CreateLocationResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateLocationOperationRequest](src/Square/Requests/Locations/CreateLocationOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateLocationResponse](src/Square/Models/CreateLocationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListLocationsResponse&gt; ListLocations(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides details about all of the seller's [locations](https://developer.squareup.com/docs/locations-api),
including those with an inactive status. Locations are listed alphabetically by `name`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Locations.ListLocations();
    // TODO: Handle 'response' of type ListLocationsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListLocationsResponse](src/Square/Models/ListLocationsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLocationResponse&gt; RetrieveLocation(RetrieveLocationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details of a single location. Specify "main"
as the location ID to retrieve details of the [main location](https://developer.squareup.com/docs/locations-api#about-the-main-location).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Locations.RetrieveLocation(new RetrieveLocationRequest
    {
        LocationId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveLocationResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveLocationRequest](src/Square/Requests/Locations/RetrieveLocationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLocationResponse](src/Square/Models/RetrieveLocationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateLocationResponse&gt; UpdateLocation(UpdateLocationOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a [location](https://developer.squareup.com/docs/locations-api).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Locations.UpdateLocation(new UpdateLocationOperationRequest
    {
        LocationId = "some example string",
        Body = new UpdateLocationRequest(),
    });
    // TODO: Handle 'response' of type UpdateLocationResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateLocationOperationRequest](src/Square/Requests/Locations/UpdateLocationOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateLocationResponse](src/Square/Models/UpdateLocationResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Loyalty

> Source: [Loyalty](src/Square/Api/Loyalty.cs)

<details>
<summary><code>Task&lt;AccumulateLoyaltyPointsResponse&gt; AccumulateLoyaltyPoints(AccumulateLoyaltyPointsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds points earned from a purchase to a [loyalty account](entity:LoyaltyAccount).

- If you are using the Orders API to manage orders, provide the `order_id`. Square reads the order
to compute the points earned from both the base loyalty program and an associated
[loyalty promotion](entity:LoyaltyPromotion). For purchases that qualify for multiple accrual
rules, Square computes points based on the accrual rule that grants the most points.
For purchases that qualify for multiple promotions, Square computes points based on the most
recently created promotion. A purchase must first qualify for program points to be eligible for promotion points.

- If you are not using the Orders API to manage orders, provide `points` with the number of points to add.
You must first perform a client-side computation of the points earned from the loyalty program and
loyalty promotion. For spend-based and visit-based programs, you can call [CalculateLoyaltyPoints](api-endpoint:Loyalty-CalculateLoyaltyPoints)
to compute the points earned from the base loyalty program. For information about computing points earned from a loyalty promotion, see
[Calculating promotion points](https://developer.squareup.com/docs/loyalty-api/loyalty-promotions#calculate-promotion-points).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.AccumulateLoyaltyPoints(new AccumulateLoyaltyPointsOperationRequest
    {
        AccountId = "some example string",
        Body = new AccumulateLoyaltyPointsRequest
        {
            AccumulatePoints = new LoyaltyEventAccumulatePoints(),
            IdempotencyKey = "some example string",
            LocationId = "some example string",
        },
    });
    // TODO: Handle 'response' of type AccumulateLoyaltyPointsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccumulateLoyaltyPointsOperationRequest](src/Square/Requests/Loyalty/AccumulateLoyaltyPointsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccumulateLoyaltyPointsResponse](src/Square/Models/AccumulateLoyaltyPointsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AdjustLoyaltyPointsResponse&gt; AdjustLoyaltyPoints(AdjustLoyaltyPointsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds points to or subtracts points from a buyer's account.

Use this endpoint only when you need to manually adjust points. Otherwise, in your application flow, you call
[AccumulateLoyaltyPoints](api-endpoint:Loyalty-AccumulateLoyaltyPoints)
to add points when a buyer pays for the purchase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.AdjustLoyaltyPoints(new AdjustLoyaltyPointsOperationRequest
    {
        AccountId = "some example string",
        Body = new AdjustLoyaltyPointsRequest
        {
            IdempotencyKey = "some example string",
            AdjustPoints = new LoyaltyEventAdjustPoints { Points = 1 },
        },
    });
    // TODO: Handle 'response' of type AdjustLoyaltyPointsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AdjustLoyaltyPointsOperationRequest](src/Square/Requests/Loyalty/AdjustLoyaltyPointsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AdjustLoyaltyPointsResponse](src/Square/Models/AdjustLoyaltyPointsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalculateLoyaltyPointsResponse&gt; CalculateLoyaltyPoints(CalculateLoyaltyPointsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Calculates the number of points a buyer can earn from a purchase. Applications might call this endpoint
to display the points to the buyer.

- If you are using the Orders API to manage orders, provide the `order_id` and (optional) `loyalty_account_id`.
Square reads the order to compute the points earned from the base loyalty program and an associated
[loyalty promotion](entity:LoyaltyPromotion).

- If you are not using the Orders API to manage orders, provide `transaction_amount_money` with the
purchase amount. Square uses this amount to calculate the points earned from the base loyalty program,
but not points earned from a loyalty promotion. For spend-based and visit-based programs, the `tax_mode`
setting of the accrual rule indicates how taxes should be treated for loyalty points accrual.
If the purchase qualifies for program points, call
[ListLoyaltyPromotions](api-endpoint:Loyalty-ListLoyaltyPromotions) and perform a client-side computation
to calculate whether the purchase also qualifies for promotion points. For more information, see
[Calculating promotion points](https://developer.squareup.com/docs/loyalty-api/loyalty-promotions#calculate-promotion-points).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.CalculateLoyaltyPoints(new CalculateLoyaltyPointsOperationRequest
    {
        ProgramId = "some example string",
        Body = new CalculateLoyaltyPointsRequest(),
    });
    // TODO: Handle 'response' of type CalculateLoyaltyPointsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CalculateLoyaltyPointsOperationRequest](src/Square/Requests/Loyalty/CalculateLoyaltyPointsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculateLoyaltyPointsResponse](src/Square/Models/CalculateLoyaltyPointsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelLoyaltyPromotionResponse&gt; CancelLoyaltyPromotion(CancelLoyaltyPromotionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a loyalty promotion. Use this endpoint to cancel an `ACTIVE` promotion earlier than the
end date, cancel an `ACTIVE` promotion when an end date is not specified, or cancel a `SCHEDULED` promotion.
Because updating a promotion is not supported, you can also use this endpoint to cancel a promotion before
you create a new one.

This endpoint sets the loyalty promotion to the `CANCELED` state

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.CancelLoyaltyPromotion(new CancelLoyaltyPromotionRequest
    {
        PromotionId = "some example string",
        ProgramId = "some example string",
    });
    // TODO: Handle 'response' of type CancelLoyaltyPromotionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelLoyaltyPromotionRequest](src/Square/Requests/Loyalty/CancelLoyaltyPromotionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelLoyaltyPromotionResponse](src/Square/Models/CancelLoyaltyPromotionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateLoyaltyAccountResponse&gt; CreateLoyaltyAccount(CreateLoyaltyAccountOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a loyalty account. To create a loyalty account, you must provide the `program_id` and a `mapping` with the `phone_number` of the buyer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.CreateLoyaltyAccount(new CreateLoyaltyAccountOperationRequest
    {
        Body = new CreateLoyaltyAccountRequest
        {
            LoyaltyAccount = new LoyaltyAccount { ProgramId = "some example string" },
            IdempotencyKey = "some example string",
        },
    });
    // TODO: Handle 'response' of type CreateLoyaltyAccountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateLoyaltyAccountOperationRequest](src/Square/Requests/Loyalty/CreateLoyaltyAccountOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateLoyaltyAccountResponse](src/Square/Models/CreateLoyaltyAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateLoyaltyPromotionResponse&gt; CreateLoyaltyPromotion(CreateLoyaltyPromotionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a loyalty promotion for a [loyalty program](entity:LoyaltyProgram). A loyalty promotion
enables buyers to earn points in addition to those earned from the base loyalty program.

This endpoint sets the loyalty promotion to the `ACTIVE` or `SCHEDULED` status, depending on the
`available_time` setting. A loyalty program can have a maximum of 10 loyalty promotions with an
`ACTIVE` or `SCHEDULED` status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.CreateLoyaltyPromotion(new CreateLoyaltyPromotionOperationRequest
    {
        ProgramId = "some example string",
        Body = new CreateLoyaltyPromotionRequest
        {
            LoyaltyPromotion = new LoyaltyPromotion
            {
                Name = "some example string",
                Incentive = new LoyaltyPromotionIncentive { Type = LoyaltyPromotionIncentiveType.PointsMultiplier },
                AvailableTime = new LoyaltyPromotionAvailableTimeData { TimePeriods = ["some example string"] },
            },
            IdempotencyKey = "some example string",
        },
    });
    // TODO: Handle 'response' of type CreateLoyaltyPromotionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateLoyaltyPromotionOperationRequest](src/Square/Requests/Loyalty/CreateLoyaltyPromotionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateLoyaltyPromotionResponse](src/Square/Models/CreateLoyaltyPromotionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateLoyaltyRewardResponse&gt; CreateLoyaltyReward(CreateLoyaltyRewardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a loyalty reward. In the process, the endpoint does following:

- Uses the `reward_tier_id` in the request to determine the number of points
to lock for this reward.
- If the request includes `order_id`, it adds the reward and related discount to the order.

After a reward is created, the points are locked and
not available for the buyer to redeem another reward.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.CreateLoyaltyReward(new CreateLoyaltyRewardOperationRequest
    {
        Body = new CreateLoyaltyRewardRequest
        {
            Reward = new LoyaltyReward
            {
                LoyaltyAccountId = "some example string",
                RewardTierId = "some example string",
            },
            IdempotencyKey = "some example string",
        },
    });
    // TODO: Handle 'response' of type CreateLoyaltyRewardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateLoyaltyRewardOperationRequest](src/Square/Requests/Loyalty/CreateLoyaltyRewardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateLoyaltyRewardResponse](src/Square/Models/CreateLoyaltyRewardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteLoyaltyRewardResponse&gt; DeleteLoyaltyReward(DeleteLoyaltyRewardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a loyalty reward by doing the following:

- Returns the loyalty points back to the loyalty account.
- If an order ID was specified when the reward was created
(see [CreateLoyaltyReward](api-endpoint:Loyalty-CreateLoyaltyReward)),
it updates the order by removing the reward and related
discounts.

You cannot delete a reward that has reached the terminal state (REDEEMED).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.DeleteLoyaltyReward(new DeleteLoyaltyRewardRequest
    {
        RewardId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteLoyaltyRewardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteLoyaltyRewardRequest](src/Square/Requests/Loyalty/DeleteLoyaltyRewardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteLoyaltyRewardResponse](src/Square/Models/DeleteLoyaltyRewardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListLoyaltyProgramsResponse&gt; ListLoyaltyPrograms(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of loyalty programs in the seller's account.
Loyalty programs define how buyers can earn points and redeem points for rewards. Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard. For more information, see [Loyalty Program Overview](https://developer.squareup.com/docs/loyalty/overview).


Replaced with [RetrieveLoyaltyProgram](api-endpoint:Loyalty-RetrieveLoyaltyProgram) when used with the keyword `main`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.ListLoyaltyPrograms();
    // TODO: Handle 'response' of type ListLoyaltyProgramsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListLoyaltyProgramsResponse](src/Square/Models/ListLoyaltyProgramsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListLoyaltyPromotionsResponse&gt; ListLoyaltyPromotions(ListLoyaltyPromotionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the loyalty promotions associated with a [loyalty program](entity:LoyaltyProgram).
Results are sorted by the `created_at` date in descending order (newest to oldest).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.ListLoyaltyPromotions(new ListLoyaltyPromotionsRequest
    {
        ProgramId = "some example string",
    });
    // TODO: Handle 'response' of type ListLoyaltyPromotionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListLoyaltyPromotionsRequest](src/Square/Requests/Loyalty/ListLoyaltyPromotionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListLoyaltyPromotionsResponse](src/Square/Models/ListLoyaltyPromotionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RedeemLoyaltyRewardResponse&gt; RedeemLoyaltyReward(RedeemLoyaltyRewardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Redeems a loyalty reward.

The endpoint sets the reward to the `REDEEMED` terminal state.

If you are using your own order processing system (not using the
Orders API), you call this endpoint after the buyer paid for the
purchase.

After the reward reaches the terminal state, it cannot be deleted.
In other words, points used for the reward cannot be returned
to the account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.RedeemLoyaltyReward(new RedeemLoyaltyRewardOperationRequest
    {
        RewardId = "some example string",
        Body = new RedeemLoyaltyRewardRequest
        {
            IdempotencyKey = "some example string",
            LocationId = "some example string",
        },
    });
    // TODO: Handle 'response' of type RedeemLoyaltyRewardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RedeemLoyaltyRewardOperationRequest](src/Square/Requests/Loyalty/RedeemLoyaltyRewardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RedeemLoyaltyRewardResponse](src/Square/Models/RedeemLoyaltyRewardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLoyaltyAccountResponse&gt; RetrieveLoyaltyAccount(RetrieveLoyaltyAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a loyalty account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.RetrieveLoyaltyAccount(new RetrieveLoyaltyAccountRequest
    {
        AccountId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveLoyaltyAccountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveLoyaltyAccountRequest](src/Square/Requests/Loyalty/RetrieveLoyaltyAccountRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLoyaltyAccountResponse](src/Square/Models/RetrieveLoyaltyAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLoyaltyProgramResponse&gt; RetrieveLoyaltyProgram(RetrieveLoyaltyProgramRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the loyalty program in a seller's account, specified by the program ID or the keyword `main`.

Loyalty programs define how buyers can earn points and redeem points for rewards. Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard. For more information, see [Loyalty Program Overview](https://developer.squareup.com/docs/loyalty/overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.RetrieveLoyaltyProgram(new RetrieveLoyaltyProgramRequest
    {
        ProgramId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveLoyaltyProgramResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveLoyaltyProgramRequest](src/Square/Requests/Loyalty/RetrieveLoyaltyProgramRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLoyaltyProgramResponse](src/Square/Models/RetrieveLoyaltyProgramResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLoyaltyPromotionResponse&gt; RetrieveLoyaltyPromotion(RetrieveLoyaltyPromotionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a loyalty promotion.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.RetrieveLoyaltyPromotion(new RetrieveLoyaltyPromotionRequest
    {
        PromotionId = "some example string",
        ProgramId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveLoyaltyPromotionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveLoyaltyPromotionRequest](src/Square/Requests/Loyalty/RetrieveLoyaltyPromotionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLoyaltyPromotionResponse](src/Square/Models/RetrieveLoyaltyPromotionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveLoyaltyRewardResponse&gt; RetrieveLoyaltyReward(RetrieveLoyaltyRewardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a loyalty reward.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.RetrieveLoyaltyReward(new RetrieveLoyaltyRewardRequest
    {
        RewardId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveLoyaltyRewardResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveLoyaltyRewardRequest](src/Square/Requests/Loyalty/RetrieveLoyaltyRewardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveLoyaltyRewardResponse](src/Square/Models/RetrieveLoyaltyRewardResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchLoyaltyAccountsResponse&gt; SearchLoyaltyAccounts(SearchLoyaltyAccountsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for loyalty accounts in a loyalty program.

You can search for a loyalty account using the phone number or customer ID associated with the account. To return all loyalty accounts, specify an empty `query` object or omit it entirely.

Search results are sorted by `created_at` in ascending order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.SearchLoyaltyAccounts(new SearchLoyaltyAccountsOperationRequest
    {
        Body = new SearchLoyaltyAccountsRequest(),
    });
    // TODO: Handle 'response' of type SearchLoyaltyAccountsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchLoyaltyAccountsOperationRequest](src/Square/Requests/Loyalty/SearchLoyaltyAccountsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchLoyaltyAccountsResponse](src/Square/Models/SearchLoyaltyAccountsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchLoyaltyEventsResponse&gt; SearchLoyaltyEvents(SearchLoyaltyEventsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for loyalty events.

A Square loyalty program maintains a ledger of events that occur during the lifetime of a
buyer's loyalty account. Each change in the point balance
(for example, points earned, points redeemed, and points expired) is
recorded in the ledger. Using this endpoint, you can search the ledger for events.

Search results are sorted by `created_at` in descending order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.SearchLoyaltyEvents(new SearchLoyaltyEventsOperationRequest
    {
        Body = new SearchLoyaltyEventsRequest(),
    });
    // TODO: Handle 'response' of type SearchLoyaltyEventsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchLoyaltyEventsOperationRequest](src/Square/Requests/Loyalty/SearchLoyaltyEventsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchLoyaltyEventsResponse](src/Square/Models/SearchLoyaltyEventsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchLoyaltyRewardsResponse&gt; SearchLoyaltyRewards(SearchLoyaltyRewardsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for loyalty rewards. This endpoint accepts a request with no query filters and returns results for all loyalty accounts.
If you include a `query` object, `loyalty_account_id` is required and `status` is  optional.

If you know a reward ID, use the
[RetrieveLoyaltyReward](api-endpoint:Loyalty-RetrieveLoyaltyReward) endpoint.

Search results are sorted by `updated_at` in descending order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Loyalty.SearchLoyaltyRewards(new SearchLoyaltyRewardsOperationRequest
    {
        Body = new SearchLoyaltyRewardsRequest(),
    });
    // TODO: Handle 'response' of type SearchLoyaltyRewardsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchLoyaltyRewardsOperationRequest](src/Square/Requests/Loyalty/SearchLoyaltyRewardsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchLoyaltyRewardsResponse](src/Square/Models/SearchLoyaltyRewardsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MerchantCustomAttributes

> Source: [MerchantCustomAttributes](src/Square/Api/MerchantCustomAttributes.cs)

<details>
<summary><code>Task&lt;BulkDeleteMerchantCustomAttributesResponse&gt; BulkDeleteMerchantCustomAttributes(BulkDeleteMerchantCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes [custom attributes](entity:CustomAttribute) for a merchant as a bulk operation.
To delete a custom attribute owned by another application, the `visibility` setting must be
`VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.BulkDeleteMerchantCustomAttributes(
        new BulkDeleteMerchantCustomAttributesOperationRequest
        {
            Body = new BulkDeleteMerchantCustomAttributesRequest
            {
                Values = new Dictionary<string, BulkDeleteMerchantCustomAttributesRequestMerchantCustomAttributeDeleteRequest>
                {
                    ["key"] = new BulkDeleteMerchantCustomAttributesRequestMerchantCustomAttributeDeleteRequest(),
                },
            },
        });
    // TODO: Handle 'response' of type BulkDeleteMerchantCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkDeleteMerchantCustomAttributesOperationRequest](src/Square/Requests/MerchantCustomAttributes/BulkDeleteMerchantCustomAttributesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkDeleteMerchantCustomAttributesResponse](src/Square/Models/BulkDeleteMerchantCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkUpsertMerchantCustomAttributesResponse&gt; BulkUpsertMerchantCustomAttributes(BulkUpsertMerchantCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates [custom attributes](entity:CustomAttribute) for a merchant as a bulk operation.
Use this endpoint to set the value of one or more custom attributes for a merchant.
A custom attribute is based on a custom attribute definition in a Square seller account, which is
created using the [CreateMerchantCustomAttributeDefinition](api-endpoint:MerchantCustomAttributes-CreateMerchantCustomAttributeDefinition) endpoint.
This `BulkUpsertMerchantCustomAttributes` endpoint accepts a map of 1 to 25 individual upsert
requests and returns a map of individual upsert responses. Each upsert request has a unique ID
and provides a merchant ID and custom attribute. Each upsert response is returned with the ID
of the corresponding request.
To create or update a custom attribute owned by another application, the `visibility` setting
must be `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.BulkUpsertMerchantCustomAttributes(
        new BulkUpsertMerchantCustomAttributesOperationRequest
        {
            Body = new BulkUpsertMerchantCustomAttributesRequest
            {
                Values = new Dictionary<string, BulkUpsertMerchantCustomAttributesRequestMerchantCustomAttributeUpsertRequest>
                {
                    ["key"] = new BulkUpsertMerchantCustomAttributesRequestMerchantCustomAttributeUpsertRequest
                    {
                        MerchantId = "some example string",
                        CustomAttribute = new CustomAttribute(),
                    },
                },
            },
        });
    // TODO: Handle 'response' of type BulkUpsertMerchantCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkUpsertMerchantCustomAttributesOperationRequest](src/Square/Requests/MerchantCustomAttributes/BulkUpsertMerchantCustomAttributesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkUpsertMerchantCustomAttributesResponse](src/Square/Models/BulkUpsertMerchantCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateMerchantCustomAttributeDefinitionResponse&gt; CreateMerchantCustomAttributeDefinition(CreateMerchantCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a merchant-related [custom attribute definition](entity:CustomAttributeDefinition) for a Square seller account.
Use this endpoint to define a custom attribute that can be associated with a merchant connecting to your application.
A custom attribute definition specifies the `key`, `visibility`, `schema`, and other properties
for a custom attribute. After the definition is created, you can call
[UpsertMerchantCustomAttribute](api-endpoint:MerchantCustomAttributes-UpsertMerchantCustomAttribute) or
[BulkUpsertMerchantCustomAttributes](api-endpoint:MerchantCustomAttributes-BulkUpsertMerchantCustomAttributes)
to set the custom attribute for a merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.CreateMerchantCustomAttributeDefinition(
        new CreateMerchantCustomAttributeDefinitionOperationRequest
        {
            Body = new CreateMerchantCustomAttributeDefinitionRequest
            {
                CustomAttributeDefinition = new CustomAttributeDefinition(),
            },
        });
    // TODO: Handle 'response' of type CreateMerchantCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateMerchantCustomAttributeDefinitionOperationRequest](src/Square/Requests/MerchantCustomAttributes/CreateMerchantCustomAttributeDefinitionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateMerchantCustomAttributeDefinitionResponse](src/Square/Models/CreateMerchantCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteMerchantCustomAttributeResponse&gt; DeleteMerchantCustomAttribute(DeleteMerchantCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a [custom attribute](entity:CustomAttribute) associated with a merchant.
To delete a custom attribute owned by another application, the `visibility` setting must be
`VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.DeleteMerchantCustomAttribute(
        new DeleteMerchantCustomAttributeRequest { MerchantId = "some example string", Key = "some example string" });
    // TODO: Handle 'response' of type DeleteMerchantCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMerchantCustomAttributeRequest](src/Square/Requests/MerchantCustomAttributes/DeleteMerchantCustomAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteMerchantCustomAttributeResponse](src/Square/Models/DeleteMerchantCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteMerchantCustomAttributeDefinitionResponse&gt; DeleteMerchantCustomAttributeDefinition(DeleteMerchantCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a merchant-related [custom attribute definition](entity:CustomAttributeDefinition) from a Square seller account.
Deleting a custom attribute definition also deletes the corresponding custom attribute from
the merchant.
Only the definition owner can delete a custom attribute definition.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.DeleteMerchantCustomAttributeDefinition(
        new DeleteMerchantCustomAttributeDefinitionRequest { Key = "some example string" });
    // TODO: Handle 'response' of type DeleteMerchantCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteMerchantCustomAttributeDefinitionRequest](src/Square/Requests/MerchantCustomAttributes/DeleteMerchantCustomAttributeDefinitionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteMerchantCustomAttributeDefinitionResponse](src/Square/Models/DeleteMerchantCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListMerchantCustomAttributeDefinitionsResponse&gt; ListMerchantCustomAttributeDefinitions(ListMerchantCustomAttributeDefinitionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the merchant-related [custom attribute definitions](entity:CustomAttributeDefinition) that belong to a Square seller account.
When all response pages are retrieved, the results include all custom attribute definitions
that are visible to the requesting application, including those that are created by other
applications and set to `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.ListMerchantCustomAttributeDefinitions(
        new ListMerchantCustomAttributeDefinitionsRequest());
    // TODO: Handle 'response' of type ListMerchantCustomAttributeDefinitionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantCustomAttributeDefinitionsRequest](src/Square/Requests/MerchantCustomAttributes/ListMerchantCustomAttributeDefinitionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantCustomAttributeDefinitionsResponse](src/Square/Models/ListMerchantCustomAttributeDefinitionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListMerchantCustomAttributesResponse&gt; ListMerchantCustomAttributes(ListMerchantCustomAttributesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the [custom attributes](entity:CustomAttribute) associated with a merchant.
You can use the `with_definitions` query parameter to also retrieve custom attribute definitions
in the same call.
When all response pages are retrieved, the results include all custom attributes that are
visible to the requesting application, including those that are owned by other applications
and set to `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.ListMerchantCustomAttributes(
        new ListMerchantCustomAttributesRequest { MerchantId = "some example string" });
    // TODO: Handle 'response' of type ListMerchantCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantCustomAttributesRequest](src/Square/Requests/MerchantCustomAttributes/ListMerchantCustomAttributesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantCustomAttributesResponse](src/Square/Models/ListMerchantCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveMerchantCustomAttributeResponse&gt; RetrieveMerchantCustomAttribute(RetrieveMerchantCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a [custom attribute](entity:CustomAttribute) associated with a merchant.
You can use the `with_definition` query parameter to also retrieve the custom attribute definition
in the same call.
To retrieve a custom attribute owned by another application, the `visibility` setting must be
`VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.RetrieveMerchantCustomAttribute(
        new RetrieveMerchantCustomAttributeRequest { MerchantId = "some example string", Key = "some example string" });
    // TODO: Handle 'response' of type RetrieveMerchantCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveMerchantCustomAttributeRequest](src/Square/Requests/MerchantCustomAttributes/RetrieveMerchantCustomAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveMerchantCustomAttributeResponse](src/Square/Models/RetrieveMerchantCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveMerchantCustomAttributeDefinitionResponse&gt; RetrieveMerchantCustomAttributeDefinition(RetrieveMerchantCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a merchant-related [custom attribute definition](entity:CustomAttributeDefinition) from a Square seller account.
To retrieve a custom attribute definition created by another application, the `visibility`
setting must be `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.RetrieveMerchantCustomAttributeDefinition(
        new RetrieveMerchantCustomAttributeDefinitionRequest { Key = "some example string" });
    // TODO: Handle 'response' of type RetrieveMerchantCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveMerchantCustomAttributeDefinitionRequest](src/Square/Requests/MerchantCustomAttributes/RetrieveMerchantCustomAttributeDefinitionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveMerchantCustomAttributeDefinitionResponse](src/Square/Models/RetrieveMerchantCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateMerchantCustomAttributeDefinitionResponse&gt; UpdateMerchantCustomAttributeDefinition(UpdateMerchantCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a merchant-related [custom attribute definition](entity:CustomAttributeDefinition) for a Square seller account.
Use this endpoint to update the following fields: `name`, `description`, `visibility`, or the
`schema` for a `Selection` data type.
Only the definition owner can update a custom attribute definition.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.UpdateMerchantCustomAttributeDefinition(
        new UpdateMerchantCustomAttributeDefinitionOperationRequest
        {
            Key = "some example string",
            Body = new UpdateMerchantCustomAttributeDefinitionRequest
            {
                CustomAttributeDefinition = new CustomAttributeDefinition(),
            },
        });
    // TODO: Handle 'response' of type UpdateMerchantCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateMerchantCustomAttributeDefinitionOperationRequest](src/Square/Requests/MerchantCustomAttributes/UpdateMerchantCustomAttributeDefinitionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateMerchantCustomAttributeDefinitionResponse](src/Square/Models/UpdateMerchantCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpsertMerchantCustomAttributeResponse&gt; UpsertMerchantCustomAttribute(UpsertMerchantCustomAttributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates a [custom attribute](entity:CustomAttribute) for a merchant.
Use this endpoint to set the value of a custom attribute for a specified merchant.
A custom attribute is based on a custom attribute definition in a Square seller account, which
is created using the [CreateMerchantCustomAttributeDefinition](api-endpoint:MerchantCustomAttributes-CreateMerchantCustomAttributeDefinition) endpoint.
To create or update a custom attribute owned by another application, the `visibility` setting
must be `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantCustomAttributes.UpsertMerchantCustomAttribute(
        new UpsertMerchantCustomAttributeOperationRequest
        {
            MerchantId = "some example string",
            Key = "some example string",
            Body = new UpsertMerchantCustomAttributeRequest { CustomAttribute = new CustomAttribute() },
        });
    // TODO: Handle 'response' of type UpsertMerchantCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpsertMerchantCustomAttributeOperationRequest](src/Square/Requests/MerchantCustomAttributes/UpsertMerchantCustomAttributeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpsertMerchantCustomAttributeResponse](src/Square/Models/UpsertMerchantCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Merchants

> Source: [Merchants](src/Square/Api/Merchants.cs)

<details>
<summary><code>Task&lt;ListMerchantsResponse&gt; ListMerchants(ListMerchantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides details about the merchant associated with a given access token.

The access token used to connect your application to a Square seller is associated
with a single merchant. That means that `ListMerchants` returns a list
with a single `Merchant` object. You can specify your personal access token
to get your own merchant information or specify an OAuth token to get the
information for the merchant that granted your application access.

If you know the merchant ID, you can also use the [RetrieveMerchant](api-endpoint:Merchants-RetrieveMerchant)
endpoint to retrieve the merchant information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Merchants.ListMerchants(new ListMerchantsRequest());
    // TODO: Handle 'response' of type ListMerchantsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListMerchantsRequest](src/Square/Requests/Merchants/ListMerchantsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListMerchantsResponse](src/Square/Models/ListMerchantsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveMerchantResponse&gt; RetrieveMerchant(RetrieveMerchantRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the `Merchant` object for the given `merchant_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Merchants.RetrieveMerchant(new RetrieveMerchantRequest
    {
        MerchantId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveMerchantResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveMerchantRequest](src/Square/Requests/Merchants/RetrieveMerchantRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveMerchantResponse](src/Square/Models/RetrieveMerchantResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OAuth

> Source: [OAuth](src/Square/Api/OAuth.cs)

<details>
<summary><code>Task&lt;ObtainTokenResponse&gt; ObtainToken(ObtainTokenOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an OAuth access token and refresh token using the `authorization_code`
or `refresh_token` grant type.

When `grant_type` is `authorization_code`:
- With the [code flow](https://developer.squareup.com/docs/oauth-api/overview#code-flow),
provide `code`, `client_id`, and `client_secret`.
- With the [PKCE flow](https://developer.squareup.com/docs/oauth-api/overview#pkce-flow),
provide `code`, `client_id`, and `code_verifier`. 

When `grant_type` is `refresh_token`:
- With the code flow, provide `refresh_token`, `client_id`, and `client_secret`.
The response returns the same refresh token provided in the request.
- With the PKCE flow, provide `refresh_token` and `client_id`. The response returns
a new refresh token.

You can use the `scopes` parameter to limit the set of permissions authorized by the
access token. You can use the `short_lived` parameter to create an access token that
expires in 24 hours.

__Important:__ OAuth tokens should be encrypted and stored on a secure server.
Application clients should never interact directly with OAuth tokens.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OAuth.ObtainToken(new ObtainTokenOperationRequest
    {
        Body = new ObtainTokenRequest { ClientId = "some example string", GrantType = "some example string" },
    });
    // TODO: Handle 'response' of type ObtainTokenResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ObtainTokenOperationRequest](src/Square/Requests/OAuth/ObtainTokenOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ObtainTokenResponse](src/Square/Models/ObtainTokenResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveTokenStatusResponse&gt; RetrieveTokenStatus(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about an [OAuth access token](https://developer.squareup.com/docs/build-basics/access-tokens#get-an-oauth-access-token) or an application’s [personal access token](https://developer.squareup.com/docs/build-basics/access-tokens#get-a-personal-access-token).

Add the access token to the Authorization header of the request.

__Important:__ The `Authorization` header you provide to this endpoint must have the following format:

```
Authorization: Bearer ACCESS_TOKEN
```

where `ACCESS_TOKEN` is a
[valid production authorization credential](https://developer.squareup.com/docs/build-basics/access-tokens).

If the access token is expired or not a valid access token, the endpoint returns an `UNAUTHORIZED` error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OAuth.RetrieveTokenStatus();
    // TODO: Handle 'response' of type RetrieveTokenStatusResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveTokenStatusResponse](src/Square/Models/RetrieveTokenStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevokeTokenResponse&gt; RevokeToken(RevokeTokenOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Revokes an access token generated with the OAuth flow.

If an account has more than one OAuth access token for your application, this
endpoint revokes all of them, regardless of which token you specify. 

__Important:__ The `Authorization` header for this endpoint must have the
following format:

```
Authorization: Client APPLICATION_SECRET
```

Replace `APPLICATION_SECRET` with the application secret on the **OAuth**
page for your application in the Developer Dashboard.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OAuth.RevokeToken(new RevokeTokenOperationRequest { Body = new RevokeTokenRequest() });
    // TODO: Handle 'response' of type RevokeTokenResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RevokeTokenOperationRequest](src/Square/Requests/OAuth/RevokeTokenOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevokeTokenResponse](src/Square/Models/RevokeTokenResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OrderCustomAttributes

> Source: [OrderCustomAttributes](src/Square/Api/OrderCustomAttributes.cs)

<details>
<summary><code>Task&lt;BulkDeleteOrderCustomAttributesResponse&gt; BulkDeleteOrderCustomAttributes(BulkDeleteOrderCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes order [custom attributes](entity:CustomAttribute) as a bulk operation.

Use this endpoint to delete one or more custom attributes from one or more orders.
A custom attribute is based on a custom attribute definition in a Square seller account.  (To create a
custom attribute definition, use the [CreateOrderCustomAttributeDefinition](api-endpoint:OrderCustomAttributes-CreateOrderCustomAttributeDefinition) endpoint.)

This `BulkDeleteOrderCustomAttributes` endpoint accepts a map of 1 to 25 individual delete
requests and returns a map of individual delete responses. Each delete request has a unique ID
and provides an order ID and custom attribute. Each delete response is returned with the ID
of the corresponding request.

To delete a custom attribute owned by another application, the `visibility` setting
must be `VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
(also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.BulkDeleteOrderCustomAttributes(
        new BulkDeleteOrderCustomAttributesOperationRequest
        {
            Body = new BulkDeleteOrderCustomAttributesRequest
            {
                Values = new Dictionary<string, BulkDeleteOrderCustomAttributesRequestDeleteCustomAttribute>
                {
                    ["key"] = new BulkDeleteOrderCustomAttributesRequestDeleteCustomAttribute
                    {
                        OrderId = "some example string",
                    },
                },
            },
        });
    // TODO: Handle 'response' of type BulkDeleteOrderCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkDeleteOrderCustomAttributesOperationRequest](src/Square/Requests/OrderCustomAttributes/BulkDeleteOrderCustomAttributesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkDeleteOrderCustomAttributesResponse](src/Square/Models/BulkDeleteOrderCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkUpsertOrderCustomAttributesResponse&gt; BulkUpsertOrderCustomAttributes(BulkUpsertOrderCustomAttributesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates order [custom attributes](entity:CustomAttribute) as a bulk operation.

Use this endpoint to delete one or more custom attributes from one or more orders.
A custom attribute is based on a custom attribute definition in a Square seller account.  (To create a
custom attribute definition, use the [CreateOrderCustomAttributeDefinition](api-endpoint:OrderCustomAttributes-CreateOrderCustomAttributeDefinition) endpoint.)

This `BulkUpsertOrderCustomAttributes` endpoint accepts a map of 1 to 25 individual upsert
requests and returns a map of individual upsert responses. Each upsert request has a unique ID
and provides an order ID and custom attribute. Each upsert response is returned with the ID
of the corresponding request.

To create or update a custom attribute owned by another application, the `visibility` setting
must be `VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
(also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.BulkUpsertOrderCustomAttributes(
        new BulkUpsertOrderCustomAttributesOperationRequest
        {
            Body = new BulkUpsertOrderCustomAttributesRequest
            {
                Values = new Dictionary<string, BulkUpsertOrderCustomAttributesRequestUpsertCustomAttribute>
                {
                    ["key"] = new BulkUpsertOrderCustomAttributesRequestUpsertCustomAttribute
                    {
                        CustomAttribute = new CustomAttribute(),
                        OrderId = "some example string",
                    },
                },
            },
        });
    // TODO: Handle 'response' of type BulkUpsertOrderCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkUpsertOrderCustomAttributesOperationRequest](src/Square/Requests/OrderCustomAttributes/BulkUpsertOrderCustomAttributesOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkUpsertOrderCustomAttributesResponse](src/Square/Models/BulkUpsertOrderCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateOrderCustomAttributeDefinitionResponse&gt; CreateOrderCustomAttributeDefinition(CreateOrderCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order-related custom attribute definition.  Use this endpoint to
define a custom attribute that can be associated with orders.

After creating a custom attribute definition, you can set the custom attribute for orders
in the Square seller account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.CreateOrderCustomAttributeDefinition(
        new CreateOrderCustomAttributeDefinitionOperationRequest
        {
            Body = new CreateOrderCustomAttributeDefinitionRequest
            {
                CustomAttributeDefinition = new CustomAttributeDefinition(),
            },
        });
    // TODO: Handle 'response' of type CreateOrderCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateOrderCustomAttributeDefinitionOperationRequest](src/Square/Requests/OrderCustomAttributes/CreateOrderCustomAttributeDefinitionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateOrderCustomAttributeDefinitionResponse](src/Square/Models/CreateOrderCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteOrderCustomAttributeResponse&gt; DeleteOrderCustomAttribute(DeleteOrderCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a [custom attribute](entity:CustomAttribute) associated with a customer profile.

To delete a custom attribute owned by another application, the `visibility` setting must be
`VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
(also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.DeleteOrderCustomAttribute(new DeleteOrderCustomAttributeRequest
    {
        OrderId = "some example string",
        CustomAttributeKey = "some example string",
    });
    // TODO: Handle 'response' of type DeleteOrderCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteOrderCustomAttributeRequest](src/Square/Requests/OrderCustomAttributes/DeleteOrderCustomAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteOrderCustomAttributeResponse](src/Square/Models/DeleteOrderCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteOrderCustomAttributeDefinitionResponse&gt; DeleteOrderCustomAttributeDefinition(DeleteOrderCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an order-related [custom attribute definition](entity:CustomAttributeDefinition) from a Square seller account.

Only the definition owner can delete a custom attribute definition.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.DeleteOrderCustomAttributeDefinition(
        new DeleteOrderCustomAttributeDefinitionRequest { Key = "some example string" });
    // TODO: Handle 'response' of type DeleteOrderCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteOrderCustomAttributeDefinitionRequest](src/Square/Requests/OrderCustomAttributes/DeleteOrderCustomAttributeDefinitionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteOrderCustomAttributeDefinitionResponse](src/Square/Models/DeleteOrderCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListOrderCustomAttributeDefinitionsResponse&gt; ListOrderCustomAttributeDefinitions(ListOrderCustomAttributeDefinitionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the order-related [custom attribute definitions](entity:CustomAttributeDefinition) that belong to a Square seller account.

When all response pages are retrieved, the results include all custom attribute definitions
that are visible to the requesting application, including those that are created by other
applications and set to `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`. Note that
seller-defined custom attributes (also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.ListOrderCustomAttributeDefinitions(
        new ListOrderCustomAttributeDefinitionsRequest());
    // TODO: Handle 'response' of type ListOrderCustomAttributeDefinitionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListOrderCustomAttributeDefinitionsRequest](src/Square/Requests/OrderCustomAttributes/ListOrderCustomAttributeDefinitionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListOrderCustomAttributeDefinitionsResponse](src/Square/Models/ListOrderCustomAttributeDefinitionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListOrderCustomAttributesResponse&gt; ListOrderCustomAttributes(ListOrderCustomAttributesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the [custom attributes](entity:CustomAttribute) associated with an order.

You can use the `with_definitions` query parameter to also retrieve custom attribute definitions
in the same call.

When all response pages are retrieved, the results include all custom attributes that are
visible to the requesting application, including those that are owned by other applications
and set to `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.ListOrderCustomAttributes(new ListOrderCustomAttributesRequest
    {
        OrderId = "some example string",
    });
    // TODO: Handle 'response' of type ListOrderCustomAttributesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListOrderCustomAttributesRequest](src/Square/Requests/OrderCustomAttributes/ListOrderCustomAttributesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListOrderCustomAttributesResponse](src/Square/Models/ListOrderCustomAttributesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveOrderCustomAttributeResponse&gt; RetrieveOrderCustomAttribute(RetrieveOrderCustomAttributeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a [custom attribute](entity:CustomAttribute) associated with an order.

You can use the `with_definition` query parameter to also retrieve the custom attribute definition
in the same call.

To retrieve a custom attribute owned by another application, the `visibility` setting must be
`VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.RetrieveOrderCustomAttribute(
        new RetrieveOrderCustomAttributeRequest
        {
            OrderId = "some example string",
            CustomAttributeKey = "some example string",
        });
    // TODO: Handle 'response' of type RetrieveOrderCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveOrderCustomAttributeRequest](src/Square/Requests/OrderCustomAttributes/RetrieveOrderCustomAttributeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveOrderCustomAttributeResponse](src/Square/Models/RetrieveOrderCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveOrderCustomAttributeDefinitionResponse&gt; RetrieveOrderCustomAttributeDefinition(RetrieveOrderCustomAttributeDefinitionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an order-related [custom attribute definition](entity:CustomAttributeDefinition) from a Square seller account.

To retrieve a custom attribute definition created by another application, the `visibility`
setting must be `VISIBILITY_READ_ONLY` or `VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
(also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.RetrieveOrderCustomAttributeDefinition(
        new RetrieveOrderCustomAttributeDefinitionRequest { Key = "some example string" });
    // TODO: Handle 'response' of type RetrieveOrderCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveOrderCustomAttributeDefinitionRequest](src/Square/Requests/OrderCustomAttributes/RetrieveOrderCustomAttributeDefinitionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveOrderCustomAttributeDefinitionResponse](src/Square/Models/RetrieveOrderCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateOrderCustomAttributeDefinitionResponse&gt; UpdateOrderCustomAttributeDefinition(UpdateOrderCustomAttributeDefinitionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an order-related custom attribute definition for a Square seller account.

Only the definition owner can update a custom attribute definition. Note that sellers can view all custom attributes in exported customer data, including those set to `VISIBILITY_HIDDEN`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.UpdateOrderCustomAttributeDefinition(
        new UpdateOrderCustomAttributeDefinitionOperationRequest
        {
            Key = "some example string",
            Body = new UpdateOrderCustomAttributeDefinitionRequest
            {
                CustomAttributeDefinition = new CustomAttributeDefinition(),
            },
        });
    // TODO: Handle 'response' of type UpdateOrderCustomAttributeDefinitionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateOrderCustomAttributeDefinitionOperationRequest](src/Square/Requests/OrderCustomAttributes/UpdateOrderCustomAttributeDefinitionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateOrderCustomAttributeDefinitionResponse](src/Square/Models/UpdateOrderCustomAttributeDefinitionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpsertOrderCustomAttributeResponse&gt; UpsertOrderCustomAttribute(UpsertOrderCustomAttributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates a [custom attribute](entity:CustomAttribute) for an order.

Use this endpoint to set the value of a custom attribute for a specific order.
A custom attribute is based on a custom attribute definition in a Square seller account. (To create a
custom attribute definition, use the [CreateOrderCustomAttributeDefinition](api-endpoint:OrderCustomAttributes-CreateOrderCustomAttributeDefinition) endpoint.)

To create or update a custom attribute owned by another application, the `visibility` setting
must be `VISIBILITY_READ_WRITE_VALUES`. Note that seller-defined custom attributes
(also known as custom fields) are always set to `VISIBILITY_READ_WRITE_VALUES`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrderCustomAttributes.UpsertOrderCustomAttribute(
        new UpsertOrderCustomAttributeOperationRequest
        {
            OrderId = "some example string",
            CustomAttributeKey = "some example string",
            Body = new UpsertOrderCustomAttributeRequest { CustomAttribute = new CustomAttribute() },
        });
    // TODO: Handle 'response' of type UpsertOrderCustomAttributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpsertOrderCustomAttributeOperationRequest](src/Square/Requests/OrderCustomAttributes/UpsertOrderCustomAttributeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpsertOrderCustomAttributeResponse](src/Square/Models/UpsertOrderCustomAttributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Orders

> Source: [Orders](src/Square/Api/Orders.cs)

<details>
<summary><code>Task&lt;BatchRetrieveOrdersResponse&gt; BatchRetrieveOrders(BatchRetrieveOrdersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a set of [orders](entity:Order) by their IDs.

If a given order ID does not exist, the ID is ignored instead of generating an error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.BatchRetrieveOrders(new BatchRetrieveOrdersOperationRequest
    {
        Body = new BatchRetrieveOrdersRequest { OrderIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type BatchRetrieveOrdersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BatchRetrieveOrdersOperationRequest](src/Square/Requests/Orders/BatchRetrieveOrdersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchRetrieveOrdersResponse](src/Square/Models/BatchRetrieveOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CalculateOrderResponse&gt; CalculateOrder(CalculateOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enables applications to preview order pricing without creating an order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.CalculateOrder(new CalculateOrderOperationRequest
    {
        Body = new CalculateOrderRequest { Order = new Order { LocationId = "some example string" } },
    });
    // TODO: Handle 'response' of type CalculateOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CalculateOrderOperationRequest](src/Square/Requests/Orders/CalculateOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CalculateOrderResponse](src/Square/Models/CalculateOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CloneOrderResponse&gt; CloneOrder(CloneOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new order, in the `DRAFT` state, by duplicating an existing order. The newly created order has
only the core fields (such as line items, taxes, and discounts) copied from the original order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.CloneOrder(new CloneOrderOperationRequest
    {
        Body = new CloneOrderRequest { OrderId = "some example string" },
    });
    // TODO: Handle 'response' of type CloneOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CloneOrderOperationRequest](src/Square/Requests/Orders/CloneOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CloneOrderResponse](src/Square/Models/CloneOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateOrderResponse&gt; CreateOrder(CreateOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new [order](entity:Order) that can include information about products for
purchase and settings to apply to the purchase.

To pay for a created order, see
[Pay for Orders](https://developer.squareup.com/docs/orders-api/pay-for-orders).

You can modify open orders using the [UpdateOrder](api-endpoint:Orders-UpdateOrder) endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.CreateOrder(new CreateOrderOperationRequest { Body = new CreateOrderRequest() });
    // TODO: Handle 'response' of type CreateOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateOrderOperationRequest](src/Square/Requests/Orders/CreateOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateOrderResponse](src/Square/Models/CreateOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PayOrderResponse&gt; PayOrder(PayOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Pay for an [order](entity:Order) using one or more approved [payments](entity:Payment)
or settle an order with a total of `0`.

The total of the `payment_ids` listed in the request must be equal to the order
total. Orders with a total amount of `0` can be marked as paid by specifying an empty
array of `payment_ids` in the request.

To be used with `PayOrder`, a payment must:

- Reference the order by specifying the `order_id` when [creating the payment](api-endpoint:Payments-CreatePayment).
Any approved payments that reference the same `order_id` not specified in the
`payment_ids` is canceled.
- Be approved with [delayed capture](https://developer.squareup.com/docs/payments-api/take-payments/card-payments/delayed-capture).
Using a delayed capture payment with `PayOrder` completes the approved payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.PayOrder(new PayOrderOperationRequest
    {
        OrderId = "some example string",
        Body = new PayOrderRequest { IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type PayOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PayOrderOperationRequest](src/Square/Requests/Orders/PayOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PayOrderResponse](src/Square/Models/PayOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveOrderResponse&gt; RetrieveOrder(RetrieveOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an [Order](entity:Order) by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.RetrieveOrder(new RetrieveOrderRequest { OrderId = "some example string" });
    // TODO: Handle 'response' of type RetrieveOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveOrderRequest](src/Square/Requests/Orders/RetrieveOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveOrderResponse](src/Square/Models/RetrieveOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchOrdersResponse&gt; SearchOrders(SearchOrdersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search all orders for one or more locations. Orders include all sales,
returns, and exchanges regardless of how or when they entered the Square
ecosystem (such as Point of Sale, Invoices, and Connect APIs).

`SearchOrders` requests need to specify which locations to search and define a
[SearchOrdersQuery](entity:SearchOrdersQuery) object that controls
how to sort or filter the results. Your `SearchOrdersQuery` can:

  Set filter criteria.
  Set the sort order.
  Determine whether to return results as complete `Order` objects or as
[OrderEntry](entity:OrderEntry) objects.

Note that details for orders processed with Square Point of Sale while in
offline mode might not be transmitted to Square for up to 72 hours. Offline
orders have a `created_at` value that reflects the time the order was created,
not the time it was subsequently transmitted to Square.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.SearchOrders(new SearchOrdersOperationRequest
    {
        Body = new SearchOrdersRequest(),
    });
    // TODO: Handle 'response' of type SearchOrdersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchOrdersOperationRequest](src/Square/Requests/Orders/SearchOrdersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchOrdersResponse](src/Square/Models/SearchOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateOrderResponse&gt; UpdateOrder(UpdateOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an open [order](entity:Order) by adding, replacing, or deleting
fields. Orders with a `COMPLETED` or `CANCELED` state cannot be updated.

An `UpdateOrder` request requires the following:

- The `order_id` in the endpoint path, identifying the order to update.
- The latest `version` of the order to update.
- The [sparse order](https://developer.squareup.com/docs/orders-api/manage-orders/update-orders#sparse-order-objects)
containing only the fields to update and the version to which the update is
being applied.
- If deleting fields, the [dot notation paths](https://developer.squareup.com/docs/orders-api/manage-orders/update-orders#identifying-fields-to-delete)
identifying the fields to clear.

To pay for an order, see
[Pay for Orders](https://developer.squareup.com/docs/orders-api/pay-for-orders).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.UpdateOrder(new UpdateOrderOperationRequest
    {
        OrderId = "some example string",
        Body = new UpdateOrderRequest(),
    });
    // TODO: Handle 'response' of type UpdateOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateOrderOperationRequest](src/Square/Requests/Orders/UpdateOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateOrderResponse](src/Square/Models/UpdateOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Payments

> Source: [Payments](src/Square/Api/Payments.cs)

<details>
<summary><code>Task&lt;CancelPaymentResponse&gt; CancelPayment(CancelPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels (voids) a payment. You can use this endpoint to cancel a payment with 
the APPROVED `status`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CancelPayment(new CancelPaymentRequest { PaymentId = "some example string" });
    // TODO: Handle 'response' of type CancelPaymentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelPaymentRequest](src/Square/Requests/Payments/CancelPaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelPaymentResponse](src/Square/Models/CancelPaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelPaymentByIdempotencyKeyResponse&gt; CancelPaymentByIdempotencyKey(CancelPaymentByIdempotencyKeyOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels (voids) a payment identified by the idempotency key that is specified in the
request.

Use this method when the status of a `CreatePayment` request is unknown (for example, after you send a
`CreatePayment` request, a network error occurs and you do not get a response). In this case, you can
direct Square to cancel the payment using this endpoint. In the request, you provide the same
idempotency key that you provided in your `CreatePayment` request that you want to cancel. After
canceling the payment, you can submit your `CreatePayment` request again.

Note that if no payment with the specified idempotency key is found, no action is taken and the endpoint
returns successfully.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CancelPaymentByIdempotencyKey(new CancelPaymentByIdempotencyKeyOperationRequest
    {
        Body = new CancelPaymentByIdempotencyKeyRequest { IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type CancelPaymentByIdempotencyKeyResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelPaymentByIdempotencyKeyOperationRequest](src/Square/Requests/Payments/CancelPaymentByIdempotencyKeyOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelPaymentByIdempotencyKeyResponse](src/Square/Models/CancelPaymentByIdempotencyKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CompletePaymentResponse&gt; CompletePayment(CompletePaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Completes (captures) a payment.
By default, payments are set to complete immediately after they are created.

You can use this endpoint to complete a payment with the APPROVED `status`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CompletePayment(new CompletePaymentOperationRequest
    {
        PaymentId = "some example string",
        Body = new CompletePaymentRequest(),
    });
    // TODO: Handle 'response' of type CompletePaymentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CompletePaymentOperationRequest](src/Square/Requests/Payments/CompletePaymentOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompletePaymentResponse](src/Square/Models/CompletePaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreatePaymentResponse&gt; CreatePayment(CreatePaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a payment using the provided source. You can use this endpoint 
to charge a card (credit/debit card or    
Square gift card) or record a payment that the seller received outside of Square 
(cash payment from a buyer or a payment that an external entity 
processed on behalf of the seller).

The endpoint creates a 
`Payment` object and returns it in the response.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CreatePayment(new CreatePaymentOperationRequest
    {
        Body = new CreatePaymentRequest { SourceId = "some example string", IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type CreatePaymentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreatePaymentOperationRequest](src/Square/Requests/Payments/CreatePaymentOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreatePaymentResponse](src/Square/Models/CreatePaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetPaymentResponse&gt; GetPayment(GetPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details for a specific payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetPayment(new GetPaymentRequest { PaymentId = "some example string" });
    // TODO: Handle 'response' of type GetPaymentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentRequest](src/Square/Requests/Payments/GetPaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPaymentResponse](src/Square/Models/GetPaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListPaymentsResponse&gt; ListPayments(ListPaymentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of payments taken by the account making the request.

Results are eventually consistent, and new payments or changes to payments might take several
seconds to appear.

The maximum results per page is 100.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.ListPayments(new ListPaymentsRequest());
    // TODO: Handle 'response' of type ListPaymentsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListPaymentsRequest](src/Square/Requests/Payments/ListPaymentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListPaymentsResponse](src/Square/Models/ListPaymentsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdatePaymentResponse&gt; UpdatePayment(UpdatePaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a payment with the APPROVED status.
You can update the `amount_money` and `tip_money` using this endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.UpdatePayment(new UpdatePaymentOperationRequest
    {
        PaymentId = "some example string",
        Body = new UpdatePaymentRequest { IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type UpdatePaymentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdatePaymentOperationRequest](src/Square/Requests/Payments/UpdatePaymentOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdatePaymentResponse](src/Square/Models/UpdatePaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Payouts

> Source: [Payouts](src/Square/Api/Payouts.cs)

<details>
<summary><code>Task&lt;GetPayoutResponse&gt; GetPayout(GetPayoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details of a specific payout identified by a payout ID.
To call this endpoint, set `PAYOUTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payouts.GetPayout(new GetPayoutRequest { PayoutId = "some example string" });
    // TODO: Handle 'response' of type GetPayoutResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPayoutRequest](src/Square/Requests/Payouts/GetPayoutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPayoutResponse](src/Square/Models/GetPayoutResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListPayoutEntriesResponse&gt; ListPayoutEntries(ListPayoutEntriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of all payout entries for a specific payout.
To call this endpoint, set `PAYOUTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payouts.ListPayoutEntries(new ListPayoutEntriesRequest
    {
        PayoutId = "some example string",
    });
    // TODO: Handle 'response' of type ListPayoutEntriesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListPayoutEntriesRequest](src/Square/Requests/Payouts/ListPayoutEntriesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListPayoutEntriesResponse](src/Square/Models/ListPayoutEntriesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListPayoutsResponse&gt; ListPayouts(ListPayoutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of all payouts for the default location.
You can filter payouts by location ID, status, time range, and order them in ascending or descending order.
To call this endpoint, set `PAYOUTS_READ` for the OAuth scope.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payouts.ListPayouts(new ListPayoutsRequest());
    // TODO: Handle 'response' of type ListPayoutsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListPayoutsRequest](src/Square/Requests/Payouts/ListPayoutsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListPayoutsResponse](src/Square/Models/ListPayoutsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Refunds

> Source: [Refunds](src/Square/Api/Refunds.cs)

<details>
<summary><code>Task&lt;GetPaymentRefundResponse&gt; GetPaymentRefund(GetPaymentRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific refund using the `refund_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Refunds.GetPaymentRefund(new GetPaymentRefundRequest
    {
        RefundId = "some example string",
    });
    // TODO: Handle 'response' of type GetPaymentRefundResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentRefundRequest](src/Square/Requests/Refunds/GetPaymentRefundRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPaymentRefundResponse](src/Square/Models/GetPaymentRefundResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListPaymentRefundsResponse&gt; ListPaymentRefunds(ListPaymentRefundsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of refunds for the account making the request.

Results are eventually consistent, and new refunds or changes to refunds might take several
seconds to appear.

The maximum results per page is 100.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Refunds.ListPaymentRefunds(new ListPaymentRefundsRequest());
    // TODO: Handle 'response' of type ListPaymentRefundsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListPaymentRefundsRequest](src/Square/Requests/Refunds/ListPaymentRefundsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListPaymentRefundsResponse](src/Square/Models/ListPaymentRefundsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RefundPaymentResponse&gt; RefundPayment(RefundPaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds a payment. You can refund the entire payment amount or a
portion of it. You can use this endpoint to refund a card payment or record a 
refund of a cash or external payment. For more information, see
[Refund Payment](https://developer.squareup.com/docs/payments-api/refund-payments).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Refunds.RefundPayment(new RefundPaymentOperationRequest
    {
        Body = new RefundPaymentRequest { IdempotencyKey = "some example string", AmountMoney = new Money() },
    });
    // TODO: Handle 'response' of type RefundPaymentResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RefundPaymentOperationRequest](src/Square/Requests/Refunds/RefundPaymentOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RefundPaymentResponse](src/Square/Models/RefundPaymentResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Sites

> Source: [Sites](src/Square/Api/Sites.cs)

<details>
<summary><code>Task&lt;ListSitesResponse&gt; ListSites(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the Square Online sites that belong to a seller. Sites are listed in descending order by the `created_at` date.


__Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see [Early access program for Square Online APIs](https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Sites.ListSites();
    // TODO: Handle 'response' of type ListSitesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListSitesResponse](src/Square/Models/ListSitesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Snippets

> Source: [Snippets](src/Square/Api/Snippets.cs)

<details>
<summary><code>Task&lt;DeleteSnippetResponse&gt; DeleteSnippet(DeleteSnippetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes your snippet from a Square Online site.

You can call [ListSites](api-endpoint:Sites-ListSites) to get the IDs of the sites that belong to a seller.


__Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see [Early access program for Square Online APIs](https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Snippets.DeleteSnippet(new DeleteSnippetRequest { SiteId = "some example string" });
    // TODO: Handle 'response' of type DeleteSnippetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteSnippetRequest](src/Square/Requests/Snippets/DeleteSnippetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteSnippetResponse](src/Square/Models/DeleteSnippetResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveSnippetResponse&gt; RetrieveSnippet(RetrieveSnippetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves your snippet from a Square Online site. A site can contain snippets from multiple snippet applications, but you can retrieve only the snippet that was added by your application.

You can call [ListSites](api-endpoint:Sites-ListSites) to get the IDs of the sites that belong to a seller.


__Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see [Early access program for Square Online APIs](https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Snippets.RetrieveSnippet(new RetrieveSnippetRequest { SiteId = "some example string" });
    // TODO: Handle 'response' of type RetrieveSnippetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveSnippetRequest](src/Square/Requests/Snippets/RetrieveSnippetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveSnippetResponse](src/Square/Models/RetrieveSnippetResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpsertSnippetResponse&gt; UpsertSnippet(UpsertSnippetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a snippet to a Square Online site or updates the existing snippet on the site. 
The snippet code is appended to the end of the `head` element on every page of the site, except checkout pages. A snippet application can add one snippet to a given site. 

You can call [ListSites](api-endpoint:Sites-ListSites) to get the IDs of the sites that belong to a seller.


__Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see [Early access program for Square Online APIs](https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Snippets.UpsertSnippet(new UpsertSnippetOperationRequest
    {
        SiteId = "some example string",
        Body = new UpsertSnippetRequest { Snippet = new Snippet { Content = "some example string" } },
    });
    // TODO: Handle 'response' of type UpsertSnippetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpsertSnippetOperationRequest](src/Square/Requests/Snippets/UpsertSnippetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpsertSnippetResponse](src/Square/Models/UpsertSnippetResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Subscriptions

> Source: [Subscriptions](src/Square/Api/Subscriptions.cs)

<details>
<summary><code>Task&lt;BulkSwapPlanResponse&gt; BulkSwapPlan(BulkSwapPlanOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a plan variation change for all active subscriptions under a given plan
variation. For more information, see [Swap Subscription Plan Variations](https://developer.squareup.com/docs/subscriptions-api/swap-plan-variations).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.BulkSwapPlan(new BulkSwapPlanOperationRequest
    {
        Body = new BulkSwapPlanRequest
        {
            NewPlanVariationId = "some example string",
            OldPlanVariationId = "some example string",
            LocationId = "some example string",
        },
    });
    // TODO: Handle 'response' of type BulkSwapPlanResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkSwapPlanOperationRequest](src/Square/Requests/Subscriptions/BulkSwapPlanOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkSwapPlanResponse](src/Square/Models/BulkSwapPlanResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelSubscriptionResponse&gt; CancelSubscription(CancelSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a `CANCEL` action to cancel an active subscription. This 
sets the `canceled_date` field to the end of the active billing period. After this date, 
the subscription status changes from ACTIVE to CANCELED.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.CancelSubscription(new CancelSubscriptionRequest
    {
        SubscriptionId = "some example string",
    });
    // TODO: Handle 'response' of type CancelSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelSubscriptionRequest](src/Square/Requests/Subscriptions/CancelSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelSubscriptionResponse](src/Square/Models/CancelSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChangeBillingAnchorDateResponse&gt; ChangeBillingAnchorDate(ChangeBillingAnchorDateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes the [billing anchor date](https://developer.squareup.com/docs/subscriptions-api/subscription-billing#billing-dates)
for a subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.ChangeBillingAnchorDate(new ChangeBillingAnchorDateOperationRequest
    {
        SubscriptionId = "some example string",
        Body = new ChangeBillingAnchorDateRequest(),
    });
    // TODO: Handle 'response' of type ChangeBillingAnchorDateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChangeBillingAnchorDateOperationRequest](src/Square/Requests/Subscriptions/ChangeBillingAnchorDateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChangeBillingAnchorDateResponse](src/Square/Models/ChangeBillingAnchorDateResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateSubscriptionResponse&gt; CreateSubscription(CreateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enrolls a customer in a subscription.

If you provide a card on file in the request, Square charges the card for
the subscription. Otherwise, Square sends an invoice to the customer's email
address. The subscription starts immediately, unless the request includes
the optional `start_date`. Each individual subscription is associated with a particular location.

For more information, see [Create a subscription](https://developer.squareup.com/docs/subscriptions-api/manage-subscriptions#create-a-subscription).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.CreateSubscription(new CreateSubscriptionOperationRequest
    {
        Body = new CreateSubscriptionRequest { LocationId = "some example string", CustomerId = "some example string" },
    });
    // TODO: Handle 'response' of type CreateSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateSubscriptionOperationRequest](src/Square/Requests/Subscriptions/CreateSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateSubscriptionResponse](src/Square/Models/CreateSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteSubscriptionActionResponse&gt; DeleteSubscriptionAction(DeleteSubscriptionActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a scheduled action for a subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.DeleteSubscriptionAction(new DeleteSubscriptionActionRequest
    {
        SubscriptionId = "some example string",
        ActionId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteSubscriptionActionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteSubscriptionActionRequest](src/Square/Requests/Subscriptions/DeleteSubscriptionActionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteSubscriptionActionResponse](src/Square/Models/DeleteSubscriptionActionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListSubscriptionEventsResponse&gt; ListSubscriptionEvents(ListSubscriptionEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all [events](https://developer.squareup.com/docs/subscriptions-api/actions-events) for a specific subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.ListSubscriptionEvents(new ListSubscriptionEventsRequest
    {
        SubscriptionId = "some example string",
    });
    // TODO: Handle 'response' of type ListSubscriptionEventsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListSubscriptionEventsRequest](src/Square/Requests/Subscriptions/ListSubscriptionEventsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListSubscriptionEventsResponse](src/Square/Models/ListSubscriptionEventsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PauseSubscriptionResponse&gt; PauseSubscription(PauseSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a `PAUSE` action to pause an active subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.PauseSubscription(new PauseSubscriptionOperationRequest
    {
        SubscriptionId = "some example string",
        Body = new PauseSubscriptionRequest(),
    });
    // TODO: Handle 'response' of type PauseSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PauseSubscriptionOperationRequest](src/Square/Requests/Subscriptions/PauseSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PauseSubscriptionResponse](src/Square/Models/PauseSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ResumeSubscriptionResponse&gt; ResumeSubscription(ResumeSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a `RESUME` action to resume a paused or a deactivated subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.ResumeSubscription(new ResumeSubscriptionOperationRequest
    {
        SubscriptionId = "some example string",
        Body = new ResumeSubscriptionRequest(),
    });
    // TODO: Handle 'response' of type ResumeSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ResumeSubscriptionOperationRequest](src/Square/Requests/Subscriptions/ResumeSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ResumeSubscriptionResponse](src/Square/Models/ResumeSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveSubscriptionResponse&gt; RetrieveSubscription(RetrieveSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.RetrieveSubscription(new RetrieveSubscriptionRequest
    {
        SubscriptionId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveSubscriptionRequest](src/Square/Requests/Subscriptions/RetrieveSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveSubscriptionResponse](src/Square/Models/RetrieveSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchSubscriptionsResponse&gt; SearchSubscriptions(SearchSubscriptionsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for subscriptions.

Results are ordered chronologically by subscription creation date. If
the request specifies more than one location ID,
the endpoint orders the result
by location ID, and then by creation date within each location. If no locations are given
in the query, all locations are searched.

You can also optionally specify `customer_ids` to search by customer.
If left unset, all customers
associated with the specified locations are returned.
If the request specifies customer IDs, the endpoint orders results
first by location, within location by customer ID, and within
customer by subscription creation date.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.SearchSubscriptions(new SearchSubscriptionsOperationRequest
    {
        Body = new SearchSubscriptionsRequest(),
    });
    // TODO: Handle 'response' of type SearchSubscriptionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchSubscriptionsOperationRequest](src/Square/Requests/Subscriptions/SearchSubscriptionsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchSubscriptionsResponse](src/Square/Models/SearchSubscriptionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SwapPlanResponse&gt; SwapPlan(SwapPlanOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Schedules a `SWAP_PLAN` action to swap a subscription plan variation in an existing subscription. 
For more information, see [Swap Subscription Plan Variations](https://developer.squareup.com/docs/subscriptions-api/swap-plan-variations).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.SwapPlan(new SwapPlanOperationRequest
    {
        SubscriptionId = "some example string",
        Body = new SwapPlanRequest(),
    });
    // TODO: Handle 'response' of type SwapPlanResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SwapPlanOperationRequest](src/Square/Requests/Subscriptions/SwapPlanOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SwapPlanResponse](src/Square/Models/SwapPlanResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateSubscriptionResponse&gt; UpdateSubscription(UpdateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a subscription by modifying or clearing `subscription` field values.
To clear a field, set its value to `null`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.UpdateSubscription(new UpdateSubscriptionOperationRequest
    {
        SubscriptionId = "some example string",
        Body = new UpdateSubscriptionRequest(),
    });
    // TODO: Handle 'response' of type UpdateSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateSubscriptionOperationRequest](src/Square/Requests/Subscriptions/UpdateSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateSubscriptionResponse](src/Square/Models/UpdateSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Team

> Source: [Team](src/Square/Api/Team.cs)

<details>
<summary><code>Task&lt;BulkCreateTeamMembersResponse&gt; BulkCreateTeamMembers(BulkCreateTeamMembersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates multiple `TeamMember` objects. The created `TeamMember` objects are returned on successful creates.
This process is non-transactional and processes as much of the request as possible. If one of the creates in
the request cannot be successfully processed, the request is not marked as failed, but the body of the response
contains explicit error information for the failed create.

Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#bulk-create-team-members).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.BulkCreateTeamMembers(new BulkCreateTeamMembersOperationRequest
    {
        Body = new BulkCreateTeamMembersRequest
        {
            TeamMembers = new Dictionary<string, CreateTeamMemberRequest> { ["key"] = new CreateTeamMemberRequest() },
        },
    });
    // TODO: Handle 'response' of type BulkCreateTeamMembersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkCreateTeamMembersOperationRequest](src/Square/Requests/Team/BulkCreateTeamMembersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkCreateTeamMembersResponse](src/Square/Models/BulkCreateTeamMembersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkUpdateTeamMembersResponse&gt; BulkUpdateTeamMembers(BulkUpdateTeamMembersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates multiple `TeamMember` objects. The updated `TeamMember` objects are returned on successful updates.
This process is non-transactional and processes as much of the request as possible. If one of the updates in
the request cannot be successfully processed, the request is not marked as failed, but the body of the response
contains explicit error information for the failed update.
Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#bulk-update-team-members).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.BulkUpdateTeamMembers(new BulkUpdateTeamMembersOperationRequest
    {
        Body = new BulkUpdateTeamMembersRequest
        {
            TeamMembers = new Dictionary<string, UpdateTeamMemberRequest> { ["key"] = new UpdateTeamMemberRequest() },
        },
    });
    // TODO: Handle 'response' of type BulkUpdateTeamMembersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkUpdateTeamMembersOperationRequest](src/Square/Requests/Team/BulkUpdateTeamMembersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkUpdateTeamMembersResponse](src/Square/Models/BulkUpdateTeamMembersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateJobResponse&gt; CreateJob(CreateJobOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a job in a seller account. A job defines a title and tip eligibility. Note that
compensation is defined in a [job assignment](entity:JobAssignment) in a team member's wage setting.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.CreateJob(new CreateJobOperationRequest
    {
        Body = new CreateJobRequest { Job = new Job(), IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type CreateJobResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateJobOperationRequest](src/Square/Requests/Team/CreateJobOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateJobResponse](src/Square/Models/CreateJobResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTeamMemberResponse&gt; CreateTeamMember(CreateTeamMemberOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a single `TeamMember` object. The `TeamMember` object is returned on successful creates.
You must provide the following values in your request to this endpoint:
- `given_name`
- `family_name`

Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#createteammember).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.CreateTeamMember(new CreateTeamMemberOperationRequest
    {
        Body = new CreateTeamMemberRequest(),
    });
    // TODO: Handle 'response' of type CreateTeamMemberResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTeamMemberOperationRequest](src/Square/Requests/Team/CreateTeamMemberOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTeamMemberResponse](src/Square/Models/CreateTeamMemberResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListJobsResponse&gt; ListJobs(ListJobsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists jobs in a seller account. Results are sorted by title in ascending order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.ListJobs(new ListJobsRequest());
    // TODO: Handle 'response' of type ListJobsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListJobsRequest](src/Square/Requests/Team/ListJobsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListJobsResponse](src/Square/Models/ListJobsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveJobResponse&gt; RetrieveJob(RetrieveJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specified job.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.RetrieveJob(new RetrieveJobRequest { JobId = "some example string" });
    // TODO: Handle 'response' of type RetrieveJobResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveJobRequest](src/Square/Requests/Team/RetrieveJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveJobResponse](src/Square/Models/RetrieveJobResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveTeamMemberResponse&gt; RetrieveTeamMember(RetrieveTeamMemberRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a `TeamMember` object for the given `TeamMember.id`.
Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#retrieve-a-team-member).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.RetrieveTeamMember(new RetrieveTeamMemberRequest
    {
        TeamMemberId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveTeamMemberResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveTeamMemberRequest](src/Square/Requests/Team/RetrieveTeamMemberRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveTeamMemberResponse](src/Square/Models/RetrieveTeamMemberResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveWageSettingResponse&gt; RetrieveWageSetting(RetrieveWageSettingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a `WageSetting` object for a team member specified
by `TeamMember.id`. For more information, see
[Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#retrievewagesetting).

Square recommends using [RetrieveTeamMember](api-endpoint:Team-RetrieveTeamMember) or [SearchTeamMembers](api-endpoint:Team-SearchTeamMembers)
to get this information directly from the `TeamMember.wage_setting` field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.RetrieveWageSetting(new RetrieveWageSettingRequest
    {
        TeamMemberId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveWageSettingResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveWageSettingRequest](src/Square/Requests/Team/RetrieveWageSettingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveWageSettingResponse](src/Square/Models/RetrieveWageSettingResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchTeamMembersResponse&gt; SearchTeamMembers(SearchTeamMembersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a paginated list of `TeamMember` objects for a business. 
The list can be filtered by location IDs, `ACTIVE` or `INACTIVE` status, or whether
the team member is the Square account owner.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.SearchTeamMembers(new SearchTeamMembersOperationRequest
    {
        Body = new SearchTeamMembersRequest(),
    });
    // TODO: Handle 'response' of type SearchTeamMembersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchTeamMembersOperationRequest](src/Square/Requests/Team/SearchTeamMembersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchTeamMembersResponse](src/Square/Models/SearchTeamMembersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateJobResponse&gt; UpdateJob(UpdateJobOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the title or tip eligibility of a job. Changes to the title propagate to all
`JobAssignment`, `Shift`, and `TeamMemberWage` objects that reference the job ID. Changes to
tip eligibility propagate to all `TeamMemberWage` objects that reference the job ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.UpdateJob(new UpdateJobOperationRequest
    {
        JobId = "some example string",
        Body = new UpdateJobRequest { Job = new Job() },
    });
    // TODO: Handle 'response' of type UpdateJobResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateJobOperationRequest](src/Square/Requests/Team/UpdateJobOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateJobResponse](src/Square/Models/UpdateJobResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateTeamMemberResponse&gt; UpdateTeamMember(UpdateTeamMemberOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a single `TeamMember` object. The `TeamMember` object is returned on successful updates.
Learn about [Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#update-a-team-member).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.UpdateTeamMember(new UpdateTeamMemberOperationRequest
    {
        TeamMemberId = "some example string",
        Body = new UpdateTeamMemberRequest(),
    });
    // TODO: Handle 'response' of type UpdateTeamMemberResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTeamMemberOperationRequest](src/Square/Requests/Team/UpdateTeamMemberOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateTeamMemberResponse](src/Square/Models/UpdateTeamMemberResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateWageSettingResponse&gt; UpdateWageSetting(UpdateWageSettingOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or updates a `WageSetting` object. The object is created if a
`WageSetting` with the specified `team_member_id` doesn't exist. Otherwise,
it fully replaces the `WageSetting` object for the team member.
The `WageSetting` is returned on a successful update. For more information, see
[Troubleshooting the Team API](https://developer.squareup.com/docs/team/troubleshooting#create-or-update-a-wage-setting).

Square recommends using [CreateTeamMember](api-endpoint:Team-CreateTeamMember) or [UpdateTeamMember](api-endpoint:Team-UpdateTeamMember)
to manage the `TeamMember.wage_setting` field directly.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Team.UpdateWageSetting(new UpdateWageSettingOperationRequest
    {
        TeamMemberId = "some example string",
        Body = new UpdateWageSettingRequest { WageSetting = new WageSetting() },
    });
    // TODO: Handle 'response' of type UpdateWageSettingResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateWageSettingOperationRequest](src/Square/Requests/Team/UpdateWageSettingOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateWageSettingResponse](src/Square/Models/UpdateWageSettingResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Terminal

> Source: [Terminal](src/Square/Api/Terminal.cs)

<details>
<summary><code>Task&lt;CancelTerminalActionResponse&gt; CancelTerminalAction(CancelTerminalActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a Terminal action request if the status of the request permits it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.CancelTerminalAction(new CancelTerminalActionRequest
    {
        ActionId = "some example string",
    });
    // TODO: Handle 'response' of type CancelTerminalActionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelTerminalActionRequest](src/Square/Requests/Terminal/CancelTerminalActionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelTerminalActionResponse](src/Square/Models/CancelTerminalActionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelTerminalCheckoutResponse&gt; CancelTerminalCheckout(CancelTerminalCheckoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a Terminal checkout request if the status of the request permits it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.CancelTerminalCheckout(new CancelTerminalCheckoutRequest
    {
        CheckoutId = "some example string",
    });
    // TODO: Handle 'response' of type CancelTerminalCheckoutResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelTerminalCheckoutRequest](src/Square/Requests/Terminal/CancelTerminalCheckoutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelTerminalCheckoutResponse](src/Square/Models/CancelTerminalCheckoutResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelTerminalRefundResponse&gt; CancelTerminalRefund(CancelTerminalRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels an Interac Terminal refund request by refund request ID if the status of the request permits it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.CancelTerminalRefund(new CancelTerminalRefundRequest
    {
        TerminalRefundId = "some example string",
    });
    // TODO: Handle 'response' of type CancelTerminalRefundResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelTerminalRefundRequest](src/Square/Requests/Terminal/CancelTerminalRefundRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelTerminalRefundResponse](src/Square/Models/CancelTerminalRefundResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTerminalActionResponse&gt; CreateTerminalAction(CreateTerminalActionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a Terminal action request and sends it to the specified device.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.CreateTerminalAction(new CreateTerminalActionOperationRequest
    {
        Body = new CreateTerminalActionRequest
        {
            IdempotencyKey = "some example string",
            Action = new TerminalAction(),
        },
    });
    // TODO: Handle 'response' of type CreateTerminalActionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTerminalActionOperationRequest](src/Square/Requests/Terminal/CreateTerminalActionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTerminalActionResponse](src/Square/Models/CreateTerminalActionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTerminalCheckoutResponse&gt; CreateTerminalCheckout(CreateTerminalCheckoutOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a Terminal checkout request and sends it to the specified device to take a payment
for the requested amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.CreateTerminalCheckout(new CreateTerminalCheckoutOperationRequest
    {
        Body = new CreateTerminalCheckoutRequest
        {
            IdempotencyKey = "some example string",
            Checkout = new TerminalCheckout
            {
                AmountMoney = new Money(),
                DeviceOptions = new DeviceCheckoutOptions { DeviceId = "some example string" },
            },
        },
    });
    // TODO: Handle 'response' of type CreateTerminalCheckoutResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTerminalCheckoutOperationRequest](src/Square/Requests/Terminal/CreateTerminalCheckoutOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTerminalCheckoutResponse](src/Square/Models/CreateTerminalCheckoutResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTerminalRefundResponse&gt; CreateTerminalRefund(CreateTerminalRefundOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a request to refund an Interac payment completed on a Square Terminal. Refunds for Interac payments on a Square Terminal are supported only for Interac debit cards in Canada. Other refunds for Terminal payments should use the Refunds API. For more information, see [Refunds API](api:Refunds).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.CreateTerminalRefund(new CreateTerminalRefundOperationRequest
    {
        Body = new CreateTerminalRefundRequest { IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type CreateTerminalRefundResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTerminalRefundOperationRequest](src/Square/Requests/Terminal/CreateTerminalRefundOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTerminalRefundResponse](src/Square/Models/CreateTerminalRefundResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DismissTerminalActionResponse&gt; DismissTerminalAction(DismissTerminalActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Dismisses a Terminal action request if the status and type of the request permits it.

See [Link and Dismiss Actions](https://developer.squareup.com/docs/terminal-api/advanced-features/custom-workflows/link-and-dismiss-actions) for more details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.DismissTerminalAction(new DismissTerminalActionRequest
    {
        ActionId = "some example string",
    });
    // TODO: Handle 'response' of type DismissTerminalActionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DismissTerminalActionRequest](src/Square/Requests/Terminal/DismissTerminalActionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DismissTerminalActionResponse](src/Square/Models/DismissTerminalActionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DismissTerminalCheckoutResponse&gt; DismissTerminalCheckout(DismissTerminalCheckoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Dismisses a Terminal checkout request if the status and type of the request permits it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.DismissTerminalCheckout(new DismissTerminalCheckoutRequest
    {
        CheckoutId = "some example string",
    });
    // TODO: Handle 'response' of type DismissTerminalCheckoutResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DismissTerminalCheckoutRequest](src/Square/Requests/Terminal/DismissTerminalCheckoutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DismissTerminalCheckoutResponse](src/Square/Models/DismissTerminalCheckoutResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DismissTerminalRefundResponse&gt; DismissTerminalRefund(DismissTerminalRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Dismisses a Terminal refund request if the status and type of the request permits it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.DismissTerminalRefund(new DismissTerminalRefundRequest
    {
        TerminalRefundId = "some example string",
    });
    // TODO: Handle 'response' of type DismissTerminalRefundResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DismissTerminalRefundRequest](src/Square/Requests/Terminal/DismissTerminalRefundRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DismissTerminalRefundResponse](src/Square/Models/DismissTerminalRefundResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTerminalActionResponse&gt; GetTerminalAction(GetTerminalActionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a Terminal action request by `action_id`. Terminal action requests are available for 30 days.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.GetTerminalAction(new GetTerminalActionRequest
    {
        ActionId = "some example string",
    });
    // TODO: Handle 'response' of type GetTerminalActionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalActionRequest](src/Square/Requests/Terminal/GetTerminalActionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTerminalActionResponse](src/Square/Models/GetTerminalActionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTerminalCheckoutResponse&gt; GetTerminalCheckout(GetTerminalCheckoutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a Terminal checkout request by `checkout_id`. Terminal checkout requests are available for 30 days.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.GetTerminalCheckout(new GetTerminalCheckoutRequest
    {
        CheckoutId = "some example string",
    });
    // TODO: Handle 'response' of type GetTerminalCheckoutResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalCheckoutRequest](src/Square/Requests/Terminal/GetTerminalCheckoutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTerminalCheckoutResponse](src/Square/Models/GetTerminalCheckoutResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTerminalRefundResponse&gt; GetTerminalRefund(GetTerminalRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an Interac Terminal refund object by ID. Terminal refund objects are available for 30 days.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.GetTerminalRefund(new GetTerminalRefundRequest
    {
        TerminalRefundId = "some example string",
    });
    // TODO: Handle 'response' of type GetTerminalRefundResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTerminalRefundRequest](src/Square/Requests/Terminal/GetTerminalRefundRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTerminalRefundResponse](src/Square/Models/GetTerminalRefundResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchTerminalActionsResponse&gt; SearchTerminalActions(SearchTerminalActionsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a filtered list of Terminal action requests created by the account making the request. Terminal action requests are available for 30 days.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.SearchTerminalActions(new SearchTerminalActionsOperationRequest
    {
        Body = new SearchTerminalActionsRequest(),
    });
    // TODO: Handle 'response' of type SearchTerminalActionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchTerminalActionsOperationRequest](src/Square/Requests/Terminal/SearchTerminalActionsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchTerminalActionsResponse](src/Square/Models/SearchTerminalActionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchTerminalCheckoutsResponse&gt; SearchTerminalCheckouts(SearchTerminalCheckoutsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a filtered list of Terminal checkout requests created by the application making the request. Only Terminal checkout requests created for the merchant scoped to the OAuth token are returned. Terminal checkout requests are available for 30 days.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.SearchTerminalCheckouts(new SearchTerminalCheckoutsOperationRequest
    {
        Body = new SearchTerminalCheckoutsRequest(),
    });
    // TODO: Handle 'response' of type SearchTerminalCheckoutsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchTerminalCheckoutsOperationRequest](src/Square/Requests/Terminal/SearchTerminalCheckoutsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchTerminalCheckoutsResponse](src/Square/Models/SearchTerminalCheckoutsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchTerminalRefundsResponse&gt; SearchTerminalRefunds(SearchTerminalRefundsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a filtered list of Interac Terminal refund requests created by the seller making the request. Terminal refund requests are available for 30 days.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Terminal.SearchTerminalRefunds(new SearchTerminalRefundsOperationRequest
    {
        Body = new SearchTerminalRefundsRequest(),
    });
    // TODO: Handle 'response' of type SearchTerminalRefundsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchTerminalRefundsOperationRequest](src/Square/Requests/Terminal/SearchTerminalRefundsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchTerminalRefundsResponse](src/Square/Models/SearchTerminalRefundsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Transactions

> Source: [Transactions](src/Square/Api/Transactions.cs)

<details>
<summary><code>Task&lt;CaptureTransactionResponse&gt; CaptureTransaction(CaptureTransactionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Captures a transaction that was created with the [Charge](api-endpoint:Transactions-Charge)
endpoint with a `delay_capture` value of `true`.


See [Delayed capture transactions](https://developer.squareup.com/docs/payments/transactions/overview#delayed-capture)
for more information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.CaptureTransaction(new CaptureTransactionRequest
    {
        LocationId = "some example string",
        TransactionId = "some example string",
    });
    // TODO: Handle 'response' of type CaptureTransactionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CaptureTransactionRequest](src/Square/Requests/Transactions/CaptureTransactionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CaptureTransactionResponse](src/Square/Models/CaptureTransactionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListTransactionsResponse&gt; ListTransactions(ListTransactionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists transactions for a particular location.

Transactions include payment information from sales and exchanges and refund
information from returns and exchanges.

Max results per [page](https://developer.squareup.com/docs/working-with-apis/pagination): 50

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.ListTransactions(new ListTransactionsRequest
    {
        LocationId = "some example string",
    });
    // TODO: Handle 'response' of type ListTransactionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListTransactionsRequest](src/Square/Requests/Transactions/ListTransactionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListTransactionsResponse](src/Square/Models/ListTransactionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveTransactionResponse&gt; RetrieveTransaction(RetrieveTransactionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details for a single transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.RetrieveTransaction(new RetrieveTransactionRequest
    {
        LocationId = "some example string",
        TransactionId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveTransactionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveTransactionRequest](src/Square/Requests/Transactions/RetrieveTransactionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveTransactionResponse](src/Square/Models/RetrieveTransactionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VoidTransactionResponse&gt; VoidTransaction(VoidTransactionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a transaction that was created with the [Charge](api-endpoint:Transactions-Charge)
endpoint with a `delay_capture` value of `true`.


See [Delayed capture transactions](https://developer.squareup.com/docs/payments/transactions/overview#delayed-capture)
for more information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Transactions.VoidTransaction(new VoidTransactionRequest
    {
        LocationId = "some example string",
        TransactionId = "some example string",
    });
    // TODO: Handle 'response' of type VoidTransactionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VoidTransactionRequest](src/Square/Requests/Transactions/VoidTransactionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VoidTransactionResponse](src/Square/Models/VoidTransactionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransferOrderApi

> Source: [TransferOrderApi](src/Square/Api/TransferOrderApi.cs)

<details>
<summary><code>Task&lt;CancelTransferOrderResponse&gt; CancelTransferOrder(CancelTransferOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a transfer order in [STARTED](entity:TransferOrderStatus) or 
[PARTIALLY_RECEIVED](entity:TransferOrderStatus) status. Any unreceived quantities will no
longer be receivable and will be immediately returned to the source [Location](entity:Location)'s inventory.

Common reasons for cancellation:
- Items no longer needed at destination
- Source location needs the inventory
- Order created in error

Creates a [transfer_order.updated](webhook:transfer_order.updated) webhook event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOrderApi.CancelTransferOrder(new CancelTransferOrderOperationRequest
    {
        TransferOrderId = "some example string",
        Body = new CancelTransferOrderRequest { IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type CancelTransferOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelTransferOrderOperationRequest](src/Square/Requests/TransferOrderApi/CancelTransferOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelTransferOrderResponse](src/Square/Models/CancelTransferOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateTransferOrderResponse&gt; CreateTransferOrder(CreateTransferOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new transfer order in [DRAFT](entity:TransferOrderStatus) status. A transfer order represents the intent 
to move [CatalogItemVariation](entity:CatalogItemVariation)s from one [Location](entity:Location) to another. 
The source and destination locations must be different and must belong to your Square account.

In [DRAFT](entity:TransferOrderStatus) status, you can:
- Add or remove items
- Modify quantities
- Update shipping information
- Delete the entire order via [DeleteTransferOrder](api-endpoint:TransferOrders-DeleteTransferOrder)

The request requires source_location_id and destination_location_id.
Inventory levels are not affected until the order is started via 
[StartTransferOrder](api-endpoint:TransferOrders-StartTransferOrder).

Common integration points:
- Sync with warehouse management systems
- Automate regular stock transfers
- Initialize transfers from inventory optimization systems

Creates a [transfer_order.created](webhook:transfer_order.created) webhook event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOrderApi.CreateTransferOrder(new CreateTransferOrderOperationRequest
    {
        Body = new CreateTransferOrderRequest
        {
            IdempotencyKey = "some example string",
            TransferOrder = new CreateTransferOrderData
            {
                SourceLocationId = "some example string",
                DestinationLocationId = "some example string",
            },
        },
    });
    // TODO: Handle 'response' of type CreateTransferOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTransferOrderOperationRequest](src/Square/Requests/TransferOrderApi/CreateTransferOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateTransferOrderResponse](src/Square/Models/CreateTransferOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteTransferOrderResponse&gt; DeleteTransferOrder(DeleteTransferOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a transfer order in [DRAFT](entity:TransferOrderStatus) status.
Only draft orders can be deleted. Once an order is started via 
[StartTransferOrder](api-endpoint:TransferOrders-StartTransferOrder), it can no longer be deleted.

Creates a [transfer_order.deleted](webhook:transfer_order.deleted) webhook event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOrderApi.DeleteTransferOrder(new DeleteTransferOrderRequest
    {
        TransferOrderId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteTransferOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteTransferOrderRequest](src/Square/Requests/TransferOrderApi/DeleteTransferOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteTransferOrderResponse](src/Square/Models/DeleteTransferOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ReceiveTransferOrderResponse&gt; ReceiveTransferOrder(ReceiveTransferOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Records receipt of [CatalogItemVariation](entity:CatalogItemVariation)s for a transfer order.
This endpoint supports partial receiving - you can receive items in multiple batches.

For each line item, you can specify:
- Quantity received in good condition (added to destination inventory with [InventoryState](entity:InventoryState) of IN_STOCK)
- Quantity damaged during transit/handling (added to destination inventory with [InventoryState](entity:InventoryState) of WASTE)
- Quantity canceled (returned to source location's inventory)

The order must be in [STARTED](entity:TransferOrderStatus) or [PARTIALLY_RECEIVED](entity:TransferOrderStatus) status.
Received quantities are added to the destination [Location](entity:Location)'s inventory according to their condition.
Canceled quantities are immediately returned to the source [Location](entity:Location)'s inventory.

When all items are either received, damaged, or canceled, the order moves to
[COMPLETED](entity:TransferOrderStatus) status.

Creates a [transfer_order.updated](webhook:transfer_order.updated) webhook event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOrderApi.ReceiveTransferOrder(new ReceiveTransferOrderOperationRequest
    {
        TransferOrderId = "some example string",
        Body = new ReceiveTransferOrderRequest
        {
            IdempotencyKey = "some example string",
            Receipt = new TransferOrderGoodsReceipt(),
        },
    });
    // TODO: Handle 'response' of type ReceiveTransferOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReceiveTransferOrderOperationRequest](src/Square/Requests/TransferOrderApi/ReceiveTransferOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ReceiveTransferOrderResponse](src/Square/Models/ReceiveTransferOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveTransferOrderResponse&gt; RetrieveTransferOrder(RetrieveTransferOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a specific [TransferOrder](entity:TransferOrder) by ID. Returns the complete
order details including:

- Basic information (status, dates, notes)
- Line items with ordered and received quantities
- Source and destination [Location](entity:Location)s
- Tracking information (if available)

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOrderApi.RetrieveTransferOrder(new RetrieveTransferOrderRequest
    {
        TransferOrderId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveTransferOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveTransferOrderRequest](src/Square/Requests/TransferOrderApi/RetrieveTransferOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveTransferOrderResponse](src/Square/Models/RetrieveTransferOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchTransferOrdersResponse&gt; SearchTransferOrders(SearchTransferOrdersOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for transfer orders using filters. Returns a paginated list of matching
[TransferOrder](entity:TransferOrder)s sorted by creation date.

Common search scenarios:
- Find orders for a source [Location](entity:Location)
- Find orders for a destination [Location](entity:Location)
- Find orders in a particular [TransferOrderStatus](entity:TransferOrderStatus)

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOrderApi.SearchTransferOrders(new SearchTransferOrdersOperationRequest
    {
        Body = new SearchTransferOrdersRequest(),
    });
    // TODO: Handle 'response' of type SearchTransferOrdersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchTransferOrdersOperationRequest](src/Square/Requests/TransferOrderApi/SearchTransferOrdersOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchTransferOrdersResponse](src/Square/Models/SearchTransferOrdersResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StartTransferOrderResponse&gt; StartTransferOrder(StartTransferOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Changes a [DRAFT](entity:TransferOrderStatus) transfer order to [STARTED](entity:TransferOrderStatus) status.
This decrements inventory at the source [Location](entity:Location) and marks it as in-transit.

The order must be in [DRAFT](entity:TransferOrderStatus) status and have all required fields populated.
Once started, the order can no longer be deleted, but it can be canceled via 
[CancelTransferOrder](api-endpoint:TransferOrders-CancelTransferOrder).

Creates a [transfer_order.updated](webhook:transfer_order.updated) webhook event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOrderApi.StartTransferOrder(new StartTransferOrderOperationRequest
    {
        TransferOrderId = "some example string",
        Body = new StartTransferOrderRequest { IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type StartTransferOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StartTransferOrderOperationRequest](src/Square/Requests/TransferOrderApi/StartTransferOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StartTransferOrderResponse](src/Square/Models/StartTransferOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateTransferOrderResponse&gt; UpdateTransferOrder(UpdateTransferOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing transfer order. This endpoint supports sparse updates,
allowing you to modify specific fields without affecting others.

Creates a [transfer_order.updated](webhook:transfer_order.updated) webhook event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOrderApi.UpdateTransferOrder(new UpdateTransferOrderOperationRequest
    {
        TransferOrderId = "some example string",
        Body = new UpdateTransferOrderRequest
        {
            IdempotencyKey = "some example string",
            TransferOrder = new UpdateTransferOrderData(),
        },
    });
    // TODO: Handle 'response' of type UpdateTransferOrderResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTransferOrderOperationRequest](src/Square/Requests/TransferOrderApi/UpdateTransferOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateTransferOrderResponse](src/Square/Models/UpdateTransferOrderResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## V1Transactions

> Source: [V1Transactions](src/Square/Api/V1Transactions.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V1Order&gt;&gt; V1ListOrders(V1ListOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides summary information for a merchant's online store orders.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.V1ListOrders(new V1ListOrdersRequest
    {
        LocationId = "some example string",
    });
    // TODO: Handle 'response' of type IReadOnlyList<V1Order>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[V1ListOrdersRequest](src/Square/Requests/V1Transactions/V1ListOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V1Order](src/Square/Models/V1Order.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1Order&gt; V1RetrieveOrder(V1RetrieveOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides comprehensive information for a single online store order, including the order's history.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.V1RetrieveOrder(new V1RetrieveOrderRequest
    {
        LocationId = "some example string",
        OrderId = "some example string",
    });
    // TODO: Handle 'response' of type V1Order
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[V1RetrieveOrderRequest](src/Square/Requests/V1Transactions/V1RetrieveOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1Order](src/Square/Models/V1Order.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1Order&gt; V1UpdateOrder(V1UpdateOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the details of an online store order. Every update you perform on an order corresponds to one of three actions:

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.V1Transactions.V1UpdateOrder(new V1UpdateOrderOperationRequest
    {
        LocationId = "some example string",
        OrderId = "some example string",
        Body = new V1UpdateOrderRequest { Action = V1UpdateOrderRequestAction.Complete },
    });
    // TODO: Handle 'response' of type V1Order
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[V1UpdateOrderOperationRequest](src/Square/Requests/V1Transactions/V1UpdateOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1Order](src/Square/Models/V1Order.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Vendors

> Source: [Vendors](src/Square/Api/Vendors.cs)

<details>
<summary><code>Task&lt;BulkCreateVendorsResponse&gt; BulkCreateVendors(BulkCreateVendorsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates one or more [Vendor](entity:Vendor) objects to represent suppliers to a seller.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vendors.BulkCreateVendors(new BulkCreateVendorsOperationRequest
    {
        Body = new BulkCreateVendorsRequest { Vendors = new Dictionary<string, Vendor> { ["key"] = new Vendor() } },
    });
    // TODO: Handle 'response' of type BulkCreateVendorsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkCreateVendorsOperationRequest](src/Square/Requests/Vendors/BulkCreateVendorsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkCreateVendorsResponse](src/Square/Models/BulkCreateVendorsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkRetrieveVendorsResponse&gt; BulkRetrieveVendors(BulkRetrieveVendorsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves one or more vendors of specified [Vendor](entity:Vendor) IDs.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vendors.BulkRetrieveVendors(new BulkRetrieveVendorsOperationRequest
    {
        Body = new BulkRetrieveVendorsRequest(),
    });
    // TODO: Handle 'response' of type BulkRetrieveVendorsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkRetrieveVendorsOperationRequest](src/Square/Requests/Vendors/BulkRetrieveVendorsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkRetrieveVendorsResponse](src/Square/Models/BulkRetrieveVendorsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BulkUpdateVendorsResponse&gt; BulkUpdateVendors(BulkUpdateVendorsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates one or more of existing [Vendor](entity:Vendor) objects as suppliers to a seller.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vendors.BulkUpdateVendors(new BulkUpdateVendorsOperationRequest
    {
        Body = new BulkUpdateVendorsRequest
        {
            Vendors = new Dictionary<string, UpdateVendorRequest>
            {
                ["key"] = new UpdateVendorRequest { Vendor = new Vendor() },
            },
        },
    });
    // TODO: Handle 'response' of type BulkUpdateVendorsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BulkUpdateVendorsOperationRequest](src/Square/Requests/Vendors/BulkUpdateVendorsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BulkUpdateVendorsResponse](src/Square/Models/BulkUpdateVendorsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateVendorResponse&gt; CreateVendor(CreateVendorOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a single [Vendor](entity:Vendor) object to represent a supplier to a seller.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vendors.CreateVendor(new CreateVendorOperationRequest
    {
        Body = new CreateVendorRequest { IdempotencyKey = "some example string" },
    });
    // TODO: Handle 'response' of type CreateVendorResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateVendorOperationRequest](src/Square/Requests/Vendors/CreateVendorOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateVendorResponse](src/Square/Models/CreateVendorResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveVendorResponse&gt; RetrieveVendor(RetrieveVendorRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the vendor of a specified [Vendor](entity:Vendor) ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vendors.RetrieveVendor(new RetrieveVendorRequest { VendorId = "some example string" });
    // TODO: Handle 'response' of type RetrieveVendorResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveVendorRequest](src/Square/Requests/Vendors/RetrieveVendorRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveVendorResponse](src/Square/Models/RetrieveVendorResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchVendorsResponse&gt; SearchVendors(SearchVendorsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Searches for vendors using a filter against supported [Vendor](entity:Vendor) properties and a supported sorter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vendors.SearchVendors(new SearchVendorsOperationRequest
    {
        Body = new SearchVendorsRequest(),
    });
    // TODO: Handle 'response' of type SearchVendorsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchVendorsOperationRequest](src/Square/Requests/Vendors/SearchVendorsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchVendorsResponse](src/Square/Models/SearchVendorsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateVendorResponse&gt; UpdateVendor(UpdateVendorOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing [Vendor](entity:Vendor) object as a supplier to a seller.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vendors.UpdateVendor(new UpdateVendorOperationRequest
    {
        VendorId = "some example string",
        Body = new UpdateVendorRequest { Vendor = new Vendor() },
    });
    // TODO: Handle 'response' of type UpdateVendorResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateVendorOperationRequest](src/Square/Requests/Vendors/UpdateVendorOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateVendorResponse](src/Square/Models/UpdateVendorResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WebhookSubscriptions

> Source: [WebhookSubscriptions](src/Square/Api/WebhookSubscriptions.cs)

<details>
<summary><code>Task&lt;CreateWebhookSubscriptionResponse&gt; CreateWebhookSubscription(CreateWebhookSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a webhook subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhookSubscriptions.CreateWebhookSubscription(
        new CreateWebhookSubscriptionOperationRequest
        {
            Body = new CreateWebhookSubscriptionRequest { Subscription = new WebhookSubscription() },
        });
    // TODO: Handle 'response' of type CreateWebhookSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateWebhookSubscriptionOperationRequest](src/Square/Requests/WebhookSubscriptions/CreateWebhookSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateWebhookSubscriptionResponse](src/Square/Models/CreateWebhookSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeleteWebhookSubscriptionResponse&gt; DeleteWebhookSubscription(DeleteWebhookSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a webhook subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhookSubscriptions.DeleteWebhookSubscription(new DeleteWebhookSubscriptionRequest
    {
        SubscriptionId = "some example string",
    });
    // TODO: Handle 'response' of type DeleteWebhookSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteWebhookSubscriptionRequest](src/Square/Requests/WebhookSubscriptions/DeleteWebhookSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeleteWebhookSubscriptionResponse](src/Square/Models/DeleteWebhookSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListWebhookEventTypesResponse&gt; ListWebhookEventTypes(ListWebhookEventTypesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all webhook event types that can be subscribed to.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhookSubscriptions.ListWebhookEventTypes(new ListWebhookEventTypesRequest());
    // TODO: Handle 'response' of type ListWebhookEventTypesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListWebhookEventTypesRequest](src/Square/Requests/WebhookSubscriptions/ListWebhookEventTypesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListWebhookEventTypesResponse](src/Square/Models/ListWebhookEventTypesResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListWebhookSubscriptionsResponse&gt; ListWebhookSubscriptions(ListWebhookSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all webhook subscriptions owned by your application.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhookSubscriptions.ListWebhookSubscriptions(new ListWebhookSubscriptionsRequest());
    // TODO: Handle 'response' of type ListWebhookSubscriptionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListWebhookSubscriptionsRequest](src/Square/Requests/WebhookSubscriptions/ListWebhookSubscriptionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListWebhookSubscriptionsResponse](src/Square/Models/ListWebhookSubscriptionsResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RetrieveWebhookSubscriptionResponse&gt; RetrieveWebhookSubscription(RetrieveWebhookSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a webhook subscription identified by its ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhookSubscriptions.RetrieveWebhookSubscription(new RetrieveWebhookSubscriptionRequest
    {
        SubscriptionId = "some example string",
    });
    // TODO: Handle 'response' of type RetrieveWebhookSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveWebhookSubscriptionRequest](src/Square/Requests/WebhookSubscriptions/RetrieveWebhookSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RetrieveWebhookSubscriptionResponse](src/Square/Models/RetrieveWebhookSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TestWebhookSubscriptionResponse&gt; TestWebhookSubscription(TestWebhookSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Tests a webhook subscription by sending a test event to the notification URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhookSubscriptions.TestWebhookSubscription(new TestWebhookSubscriptionOperationRequest
    {
        SubscriptionId = "some example string",
        Body = new TestWebhookSubscriptionRequest(),
    });
    // TODO: Handle 'response' of type TestWebhookSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TestWebhookSubscriptionOperationRequest](src/Square/Requests/WebhookSubscriptions/TestWebhookSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TestWebhookSubscriptionResponse](src/Square/Models/TestWebhookSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateWebhookSubscriptionResponse&gt; UpdateWebhookSubscription(UpdateWebhookSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a webhook subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhookSubscriptions.UpdateWebhookSubscription(
        new UpdateWebhookSubscriptionOperationRequest
        {
            SubscriptionId = "some example string",
            Body = new UpdateWebhookSubscriptionRequest(),
        });
    // TODO: Handle 'response' of type UpdateWebhookSubscriptionResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateWebhookSubscriptionOperationRequest](src/Square/Requests/WebhookSubscriptions/UpdateWebhookSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateWebhookSubscriptionResponse](src/Square/Models/UpdateWebhookSubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateWebhookSubscriptionSignatureKeyResponse&gt; UpdateWebhookSubscriptionSignatureKey(UpdateWebhookSubscriptionSignatureKeyOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a webhook subscription by replacing the existing signature key with a new one.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhookSubscriptions.UpdateWebhookSubscriptionSignatureKey(
        new UpdateWebhookSubscriptionSignatureKeyOperationRequest
        {
            SubscriptionId = "some example string",
            Body = new UpdateWebhookSubscriptionSignatureKeyRequest(),
        });
    // TODO: Handle 'response' of type UpdateWebhookSubscriptionSignatureKeyResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateWebhookSubscriptionSignatureKeyOperationRequest](src/Square/Requests/WebhookSubscriptions/UpdateWebhookSubscriptionSignatureKeyOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateWebhookSubscriptionSignatureKeyResponse](src/Square/Models/UpdateWebhookSubscriptionSignatureKeyResponse.cs)</code>

**OnError**: <code>[ApiException](src/Square/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Square/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

