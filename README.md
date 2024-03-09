# Description

This project was made to compare the performance between Rest and GraphQL in .NET APIs.

# Prerequisites

- Docker Engine 17.06.0+
- .NET 8
- k6

# Install k6

## Ubuntu

```bash
sudo gpg -k
sudo gpg --no-default-keyring --keyring /usr/share/keyrings/k6-archive-keyring.gpg --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys C5AD17C747E3415A3642D57D77C6C491D6AC1D69
echo "deb [signed-by=/usr/share/keyrings/k6-archive-keyring.gpg] https://dl.k6.io/deb stable main" | sudo tee /etc/apt/sources.list.d/k6.list
sudo apt-get update
sudo apt-get install k6
```

# Docker

This will start all the services used in the tests.

```bash
$ docker-compose up -d
```

# Running projects

## Grafana

Default user credentials to grafana is:

```bash
user: admin
password: admin
```

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

# Running the projects
