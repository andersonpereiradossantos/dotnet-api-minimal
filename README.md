# Minimal API in .NET 6

[![Licence](https://img.shields.io/npm/l/react)](https://github.com/andersonpereiradossantos/dotcore-api-minimal/blob/master/LICENSE) 

## About code

Minimal API implementation example using .NET 6 and C# 10.


## How to run the project

Prerequisites: .NET 6 or higher.

```powershell
# Clone repository
git clone https://github.com/andersonpereiradossantos/dotcore-api-minimal.git

# Change the SQL Server database connection string in the Program.cs file in:
# options.UseSqlServer("Server=YourHost;Database=Company;User Id=YourUser;Password=YourPassword;");

# Run the migrations
> dotnet ef database update

# Run the project
> dotnet run
```

## License
This project is shared under the MIT license. This means you can modify and use it however you want, even for comercial use. If you liked it, consider marking a ⭐️.

## Articles

* [Writing a Minimal API with .NET 6 (English)](https://dev.to/andersonpereiradossantos/net-6-minimal-apis-55ep)
* [Escrevendo uma Minimal API com .NET 6 (Brazilian Portuguese)](https://www.linkedin.com/pulse/escrevendo-uma-minimal-api-com-net-6-pereira-dos-santos-ctfl/?trackingId=4k1NG0VuSZ2HnYhANfcRMQ%3D%3D)

## Author

Anderson Pereira dos Santos

[Linkedin](https://www.linkedin.com/in/andersonpereirasantos)

[Github](https://github.com/andersonpereiradossantos)
