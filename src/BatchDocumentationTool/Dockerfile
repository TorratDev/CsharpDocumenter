FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BatchDocumentationTool/BatchDocumentationTool.csproj", "BatchDocumentationTool/"]
RUN dotnet restore "BatchDocumentationTool/BatchDocumentationTool.csproj"
COPY . .
WORKDIR "/src/BatchDocumentationTool"
RUN dotnet build "BatchDocumentationTool.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "BatchDocumentationTool.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BatchDocumentationTool.dll"]
