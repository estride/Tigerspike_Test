# Tigerspike_Test

# DB Setup

Amend appsettings.json and set connection string 

"ConnectionStrings": {
    "DefaultConnection": "Server=.\\sqlexpress;Database=MoviegramDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  
  After setting the connection string run Update-Database to run Migrations to create database.
  
  ~ Currently No seed methods are provided to create the database
  
  # Run
  
  http://localhost:60531/swagger/index.html
