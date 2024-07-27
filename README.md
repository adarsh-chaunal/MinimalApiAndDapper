# Minimal API with Dapper and SQL in .NET 8

## Project Description

This project demonstrates the use of Dapper and SQL for data access in a Minimal API using .NET 8. It is designed to be a simple, yet effective example of how to build a lightweight, high-performance Web API using modern .NET technologies.

## Table of Contents

- [Introduction](#introduction)
- [Technologies Used](#technologies-used)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The goal of this project is to provide a clear, concise example of how to use Dapper for data access in a .NET 8 Minimal API. Dapper is a simple, fast ORM library for .NET that provides a convenient way to interact with your database without the overhead of a full-fledged ORM like Entity Framework.

## Technologies Used

- .NET 8
- Dapper
- SQL Server
- Minimal API

## Setup and Installation

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Steps

1. Clone the repository:

    ```sh
    git clone https://github.com/adarsh-chaunal/MinimalApiAndDapper.git
    cd MinimalApiAndDapper
    ```

2. Set up the SQL Server database. Create a new database and run the provided SQL scripts to set up the necessary tables and data.

3. Update the connection string in `appsettings.json` to point to your SQL Server instance.

4. Restore the .NET packages and build the project:

    ```sh
    dotnet restore
    dotnet build
    ```

5. Run the application:

    ```sh
    dotnet run
    ```

## Usage

After starting the application, you can interact with the API using tools like [Postman](https://www.postman.com/) or [cURL](https://curl.se/). The API provides endpoints for basic CRUD operations using Dapper to interact with the SQL Server database.

## API Endpoints

### GET /api/items

Retrieves a list of all items.

### GET /api/items/{id}

Retrieves a specific item by ID.

### POST /api/items

Creates a new item.

### PUT /api/items/{id}

Updates an existing item by ID.

### DELETE /api/items/{id}

Deletes an item by ID.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is not licensed.
