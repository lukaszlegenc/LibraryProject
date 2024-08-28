# Project Title

Online library management system

## Description

Developed a web application using ASP.NET technology to manage an online library. 
The system allows users to register accounts, browse the book catalog and manage books. 
Employees have permissions to add and edit books, while administrators manage user accounts. 
The project uses Microsoft SQL Server as the database and Entity Framework Core for effective communication with the database. 
The application implements full CRUD functionality (create, read, update, delete) for both books and user accounts.

Before launching the application, it is necessary to migrate the database, which will create default accounts for the site administrator and employee.
Login details for default accounts: Email: admin@websiteadmin.com, employee@websiteempl.com; Password: admin123, empl123.

## Features

* User registration and login: Users can create accounts, log in and manage their profile.
* Inserting books: Employees with appropriate access rights can add new books to the system and edit existing items.
* Database integration: Using Microsoft SQL Server to store data and Entity Framework Core to communicate effectively with the database.
* User account management: Admin has the ability to delete and update user accounts, including granting access rights.
* Access rights management: The system differentiates user roles, allowing employees and administrators to perform specific operations.

## Installation

* ### Clone the repository:
```
git clone https://github.com/lukaszlegenc/FlaskProject.git
```
* ### Restore NuGet Packages:
Use the .NET CLI to restore the required packages:
```
dotnet restore
```
* ### Create a new migration:
In the NuGet Package Manager Console:
```
Add-Migration InitialCreate
```
* ### Update the database:
```
Update-Database
```
* ### Run the application:
