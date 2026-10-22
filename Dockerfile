# API'nin Render'da çalışan imajı. Masaüstü programı ve paketleyici bu imaja girmez.

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS derleme
WORKDIR /kaynak

COPY Modeller/Modeller.csproj Modeller/
COPY Api/Api.csproj Api/
RUN dotnet restore Api/Api.csproj

COPY Modeller/ Modeller/
COPY Api/ Api/
RUN dotnet publish Api/Api.csproj -c Release -o /uygulama --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /uygulama
COPY --from=derleme /uygulama .
USER $APP_UID

# Render, dinlenecek portu PORT değişkeniyle verir.
CMD ["sh", "-c", "ASPNETCORE_HTTP_PORTS=${PORT:-8080} exec dotnet Api.dll"]
