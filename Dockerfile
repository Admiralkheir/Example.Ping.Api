
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
COPY ./Publish .
ENTRYPOINT ["dotnet", "Example.Ping.Api.dll"]