FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app

FROM base AS development
WORKDIR /app
COPY ["src/ScienceBasedMealsApi.csproj", "src/"]
RUN dotnet restore "src/ScienceBasedMealsApi.csproj"
COPY src/. src/
RUN dotnet tool install --global dotnet-ef
ENV PATH="${PATH}:/root/.dotnet/tools"
ENTRYPOINT ["dotnet", "watch", "--project", "src/ScienceBasedMealsApi.csproj", "run", "--urls", "http://+:80"]

FROM base AS build
WORKDIR /src
COPY ["src/ScienceBasedMealsApi.csproj", "./"]
RUN dotnet restore
COPY src/. .
RUN dotnet tool install --global dotnet-ef
ENV PATH="${PATH}:/root/.dotnet/tools"
RUN dotnet ef migrations add InitialCreate
RUN dotnet build -c Release -o /app/build
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS production
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "ScienceBasedMealsApi.dll"] 