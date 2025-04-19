
# BookStore

BookStore is an ASP.NET Core MVC e-commerce application designed to manage a virtual bookstore. It offers a user-friendly interface for browsing, managing, and purchasing books. The application follows clean architecture principles with modular separation of concerns across multiple layers.


## Features

- Browse all available books
- Add new books to the cart
- Edit and update existing book details
- Delete books from the store
- Structured with MVC architecture and clean code organization
- Authentication and Authorization using Identity and role-based access
- Shopping cart and checkout integration using Stripe
- Deployment to Azure app service

## Tech Stack

**Frontend:** ASP.NET Core MVC (Razor Views)

**Backend:** ASP.NET Core

**ORM:** Entity Framework Core

**Database:** SQL Server

**Languages:** C#, HTML, CSS


## Getting Started

**Prerequisties**

Make sure you have the following installed:

- .NET 6.0 SDK or later

- SQL Server

- Visual Studio / VS Code



## Installation

Clone the repository

`git clone https://github.com/harathikolluru/BookStore.git
cd BookStore`

Set up the database

Open the solution in Visual Studio.

Update the connection string in appsettings.json inside BookStoreWeb with your local SQL Server instance.

Run the following in the Package Manager Console:

`Update-Database`

This will apply any existing EF Core migrations and create the database.

Run the project

`dotnet run --project BookStoreWeb`

Visit https://localhost:5001 or http://localhost:5000 in your browser.


## Demo

https://bookscart.azurewebsites.net/


    


