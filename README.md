# DevOpsLabs1


# HarvardUniversity.API

## Description

This project is an ASP.NET Core Web API for managing Harvard University items. It includes configurations for logging, database context, AutoMapper, and Swagger for API documentation.

## Project Structure

- **Contracts**: Contains interfaces for the services.
- **Properties**: Contains Swagger response examples and other properties.
- **Repositories**: Contains the implementation of the repository pattern.
- **Data**: Contains the database context `HarvardUniversityContext`.
- **LoggerService**: Contains the logging service implementation.

## Installation

1. Clone the repository:
  
    git clone https://gitlab.com/kp47014139/devopslabs1
    cd your-repository-directory 


2. Install dependencies:
    
    dotnet restore


## Usage

### Database Setup

1. Update the connection string in the `appsettings.json` file:
    
    {
       "ConnectionStrings": {
           "DefaultConnection": "YourConnectionStringHere"
       }
    }


2. Apply migrations to create the database:
    
    dotnet ef database update


### Running the Application

1. Build and run the application:
    
    dotnet run


2. The API will be available at `https://localhost:5001` (or the port specified in your launch settings).

### Swagger

Swagger is configured to provide API documentation. You can access it at `https://localhost:5001/swagger` when running the application in development mode.

## Configuration

### Logging

NLog is configured for logging. The configuration file `nlog.config` is loaded during application startup.

### AutoMapper

AutoMapper is configured in the `Program.cs` file with a profile named `Mapping`.

### Dependency Injection

The following services are registered for dependency injection:
- `ILoggerManager` for logging.
- `HarvardUniversityContext` for the database context.
- `IUnitOfWork` for the unit of work pattern.
- AutoMapper.

## Running in Docker

### Prerequisites

- Docker installed on your machine.

### Building the Docker Image

1. Create a `Dockerfile` in the root of your project with the following content:

	```dockerfile
	FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
	WORKDIR /app
	EXPOSE 80

	FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
	WORKDIR /src
	COPY ["HarvardUniversity.API/HarvardUniversity.API.csproj", "HarvardUniversity.API/"]
	RUN dotnet restore "HarvardUniversity.API/HarvardUniversity.API.csproj"
	COPY . .
	WORKDIR "/src/HarvardUniversity.API"
	RUN dotnet build "HarvardUniversity.API.csproj" -c Release -o /app/build

	FROM build AS publish
	RUN dotnet publish "HarvardUniversity.API.csproj" -c Release -o /app/publish

	FROM base AS final
	WORKDIR /app
	COPY --from=publish /app/publish .
	ENTRYPOINT ["dotnet", "HarvardUniversity.API.dll"]
	```

2. Build the Docker image:

	```bash
	docker build -t harvard-university-api .
	``
### Running the Docker Container

1. Run the Docker container:

	```bash
	docker run -d -p 8080:80 --name harvard-university-api harvard-university-api
	```
2. The API will be available at `http://localhost:8080`.

## Authors

- Kp4b

## License

This project is licensed under the MIT License. See the LICENSE file for details.

    