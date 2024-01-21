#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /App

# Build and Publish
COPY . ./
RUN dotnet restore
RUN dotnet build -c Release
RUN dotnet publish -c Release -o out

# Copy to Runtime Image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build /App/out .
EXPOSE 80
ENTRYPOINT ["dotnet", "WebApp.dll"]