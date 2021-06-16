# DataBridge EntityView
 ASP REST and GraphQL Repository with Razor UI


<How to start>
=============================================================================
Open Solution "DataBridge" and start debugging session with IIS.
This is opening the databridge on https://localhost:44386/swagger/index.html.
You can query it by REST or by GraphQL. (See startup.cs)

<Start Second Project>
=============================================================================
Open Solution "Entity View". 
Start it with IIS and debug it. (Should emerge on https://localhost:44320).
You should now be able to create companies, users and factories.

<Notes>
=============================================================================
Remember, you are in a Razor (Blazor?) Environment, which means, you are
in a single-page environment.
It is difficult to implement templates in this Environment.

This solution was made on March 2021, which means
Microsoft will have been able to adapt his solutions to a more 
frequent environment.

Also, it seems, you have to use exactly this setup, which includes
Dapper and "GraphQL" libraries. Save your progress before switching to
other versions.

<Database>
=============================================================================
On the root, you find the database file.
We have tried SQL Server Express for this solution.
Establish a connection, adapt your connectionstring and create your objects.

Additionally, each object follows a mapping through the repository structure.
Try it out and create your custom objects.

_____________________________________________________________________________
soulflick.com