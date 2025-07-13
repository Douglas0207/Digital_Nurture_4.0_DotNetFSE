Assignment 1  # 📘 Assignment 1 – Web API using ASP.NET Core (.NET 8)

### 👨‍🎓 Student: Robinson Douglas  
### 🗓️ Week: 4  
### 📝 Assignment: Create a simple Web API with Read/Write operations

---

## 📌 Objectives

- Understand the concept of RESTful Web Service, Web API, and Microservices
- Learn about HTTP request and response flow
- Understand action verbs: GET, POST, PUT, DELETE
- Learn common HTTP status codes
- Create a simple Web API using .NET Core
- Test the API using Swagger UI

---

## 🛠️ Tools Used

- **Operating System:** macOS  
- **Editor:** Visual Studio Code  
- **.NET SDK Version:** 8.0.411  
- **API Testing Tool:** Swagger (built-in)
- **Terminal:** macOS zsh/bash terminal

---

## 🔨 Steps Performed

### ✅ Step 1: Created Web API Project

Used the following command to create the project:
- `dotnet new webapi -n Assignment1`

This created a basic Web API template with a sample controller (`WeatherForecastController`).

### ✅ Step 2: Explored Swagger UI

- Ran the application using `dotnet run`
- Navigated to `http://localhost:[port]/swagger`
- Saw the default endpoint `/weatherforecast` listed
- Used **Try it out → Execute** to see JSON response of dummy weather data

### ✅ Step 3: Created Custom `ValuesController` with CRUD Operations

Manually added a new controller `ValuesController` with the following endpoints:

- GET `/api/values` – List all values
- GET `/api/values/{id}` – Get value by index
- POST `/api/values` – Add a new value
- PUT `/api/values/{id}` – Update a value at index
- DELETE `/api/values/{id}` – Remove value at index

All methods return appropriate status codes such as:
- 200 OK
- 201 Created
- 204 No Content
- 404 Not Found

Tested all actions using Swagger UI.

---

## ✅ Output Samples

- `GET /api/values` returned:
  - `["value1", "value2"]`
- `POST /api/values` with `"value3"` updated list to:
  - `["value1", "value2", "value3"]`
- `PUT /api/values/1` changed `value2` to `updatedValue2`
- `DELETE /api/values/0` removed `value1`

---

## 📚 Key Concepts Learned

| Concept                        | Status |
|-------------------------------|--------|
| REST Architecture             | ✅     |
| Stateless Communication       | ✅     |
| Action Verbs (GET, POST, etc) | ✅     |
| HTTP Status Codes             | ✅     |
| Swagger UI Usage              | ✅     |
| Routing in ASP.NET Core       | ✅     |
| API Controller Inheritance    | ✅     |

---

## 🏁 Conclusion

Successfully created and tested a simple RESTful Web API using .NET Core 8. Understood core concepts of routing, controller structure, action verbs, and Swagger testing. This assignment served as the foundational step toward building and managing real-world Web APIs.

---

