# Description

This project was made to compare the performance between Rest and GraphQL in .NET APIs.

# Prerequisites

- Docker Engine 17.06.0+
- .NET 8

# Docker

This will start all the services used in the tests.

```bash
$ docker-compose up -d
```

# Running projects

## GraphQL

To run this project you can run this command:

```bash
$ cd GraphQL/GraphQL ; dotnet run
```

In order to test it, you can open this url in the browser: http://localhost:5000/graphql/

## Rest

To run this project you can run this command:

```bash
$ cd Rest/Rest ; dotnet run
```

In order to test it, you can do a request in the browser like this: http://localhost:5000/Product

## Migrations

After every Entity change, could be: edit, create, delete, etc, you must create a Migration. To do this:

- Open the 'Package Manager Console' and run: 'dotnet ef migrations add [Migration-Name]'
- To remove the last migration use this: 'dotnet ef migrations remove'
