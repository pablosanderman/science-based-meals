# Science Based Meals API

The backend API for the Science Based Meals application, built with ASP.NET Core.

## Project Structure

```
api/
├── src/                 # Source code
│   ├── Controllers/    # API endpoints
│   ├── Models/        # Domain models
│   ├── Services/      # Business logic
│   └── Data/         # Database context and configurations
├── tests/              # Test projects
│   ├── Unit/         # Unit tests
│   └── Integration/  # Integration tests
└── Dockerfile         # Container configuration
```

## Development

### Prerequisites
- .NET SDK 8.0
- Docker (optional, for containerized development)

### Running Locally

1. Without Docker:
```bash
cd src
dotnet restore
dotnet run
```

2. With Docker:
```bash
# From the root directory
docker compose up api
```

### Running Tests
```bash
cd tests
dotnet test
```

## API Documentation

The API documentation is available at `/swagger` when running in Development mode.

## Database Migrations

```bash
cd src
dotnet ef migrations add [MigrationName]
dotnet ef database update
``` 