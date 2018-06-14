# ASP.NET-Event-Manager
ASP.NET Event Manager project


Setup Guide:

Before the project can be started, an empty database
must be created in SQL Server for the tables stored
in EventManagerDB to have a place to be created.
If the database is not named "TSB_Event_Manager" then
the name of the catalog in the connection strings will
have to be changed to fit it after publishing.

We open the project in Visual Studio and right-click
EventManagerDB, selecting publish. We select our connection
to the SQL Server and select our newly created empty database.
If the host of the SQL Server has any suffix after his hostname
e.g. "USERNAME\SQPEXPRESS" or "USERNAME\SQLSERVER" then that will have
to be changed in the two connection strings.

After the database is published we open up Web.config in our EventManager
project, we seek out the ConnectionString node and change the source to fit
the address of our server, no changes would be necessary if the local server
can be referenced as localhost or a full stop. The catalog field must be 
changed to fit the name of the database if it was not named "TSB_Event_Manager"
as stated previously.

Once the database has been published and the connection strings edited the 
application can be started by pressing Ctrl+F5.
