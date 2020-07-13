# todoapp-csharp

A little app to learn C Sharp and .Net Core

## Use Cases

| Method | Endpoint               | Action                                    |
| ------ | ---------------------- | ----------------------------------------- |
| GET    | todos                  | Retrieve all todos                        |
| GET    | todos/:id              | Retrieve todo with id                     |
| PUT    | todos/create/:id       | Create todo with client-side generated id |
| PUT    | todos/update-title/:id | Update title of todo with id              |
| PUT    | todos/complete/:id     | Complete todo with id                     |
| PUT    | todos/uncomplete/:id   | Uncomplete todo with id                   |
| DELETE | todos/remove-all       | Remove all todos                          |
| DELETE | todos/remove/:id       | Remove todo with id                       |

## Run app

### Initialize database

`docker-compose up -d`

`Execute database/todo.sql`

### Run project

`dotnet run --project apps/Todo/Api`
