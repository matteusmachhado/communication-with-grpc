#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 6101
EXPOSE 6102

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/services/Project.WMS.Product.WebAPI/Project.WMS.Product.WebAPI.csproj", "src/services/Project.WMS.Product.WebAPI/"]
RUN dotnet restore "./src/services/Project.WMS.Product.WebAPI/Project.WMS.Product.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/services/Project.WMS.Product.WebAPI"
RUN dotnet build "./Project.WMS.Product.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Project.WMS.Product.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project.WMS.Product.WebAPI.dll"]