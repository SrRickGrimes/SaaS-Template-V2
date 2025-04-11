# SaaS Template V2

This is a .NET template I've created to save hours of configuration and development time when starting new enterprise applications or SaaS products. Built with ASP.NET Core (.NET 9) and React Router v7 (formerly Remix).

## Why I Built This

Throughout my career, I've noticed that I repeat many processes in almost every project. I decided to create a template where I could concentrate all this work so I wouldn't have to do it again and accelerate the development process of my projects and products.

## Architecture: Modular Monolith Design

I'm not a fan of microservices. I firmly believe that 99% of projects don't need microservices, and those that do are exceptions. Instead, this template uses a **Modular Monolith** architecture.

### What is a Modular Monolith?

A Modular Monolith is an architectural approach that combines the deployment simplicity of a monolithic application with the organizational benefits of a modular codebase. It allows you to:

- Deploy your application as a single unit
- Maintain clear boundaries between different parts of your application
- Scale development teams more effectively
- Evolve modules independently
- Potentially extract services later if truly needed

This provides the best of both worlds: the simplicity of deployment and operation that comes with a monolith, with the code organization and separation of concerns that microservices aim to achieve.

## Clean Architecture

### What is Clean Architecture?

Clean Architecture is a software design philosophy that separates concerns into layers, making systems more:

- **Maintainable**: Changes in one area don't ripple through the entire system
- **Testable**: Business logic can be tested independently of UI, database, or external services
- **Independent of frameworks**: The core business logic doesn't depend on external frameworks
- **Independent of UI**: The UI can change without affecting the business logic
- **Independent of database**: You can swap database technologies without rewriting business logic

The typical layers in Clean Architecture are:
1. **Domain Layer**: Contains business entities and logic
2. **Application Layer**: Contains business use cases
3. **Infrastructure Layer**: Contains implementations of interfaces defined in inner layers
4. **Presentation Layer**: Contains UI or API controllers

I've created a template that you can download and install with `dotnet new install` and use in Visual Studio 2022. This creates a module ready with projects and examples to work using this architecture.

## Libraries Included

### [FastEndpoints](https://fast-endpoints.com/)
This library is essential for creating clean endpoints using the REPR (Request-Endpoint-Response) design pattern.

#### What is REPR Pattern?
REPR is an alternative to the traditional MVC pattern for building APIs. It focuses on:
- **R**equest: A dedicated request DTO for each endpoint
- **E**ndpoint: A dedicated class for each endpoint
- **P**ipeline: Middleware specific to the endpoint
- **R**esponse: A dedicated response DTO for each endpoint

This leads to more maintainable and focused API code compared to controllers that often grow too large.

### [Ardalis.Result](https://github.com/ardalis/Result)
As part of the architecture, all commands I write use the Result Pattern. This library is excellent for this purpose.

#### What is the Result Pattern?
The Result Pattern is a way to return both success and failure states from methods without resorting to exceptions for control flow. A Result object typically contains:
- Success/failure status
- Error messages if needed
- The actual return value (if successful)
- Additional metadata

This creates more explicit and predictable error handling throughout your application.

### [Microsoft Aspire](https://learn.microsoft.com/en-us/dotnet/aspire/get-started/aspire-overview)
Essential for logging, tracing, and orchestrating services during development.

### [Scalar](https://github.com/scalar/scalar)
An excellent alternative to Swagger UI (much better in my personal experience).

## Getting Started

Go to the releases section where you can download the zip and the NuGet package. To install it, unzip the file and you'll have the solution ready to use.
