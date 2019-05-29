FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ECommerce/ECommerce.csproj", "ECommerce/"]
RUN dotnet restore "ECommerce/ECommerce.csproj"
COPY . .
WORKDIR "/src/ECommerce"
RUN dotnet build "ECommerce.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ECommerce.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ECommerce.dll"]