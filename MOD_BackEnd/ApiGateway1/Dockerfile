FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["ApiGateway1/ApiGateway1.csproj", "ApiGateway1/"]
RUN dotnet restore "ApiGateway1/ApiGateway1.csproj"
COPY . .
WORKDIR "/src/ApiGateway1"
RUN dotnet build "ApiGateway1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiGateway1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiGateway1.dll"]