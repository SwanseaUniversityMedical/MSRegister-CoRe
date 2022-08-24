#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["MSRegister-CoRe/MSRegister-CoRe.csproj", "MSRegister-CoRe/"]
RUN dotnet restore "MSRegister-CoRe/MSRegister-CoRe.csproj"
COPY . .
WORKDIR "/src/MSRegister-CoRe"
RUN dotnet build "MSRegister-CoRe.csproj" -c Release -o /app/build
RUN sed -i 's/DEFAULT@SECLEVEL=2/DEFAULT@SECLEVEL=1/g' /etc/ssl/openssl.cnf

FROM build AS publish
RUN dotnet publish "MSRegister-CoRe.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MSRegister-CoRe.dll"]