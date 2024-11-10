#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/services/Project.WMS.AuthenticationProvider.WebAPI/Project.WMS.AuthenticationProvider.WebAPI.csproj", "src/services/Project.WMS.AuthenticationProvider.WebAPI/"]
RUN dotnet restore "./src/services/Project.WMS.AuthenticationProvider.WebAPI/Project.WMS.AuthenticationProvider.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/services/Project.WMS.AuthenticationProvider.WebAPI"
RUN dotnet build "./Project.WMS.AuthenticationProvider.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Project.WMS.AuthenticationProvider.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project.WMS.AuthenticationProvider.WebAPI.dll"]