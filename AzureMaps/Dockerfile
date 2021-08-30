FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AzureMaps/AzureMaps.csproj", "AzureMaps/"]
RUN dotnet restore "AzureMaps/AzureMaps.csproj"
COPY . .
WORKDIR "/src/AzureMaps"
RUN dotnet build "AzureMaps.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AzureMaps.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AzureMaps.dll"]
