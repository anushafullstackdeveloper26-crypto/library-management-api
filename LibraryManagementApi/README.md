# library management system – web api

this project is built using asp.net core web api (.net 8) with entity framework core and sql server.

features:
- create, read, update, delete books
- dependency injection
- repository and service pattern
- swagger for api testing

tech stack:
- .net 8
- asp.net core web api
- entity framework core
- sql server

how to run:
1. update sql connection string in appsettings.json
2. run ef core migration 
	i.Add-Migration InitialCreate
	ii.Update-Database
3. run the application
4. open /swagger to test apis
