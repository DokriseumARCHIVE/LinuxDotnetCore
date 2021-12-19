FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LinuxDotnetCore/LinuxDotnetCore.csproj", "LinuxDotnetCore/"]
RUN dotnet restore "LinuxDotnetCore/LinuxDotnetCore.csproj"
COPY . .
WORKDIR "/src/LinuxDotnetCore"
RUN dotnet build "LinuxDotnetCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LinuxDotnetCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LinuxDotnetCore.dll"]
