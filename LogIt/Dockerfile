FROM mcr.microsoft.com/dotnet/core/runtime:2.2-stretch-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["LogIt/LogIt.csproj", "LogIt/"]
RUN dotnet restore "LogIt/LogIt.csproj"
COPY . .
WORKDIR "/src/LogIt"
RUN dotnet build "LogIt.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "LogIt.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LogIt.dll"]