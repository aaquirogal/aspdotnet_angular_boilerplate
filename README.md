# Important

Issues of this repository are tracked on https://github.com/aspnetboilerplate/aspnetboilerplate. Please create your issues on https://github.com/aspnetboilerplate/aspnetboilerplate/issues.

# Introduction

This is a template to create **ASP.NET Core MVC / Angular** based startup projects for [ASP.NET Boilerplate](https://aspnetboilerplate.com/Pages/Documents). It has 2 different versions:

1. [ASP.NET Core MVC & jQuery](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core) (server rendered multi-page application).
2. [ASP.NET Core & Angular](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular) (single page application).
 
User Interface is based on [AdminLTE theme](https://github.com/ColorlibHQ/AdminLTE).
 
# Download

Create & download your project from https://aspnetboilerplate.com/Templates

# Screenshots

#### Sample Dashboard Page
![](_screenshots/module-zero-core-template-ui-home.png)

#### User Creation Modal
![](_screenshots/module-zero-core-template-ui-user-create-modal.png)

#### Login Page

![](_screenshots/module-zero-core-template-ui-login.png)

# Documentation

* [ASP.NET Core MVC & jQuery version.](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core)
* [ASP.NET Core & Angular  version.](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular)

# License

[MIT](LICENSE).


# Deployment

## SQL Server

https://hub.docker.com/_/microsoft-mssql-server

Download SQL Server image:

~~~
$ docker pull mcr.microsoft.com/mssql/server:2019-latest
~~~

Run SQL Server container:

~~~
$ docker run --name sql-server -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=MYp4ssw0rD" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
~~~

Connect to the SQL Server using the sqlcmd tool inside of the container by using the following command on the host:

~~~
$ docker exec -it sql-server /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P MYp4ssw0rD
~~~

Create the database by using the following commands:

~~~
1> CREATE DATABASE MyAppDB
2> GO
~~~


## Database migrations

Go to **/aspdotnet_angular_boilerplate/aspnet-core/src/MyApp.Migrator/** and edit the **appsettings.json** file to match the database credentials:

~~~
{
  "ConnectionStrings": {
    "Default": "Server=localhost; Database=MyAppDB; User=sa; Password=MYp4ssw0rD;"
  }
}
~~~


Run the following command:

~~~
$ dotnet watch
~~~

## Run ASP.NET Core Application

Go to **aspdotnet_angular_boilerplate/aspnet-core/src/MyApp.Web.Host** and edit the **appsettings.json** file to match the database credentials (in the same way that was done in the previous step to run the migrations).

Run the following command:

~~~
$ dotnet watch
~~~
