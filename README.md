# CodnityToDo
Homework for Codnity.


Simple MVC application with Identity and Razor pages.
Database is hosted on SQL Server Express version.
You can manage your personal todo list(CRUD implemented).

## Setup
1. Clone project.
2. Change appsettings connection string if needed.
3. Make migrations:
```
add-migration -context IdentityUserDbContext
update-database -context IdentityUserDbContext
add-migration -context ToDoListDbContext
update-database -context ToDoListDbContext
```
4. Test the application
