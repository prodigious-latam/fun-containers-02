# fun-containers-02
First example for Fun with Containers session (Docker Compose) 

## How to run the project

Execute the following command from the terminal

```
docker-compose up
```


## API Project Creation

- Install [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- Run the webapi project scaffold
```
dotnet new webapi -o api
```
- Install the dependencies (in this case Entity Framework)
```
cd api
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 3.1.4
```

Sample endpoints include
- http://localhost:5000/city?country_id=87
- http://localhost:5000/country

## DB

Sample database content was downloaded from https://github.com/devrimgunduz/pagila
The Dockerfile provided automatically restores the data into the database when the container is started.

## React application

This project was scaffolded using this command:
```
npx create-react-app my-react-app --template typescript
```

Browse to the app by visiting [http://localhost:8080](http://localhost:8080)
