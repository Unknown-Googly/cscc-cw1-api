FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
WORKDIR /build

COPY *.csproj .
RUN dotnet restore

COPY . ./
RUN dotnet publish -c release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine-amd64
WORKDIR /app
EXPOSE 80
COPY --from=build /build/out ./ 

ENTRYPOINT ["dotnet", "./cw1_8567_proxy.dll"]
