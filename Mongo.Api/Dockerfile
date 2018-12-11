FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Mongo.Api/Mongo.Api.csproj Mongo.Api/
RUN dotnet restore Mongo.Api/Mongo.Api.csproj
COPY . .
WORKDIR /src/Mongo.Api
RUN dotnet build Mongo.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Mongo.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Mongo.Api.dll"]
