FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HayVentilation.Client/HayVentilation.Client.csproj", "HayVentilation.Client/"]
RUN dotnet restore "HayVentilation.Client/HayVentilation.Client.csproj"
COPY . .
WORKDIR "/src/HayVentilation.Client"
RUN dotnet build "HayVentilation.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HayVentilation.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HayVentilation.Client.dll"]
