# Oxpecker Template

[![NuGet](https://img.shields.io/nuget/v/Oxpecker.Template?logo=nuget)](https://www.nuget.org/packages/Oxpecker.Template)

A .NET project template for creating F# ASP.NET Core applications with Oxpecker.

## Requirements

- .NET 10 SDK

## Installation

The easiest way to install the Oxpecker template is by running the following command in your terminal:

```shell
dotnet new install "Oxpecker.Template@*"
```

You can also install a specific version:

```shell
dotnet new install "Oxpecker.Template@1.1.0"
```

## Updating the template

Update installed templates with:

```shell
dotnet new uninstall Oxpecker.Template
dotnet new install Oxpecker.Template
```

## Getting Started

After installing the template, create a new web application:

### Basic Oxpecker application

```shell
dotnet new oxpecker -n MyApp -o ./my-app
```

### Oxpecker + HTMX application

```shell
dotnet new oxpecker-htmx -n MyApp -o ./my-app
```

After that, run the application:
```shell
dotnet run --project ./my-app
```

These templates provide a starting point for building F# ASP.NET Core applications with Oxpecker.

## Uninstallation

Remove the template with:

```shell
dotnet new uninstall Oxpecker.Template
```

## License

Licensed under [MIT](https://github.com/proskdim/Oxpecker.Template/blob/main/LICENSE).