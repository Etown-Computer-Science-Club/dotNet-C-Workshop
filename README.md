# Intro to .NET 8 & C# — Workshop

Welcome! This hands-on workshop takes you from your first C# console program to building a minimal Web API (and an Blazor Server demo).

## Prereqs

- .NET 8 SDK installed (Windows/macOS/Linux)
- VS Code (C# Dev Kit) or Visual Studio 2022
- (Optional) Postman or curl for API testing

## Structure

```
dotnet-workshop/
├── setup/                     # OS-specific setup guides
├── 1-hello-world/             # Basics & C# syntax
├── 2-oop-basics/              # Classes, encapsulation, methods
├── 3-linq-and-collections/    # Lists, LINQ querying
├── 4-webapi/                  # Minimal REST API
└── 5-blazor-demo/             # Blazor Server demo
```

## Quickstart

Open any folder and run:

```bash
dotnet restore
dotnet run
```

## Building your first project

```
dotnet new console -n MyApp
cd MyApp
dotnet run
```

### Recommended order

1. 1-hello-world
2. 2-oop-basics
3. 3-linq-and-collections
4. 4-webapi
5. 5-blazor-demo (optional)
