FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /src
COPY ["Models/Models.csproj","Models/Models.csproj"]
COPY ["StudentApp/StudentApp.csproj","StudentApp/StudentApp.csproj"]
RUN dotnet restore "StudentApp/StudentApp.csproj"
COPY . .
WORKDIR /src/StudentApp
RUN dotnet build "StudentApp.csproj" -c Release -o /app/build

FROM build as publish
RUN dotnet publish "StudentApp.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT dotnet StudentApp.dll

