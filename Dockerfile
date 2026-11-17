# Etapa de compilación
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY . .

# Comprobar archivos recibidos en el contexto de Docker
RUN ls -la

# Restaurar el proyecto correcto de TecnoMarket
RUN dotnet restore ./TecnoMarket.csproj

# Publicar el proyecto en modo Release
RUN dotnet publish ./TecnoMarket.csproj \
    -c Release \
    -o /app/publish \
    --no-restore

# Etapa de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

# Render requiere escuchar en el puerto 10000
ENV ASPNETCORE_URLS=http://+:10000

EXPOSE 10000

ENTRYPOINT ["dotnet", "TecnoMarket.dll"]