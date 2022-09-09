FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BigO.csproj", "./"]
RUN dotnet restore "BigO.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "BigO.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BigO.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BigO.dll"]
