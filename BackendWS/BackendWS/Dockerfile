FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BackendWS/BackendWS.csproj", "BackendWS/"]
RUN dotnet restore "BackendWS/BackendWS.csproj"
COPY . .
WORKDIR "/src/BackendWS"
RUN dotnet build "BackendWS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BackendWS.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BackendWS.dll"]
