# formation-aspnetcore-with-visualstudio-code-dotnet-cli
All asp.net core projet with dotnet cli


# Commands used to create and manage projects in this solution

## 00. Add global json
dotnet new globaljson 

open global.json, and change to 2.2.x if you don't want 3.x preview

## 0. Create solution
dotnet new sln

## 1. Create project web
dotnet new mvc --auth Individual --name DecouvrirAspNetCore_MVC

## 2. Add project to solution
dotnet sln add DecouvrirAspNetCore_MVC

## 3. Display all pages from Identity Back office
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design 

dotnet add package Microsoft.EntityFrameworkCore.SqlServer 

dotnet tool install --global dotnet-aspnet-codegenerator --version 2.2.3

dotnet aspnet-codegenerator identity

## 4. Add new controller
dotnet aspnet-codegenerator controller -name SecondController -namespace DecouvrirAspNetCore_MVC.Controllers

NOTE: launching web project coul failed : ANCM In-Process Start Failure
try that : https://stackoverflow.com/questions/53811569/using-netcore-2-2-and-using-the-in-process-hosting-model

Second possible failure : 
try that : https://github.com/aspnet/AspNetCore.Docs/issues/8223
