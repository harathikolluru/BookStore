
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
1. Clone the repository

    `git clone https://github.com/harathikolluru/BookStore.git
    cd BookStore`
2. Set up the database

    Open the solution in Visual Studio.

    Update the connection string in appsettings.json inside BookStoreWeb with your local SQL Server instance.

3. Run the following in the Package Manager Console:

    `Update-Database`

    This will apply any existing EF Core migrations and create the database.

4. Run the project

    `dotnet run --project BookStoreWeb`

    Visit https://localhost:5001 or http://localhost:5000 in your browser.

## Screenshots
<img width="959" alt="image" src="https://github.com/user-attachments/assets/df1746bf-6fd2-443c-a1af-55642997463c" />
<img width="959" alt="image" src="https://github.com/user-attachments/assets/d7fb32cd-251b-4179-b5ed-af77a68cec32" />
<img width="956" alt="image" src="https://github.com/user-attachments/assets/5cef514a-a3c0-43a6-9db6-0bb0f03f503f" />
<img width="952" alt="image" src="https://github.com/user-attachments/assets/b8b869a0-a176-4344-8e5b-147effd512d8" />




## Demo

https://bookscart.azurewebsites.net/


    


