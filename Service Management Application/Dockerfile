FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Service Management Application/Service Management Application.csproj", "Service Management Application/"]
RUN dotnet restore "Service Management Application/Service Management Application.csproj"
COPY . .
WORKDIR "/src/Service Management Application"
RUN dotnet build "Service Management Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Service Management Application.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Service Management Application.dll"]
