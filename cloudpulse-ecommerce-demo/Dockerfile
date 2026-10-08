# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project file and restore dependencies
COPY ["cloudpulse-ecommerce-demo.csproj", "./"]
RUN dotnet restore "cloudpulse-ecommerce-demo.csproj"

# Copy remaining source code and publish
COPY . .
RUN dotnet publish "cloudpulse-ecommerce-demo.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_HTTP_PORTS=8080

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "cloudpulse-ecommerce-demo.dll"]