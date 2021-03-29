FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MassTransit.Docker.csproj", "MassTransit.Docker/"]
RUN dotnet restore "MassTransit.Docker/MassTransit.Docker.csproj"

COPY . MassTransit.Docker/.
RUN dotnet publish -c Release -o /app MassTransit.Docker/MassTransit.Docker.csproj 

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS publish
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "MassTransit.Docker.dll"]