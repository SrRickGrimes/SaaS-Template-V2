# FastEndpoints: A Modern Minimal API Framework for .NET

## What is FastEndpoints?

FastEndpoints is a powerful, developer-friendly API framework for .NET that provides a clean, code-first approach to building HTTP endpoints. It combines the performance benefits of minimal APIs with the organization and structure of a controller-based architecture, offering the best of both worlds.

## Key Features

- **High Performance**: Optimized for speed with minimal overhead
- **Minimal API Approach**: Clean, focused endpoint implementation
- **Structured Organization**: Each endpoint in its own class for better separation of concerns
- **Request/Response Pattern**: Built-in support for strong typing of requests and responses
- **Validation**: Built-in validation capabilities
- **Testing**: First-class support for integration testing
- **Low Ceremony**: Minimal boilerplate code required

## Installation Guide

### Prerequisites

Before installing FastEndpoints, ensure you have:

- **.NET SDK**: .NET 6.0 or higher

### Installation Steps

To create a new project and install FastEndpoints:

```bash
dotnet new web -n MyWebApp
cd MyWebApp
dotnet add package FastEndpoints
```

## Getting Started

### Setting Up Your Application

First, configure your application in `Program.cs`:

```csharp
using FastEndpoints;

var bld = WebApplication.CreateBuilder();
bld.Services.AddFastEndpoints();

var app = bld.Build();
app.UseFastEndpoints();
app.Run();
```

### Creating Your First Endpoint

Follow these steps to create a simple endpoint:

#### 1. Create a Request DTO

```csharp
// MyRequest.cs
public class MyRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}
```

#### 2. Create a Response DTO

```csharp
// MyResponse.cs
public class MyResponse
{
    public string FullName { get; set; }
    public bool IsOver18 { get; set; }
}
```

#### 3. Create an Endpoint Class

```csharp
// MyEndpoint.cs
public class MyEndpoint : Endpoint<MyRequest, MyResponse>
{
    public override void Configure()
    {
        Post("/api/user/create");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MyRequest req, CancellationToken ct)
    {
        await SendAsync(new()
        {
            FullName = req.FirstName + " " + req.LastName,
            IsOver18 = req.Age > 18
        });
    }
}
```

#### 4. Run and Test

Start your application and send a POST request to `/api/user/create` with a JSON body like:

```json
{
  "FirstName": "Marlon",
  "LastName": "Brando",
  "Age": 40
}
```

You should receive a response:

```json
{
  "FullName": "Marlon Brando",
  "IsOver18": true
}
```

## Understanding Endpoint Types

FastEndpoints offers four different base types for endpoints:

1. **Endpoint\<TRequest\>**
   - For endpoints with only a request DTO
   - Can still send serializable responses

2. **Endpoint\<TRequest, TResponse\>**
   - For endpoints with both request and response DTOs
   - Provides strongly-typed access for testing and validation

3. **EndpointWithoutRequest**
   - For endpoints with no request or response DTOs
   - Can send any serializable object as response

4. **EndpointWithoutRequest\<TResponse\>**
   - For endpoints with no request DTO but with a response DTO

You can also use `EmptyRequest` and `EmptyResponse` types:

```csharp
public class MyEndpoint : Endpoint<EmptyRequest, EmptyResponse> { }
```

### Fluent Generics

FastEndpoints offers a fluent syntax for endpoint definition:

```csharp
// Equivalent of Endpoint<TRequest>
public class MyEndpoint : Ep.Req<MyRequest>.NoRes { }

// Equivalent of Endpoint<TRequest,TResponse>
public class MyEndpoint : Ep.Req<MyRequest>.Res<MyResponse> { }

// Equivalent of EndpointWithoutRequest
public class MyEndpoint : Ep.NoReq.NoRes { }

// Equivalent of EndpointWithoutRequest<TResponse>
public class MyEndpoint : Ep.NoReq.Res<MyResponse> { }
```

## Sending Responses

There are multiple ways to send responses:

### Using the Response Property

You can simply populate the `Response` property:

```csharp
public override async Task HandleAsync(CancellationToken ct)
{
    var person = await dbContext.GetFirstPersonAsync();

    Response.FullName = person.FullName;
    Response.Age = person.Age;
}
```

Or assign a new instance to it:

```csharp
public override Task HandleAsync(CancellationToken ct)
{
    Response = new()
    {
        FullName = "john doe",
        Age = 124
    };
    return Task.CompletedTask;
}
```

### Using Union Types (.NET 7+)

FastEndpoints supports union types for multiple possible responses:

```csharp
public class MyEndpoint : Endpoint<MyRequest, 
                               Results<Ok<MyResponse>, 
                                       NotFound, 
                                       ProblemDetails>>
{
    public override void Configure() { ... }

    public override async Task<Results<Ok<MyResponse>, NotFound, ProblemDetails>> ExecuteAsync(
        MyRequest req, CancellationToken ct)
    {
        await Task.CompletedTask; // Simulate async work

        if (req.Id == 0) // Condition for a not found response
        {
            return TypedResults.NotFound();
        }

        if (req.Id == 1) // Condition for a problem details response
        {
            AddError(r => r.Id, "value has to be greater than 1");
            return new FastEndpoints.ProblemDetails(ValidationFailures);
        }

        // 200 OK response with a DTO
        return TypedResults.Ok(new MyResponse
        {
            RequestedId = req.Id
        });
    }
}
```

## Configuring with Attributes

Instead of overriding the `Configure()` method, you can use attributes:

```csharp
[HttpPost("/my-endpoint")]
[Authorize(Roles = "Admin,Manager")]
[PreProcessor<MyProcessor>]
public class MyEndpoint : Endpoint<MyRequest, MyResponse>
{
    // ...
}
```

Available attributes include:
- `[Http{VERB}("/route")]` - Sets up verb and route
- `[AllowAnonymous]` - Allows unauthenticated access
- `[AllowFileUploads]` - Allows file uploads with multipart/form-data
- `[Authorize(...)]` - Specifies authorization requirements
- `[Group<TGroup>]` - Associates endpoint with a configuration group
- `[PreProcessor<TProcessor>]` - Adds a pre-processor
- `[PostProcessor<TProcessor>]` - Adds a post-processor

## Working with Cancellation Tokens

FastEndpoints provides cancellation token support for asynchronous operations:

```csharp
public override async Task HandleAsync(MyRequest req, CancellationToken ct)
{
    // Pass the token to your async methods
    var data = await _repository.GetDataAsync(ct);
    
    // No need to explicitly pass the token to SendAsync
    // It automatically uses the same token from HandleAsync
    await SendAsync(new MyResponse { ... });
}
```

## Next Steps

After mastering the basics:

1. **Add validation** to your request DTOs
2. **Implement authorization** for secure endpoints
3. **Set up dependency injection** for your endpoints
4. **Create integration tests** for your API
5. **Explore more advanced features** like versioning and documentation

## Resources

- [Official GitHub Repository](https://github.com/FastEndpoints/FastEndpoints)
- [Documentation](https://fast-endpoints.com/)
- [NuGet Package](https://www.nuget.org/packages/FastEndpoints/)