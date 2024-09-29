#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["OnlineSurvey/OnlineSurvey.csproj", "OnlineSurvey/"]
COPY ["OnlineSurvey.Application/OnlineSurvey.Application.csproj", "OnlineSurvey.Application/"]
COPY ["OnlineSurvey.Core/OnlineSurvey.Core.csproj", "OnlineSurvey.Core/"]
COPY ["OnlineSurvey.Persistence/OnlineSurvey.Persistence.csproj", "OnlineSurvey.Persistence/"]
RUN dotnet restore "./OnlineSurvey/OnlineSurvey.csproj"
COPY . .
WORKDIR "/src/OnlineSurvey"
RUN dotnet build "./OnlineSurvey.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./OnlineSurvey.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineSurvey.dll"]