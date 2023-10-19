# started with: https://github.com/microsoft/dotnet-framework-docker/blob/master/samples/wcfapp/Dockerfile.console

FROM mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2022 AS build-machine
WORKDIR /app
COPY . .
RUN msbuild /p:Configuration=Release



FROM mcr.microsoft.com/dotnet/framework/runtime:4.8-windowsservercore-ltsc2022 AS prod-machine
WORKDIR /app
COPY --from=build-machine /app/bin/Release .
ENTRYPOINT FooService.exe
