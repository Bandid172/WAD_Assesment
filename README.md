# Contact Manager Application

This application was developed for Web Application module, as coursework portfolio project @ WIUT by student ID: 00016848

## Prerequisites

Before running the Contact Manager Application, ensure that the following software is installed on your machine:

### 1. **.NET SDK**  
   This application is built using ASP.NET, so you need to have the .NET SDK installed. You can download it from the official .NET website:  
   [Download .NET SDK](https://dotnet.microsoft.com/download)

   To check if .NET SDK is installed, run the following command:
   ```bash
   dotnet --version
   ```
### 2. Visual Studio or Visual Studio Code
  Visual Studio (recommended for full support with ASP.NET): You can download it from:
  Download Visual Studio
  Alternatively, you can use Visual Studio Code with the appropriate extensions for .NET development:
  Download Visual Studio Code

### 3. SQL Server (For Database)

The application uses SQL Server to store contact information. You can use either a local SQL Server instance or a cloud-based service.

SQL Server Express (free edition) can be downloaded from:
Download SQL Server Express
If you prefer to use a cloud database, you can use Azure SQL Database.
Ensure that the SQL Server is running, and configure the connection string in the application settings.

### Installation.

1. git clone https://github.com/Bandid172/WAD_Assesment.git
2. Open the project in Visual Studio or Visual Studio Code.
3. ```bash
   dotnet restore
   ```
4. Set up the database:
Ensure SQL Server is running.
Update the connection string in the appsettings.json file with your SQL Server details.
You may need to apply migrations to set up the database schema:
```bash
  dotnet ef database update
```
5. Build and run the application:
```bash
   dotnet run
```
