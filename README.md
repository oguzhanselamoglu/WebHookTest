# WebHookTest

I use M1 chip, which uses ARM architecture. This can cause a problem when trying to install SQL Server. SQL Server isn’t supported on the ARM architecture.
That's why I use an alternative. The container image for Azure SQL Edge can be installed on the M1 Mac. Therefore, we can use that image instead of the SQL Server image.
[Azure Sql Edge Docker image](https://hub.docker.com/_/microsoft-azure-sql-edge)

# Docker Compose
```bash 
  sqlserver:
    image: mcr.microsoft.com/azure-sql-edge
    environment:
      ACCEPT_EULA: "Y"
      MSSQL_USER: "SA"
      MSSQL_SA_PASSWORD: "p@ssw0rd"
      MSSQL_PID: "Developer"      
    ports:
      - "1433:1433"
```