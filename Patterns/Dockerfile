FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Delegates/Delegates.csproj", "Delegates/"]
RUN dotnet restore "Delegates/Delegates.csproj"
COPY . .
WORKDIR "/src/Delegates"
RUN dotnet build "Delegates.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Delegates.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Delegates.dll"]
