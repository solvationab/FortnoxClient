# Solvation Fortnox client

A basic Fortnox client maintained by Solvation AB.

## Getting started

Install and register using .AddFortnoxClient service collection extension

### Prerequisites

It's required to have a Fortnox account and an API key.

## Usage

```csharp
var fortnoxClient = serviceProvider.GetRequiredService<IFortnoxClient>();
var customers = await fortnoxClient.GetCustomersAsync();
```

## Additional documentation

- [Fortnox API developer](https://www.fortnox.se/developer/)
- [Fortnox](https://www.fortnox.se/)

## Feedback

https://github.com/solvationab/FortnoxClient
