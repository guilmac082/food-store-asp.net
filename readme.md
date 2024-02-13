# BUYNOW - online food shop

### Installing

A step by step series of examples that tell you how to get a development env running

Say what the step will be
After cloning or downloading project, there are some steps you need to do in order to run application, depends on which
operation system are you using

### Admin users credentails

    Username: admin@mail.com
    Password: aA1234

#### Windows

-   You need to have .Net Core 2.2 installed on your machine
-   MSSQL localdb server

### MacOs

-   You need to have .Net Core 2.2 installed on your machine
-   Sqlite3 installed

### Linux

-   You need to have .Net Core 2.2 installed on your machine
-   PostgreSql installed, and configured to have user with
    -- User id: postgres
    -- Password: password

PostgreSql server will run on localhost:5432 by default, you can change setings from 'appsettings.Development.json' file
![Screenshot-20190608104225-2226x428](https://user-images.githubusercontent.com/28567416/59143265-39605080-89da-11e9-9445-955afc5db111.png)

## How to Run

In order to run application you need to go Shop.Web project, and execute commands in bash/terminal below
This will run application in default mode

    dotnet run

This will run application, and start watch, each time you make changes in c# code, application will restart automatically

    dotnet watch run

After running application, you should see output something like this

<img width="500" heigth="500" src= "https://user-images.githubusercontent.com/28567416/59143447-59910f00-89dc-11e9-9730-2f786b97d588.png" />

## Running the tests

Currently there are no tests to run

## Built With

-   [Asp.Net Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.2) - The web framework used
-   [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - ORM
-   Sql servers
    -   [Microsoft SQL server](https://www.microsoft.com/en-us/sql-server/sql-server-2019) - Used Sql server for windows
    -   [Postgre SQL](https://www.postgresql.org/) - Used Sql server for linux
    -   [SQLite](https://www.sqlite.org/) - Used Sql server for MacOs
