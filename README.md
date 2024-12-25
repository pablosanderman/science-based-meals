# Science Based Meals

A full-stack application for managing science-based meal planning, consisting of a .NET Web API backend and a Flutter mobile app frontend.

## Project Structure

```
science-based-meals/
├── api/                      # .NET Web API project
│   ├── src/                  # Source code
│   ├── tests/               # Unit and integration tests
│   ├── Dockerfile          # API container configuration
│   └── README.md           # API documentation
├── mobile/                   # Flutter app
│   ├── lib/                # Source code
│   ├── test/              # Tests
│   └── README.md          # Mobile app documentation
├── docker-compose.yml        # Local development setup
└── README.md                # This file
```

## Development Setup

### Prerequisites
- Docker and Docker Compose
- .NET SDK 8.0
- Flutter SDK
- Your favorite IDE (Visual Studio Code, Visual Studio, Android Studio, etc.)

### Running the API
```bash
docker compose up api
```
The API will be available at:
- HTTP: http://localhost:8080
- HTTPS: https://localhost:8443

### Running the Mobile App
Instructions for running the Flutter app will be added once the mobile app development begins.

## Contributing
1. Create a feature branch from main
2. Commit your changes
3. Create a Pull Request

## License
[Add your chosen license here] 