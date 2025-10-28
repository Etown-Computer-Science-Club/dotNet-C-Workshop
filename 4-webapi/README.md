# 4 — Minimal Web API

Run:

```bash
dotnet restore
dotnet run
```

# How to start From scratch

```
dotnet new webapi -n MyApi
cd MyApi
dotnet run
```

Open Swagger UI:

- https://localhost:7240/swagger

Test Endpoints:

- `GET /api/products`
- `GET /api/products/{id}`
- `POST /api/products` (Raw body: `"Headset"`)
- `DELETE /api/products/{id}`
