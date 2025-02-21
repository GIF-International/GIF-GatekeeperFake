# Base runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 5000

# Build stage: Restore, build, and publish the project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
ENV ASPNETCORE_ENVIRONMENT=Release

# Copy only project files first (Optimized Docker layer caching)
COPY ["GatekeeperFake.gRPC/GatekeeperFake.gRPC.csproj", "GatekeeperFake.gRPC/"]
RUN dotnet restore "GatekeeperFake.gRPC/GatekeeperFake.gRPC.csproj"

# Copy the rest of the source files and build
COPY . .
WORKDIR "/src/GatekeeperFake.gRPC"
RUN dotnet build "GatekeeperFake.gRPC.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
ARG configuration
RUN dotnet publish "GatekeeperFake.gRPC.csproj" -c Release -o /app/publish /p:UseAppHost=false && \
    dotnet dev-certs https --trust

# Final stage: Copy published app and install dependencies
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

    #openssl req -x509 -newkey rsa:4096 -keyout chave.pem -out certificado.pem -days 365 -nodes && \
    #openssl req -x509 -newkey rsa:4096 -keyout chave.pem -out certificado.pem -days 365 -nodes \
    #-subj "/C=BR/ST=SaoPaulo/L=SaoPaulo/O=./OU=./CN=localhost/emailAddress=." && \
    #openssl pkcs12 -export -out certificado.pfx -inkey chave.pem -in certificado.pem -passout pass:Q!w2e3r4t5 && \
# Install timezone data and others
RUN apt-get update && \
    apt-get install -y --no-install-recommends tzdata ca-certificates openssl && \
    ln -sf /usr/share/zoneinfo/America/Sao_Paulo /etc/localtime && \
    echo "America/Sao_Paulo" > /etc/timezone && \
    dpkg-reconfigure -f noninteractive tzdata && \
    apt-get update && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

ENTRYPOINT ["dotnet", "GatekeeperFake.gRPC.dll"]
