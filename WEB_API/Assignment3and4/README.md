# Assignment 3 & 4 – Model Binding, Filters, Exception Handling & Update Operation in ASP.NET Core Web API

**Student:** Robinson Douglas
**Week:** 5
**Assignment:**

* Assignment 3: Demonstrate `[FromBody]`, ActionFilter, ExceptionFilter
* Assignment 4: Demonstrate PUT operation with validation logic

---

## Objectives

**Assignment 3**

* Create a complex custom model (Employee) with nested objects and collections
* Use `[FromBody]` to accept model data from HTTP requests
* Apply a custom Authorization Filter to validate request headers
* Implement a global Exception Filter to log exceptions and return user-friendly errors
* Test all endpoints using Swagger and Postman
* Understand and document responses using `ProducesResponseType`

**Assignment 4**

* Create a PUT API endpoint for updating employee data
* Add input validation
* Use hardcoded employee data for simplicity
* Test the API with Swagger and Postman

---

## Tools Used

* **Operating System:** macOS
* **Editor:** Visual Studio Code
* **.NET SDK Version:** 8.0.411
* **API Testing Tools:** Swagger UI, Postman
* **NuGet Packages:**

  * Swashbuckle.AspNetCore
  * Microsoft.AspNetCore.Mvc.NewtonsoftJson

---

## Folder Structure

```
Assignment3and4/
│
├── Models/
│   ├── Employee.cs
│   ├── Department.cs
│   └── Skill.cs
│
├── Filters/
│   ├── CustomAuthFilter.cs
│   └── CustomExceptionFilter.cs
│
├── Controllers/
│   └── EmployeeController.cs
│
├── Program.cs
├── Startup.cs (if applicable)
```

---

## Implementation Steps

### Step 1: Model and Controller Setup

* Created `Employee` model with:

  * `int Id`, `string Name`, `bool Permanent`, `Department`, `List<Skill>`, `DateTime DateOfBirth`
* Created full CRUD in `EmployeeController`:

  * `GET /api/Employee` – List all employees
  * `GET /api/Employee/{id}` – Get employee by ID
  * `GET /api/Employee/name/{name}` – Get employee by name
  * `POST /api/Employee` – Add new employee using `[FromBody]`
  * `PUT /api/Employee/{id}` – Update employee
  * `DELETE /api/Employee/{id}` – Delete employee

### Step 2: Model Binding with `[FromBody]`

* POST and PUT operations accept complete Employee JSON objects in the request body
* Example JSON body:

```json
{
  "name": "Kumar",
  "salary": 70000,
  "permanent": true,
  "department": { "id": 3, "name": "Finance" },
  "skills": [
    { "id": 4, "name": "Excel" },
    { "id": 5, "name": "Analytics" }
  ],
  "dateOfBirth": "1995-09-25"
}
```

* Tested successfully using Swagger and Postman

---

## Assignment 3 Specific Features

### Step 3: Custom Authorization Filter

* Created `CustomAuthFilter` that checks for `Authorization` header
* Returns:

  * 400 if header is missing
  * 400 if token doesn't contain "Bearer"
* Applied to `EmployeeController` using `[CustomAuthFilter]`

### Step 4: Global Exception Filter

* Implemented `CustomExceptionFilter` to:

  * Log exceptions to `error_log.txt`
  * Return `500 Internal Server Error` with a generic message
* Registered globally in `Program.cs` using:

```csharp
options.Filters.Add<CustomExceptionFilter>();
```

### Step 5: Swagger Configuration

* Customized Swagger UI with:

  * Title, Description, Version, Contact
* Added support for Authorization header:

```csharp
c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
{
    In = ParameterLocation.Header,
    Description = "Enter 'Bearer' followed by your token",
    Name = "Authorization",
    Type = SecuritySchemeType.ApiKey
});
```

---

## Assignment 4 Specific Features

### Step 6: PUT Endpoint with Validation

* PUT `/api/Employee/{id}` uses `[FromBody]` to update employee
* Validation includes:

  * ID must be greater than 0
  * Employee must exist
* If valid, updates fields and returns `Ok()` with updated data

---

## Testing Summary

### Swagger Authorization

* Add header in Swagger Authorize:

```
Authorization: Bearer dummy-token
```

### Exception Testing

* Temporarily added `throw new Exception("Simulated")` in a method
* Received 500 error in Swagger/Postman with proper logging

---

## Output Example

**Request:**

```
PUT /api/Employee/1
Authorization: Bearer any-token
```

**Body:**

```json
{
  "id": 1,
  "name": "Kumar",
  "salary": 70000,
  "permanent": true,
  "department": { "id": 3, "name": "Finance" },
  "skills": [
    { "id": 4, "name": "Excel" },
    { "id": 5, "name": "Analytics" }
  ],
  "dateOfBirth": "1995-09-25"
}
```

**Response:**

```json
{
  "id": 1,
  "name": "Kumar",
  "salary": 70000,
  "permanent": true,
  ...
}
```

---

## Key Concepts Learned

| Concept                             | Status    |
| ----------------------------------- | --------- |
| Model Binding with \[FromBody]      | Completed |
| Custom Action Filters               | Completed |
| Global Exception Filters            | Completed |
| PUT and Validation Logic            | Completed |
| Swagger Documentation Enhancements  | Completed |
| Authorization Header Implementation | Completed |
| Full CRUD with Nested Models        | Completed |

---

## Output

<img width="1440" height="900" alt="Screenshot 2025-07-13 at 5 36 11 PM" src="https://github.com/user-attachments/assets/8988aee6-c88c-4fe3-914d-4c46ee21db06" />

<img width="1440" height="900" alt="Screenshot 2025-07-13 at 5 36 18 PM" src="https://github.com/user-attachments/assets/58ad2a10-d418-420f-ae9c-056c12c6a56c" />

<img width="1440" height="900" alt="Screenshot 2025-07-13 at 5 38 05 PM" src="https://github.com/user-attachments/assets/6f437410-ce15-4f41-966a-ffe9db4a1475" />

<img width="1440" height="900" alt="Screenshot 2025-07-13 at 5 38 10 PM" src="https://github.com/user-attachments/assets/d906b909-a18b-4f64-bbf8-e24d7df9e6a7" />

<img width="1440" height="900" alt="Screenshot 2025-07-13 at 5 38 46 PM" src="https://github.com/user-attachments/assets/7f0a7035-1276-47ca-862f-ea4e4f0f4553" />

<img width="1440" height="900" alt="Screenshot 2025-07-13 at 6 00 35 PM" src="https://github.com/user-attachments/assets/ebf8cdc0-d40b-4ecf-82c0-22e7d0310b0f" />


---

## Conclusion

Assignments 3 and 4 were successfully completed by combining:

* Strong understanding of `[FromBody]` binding for complex JSON
* Custom filters for authentication and error handling
* Clean API design with complete Swagger testing
* Real-world POST and PUT operations with validations

The project is ready and deployed locally for review via Swagger and Postman.

---

Let me know if you want this saved into a file, or if you'd like a final `README.md` for Week 4 combining Assignments 1–5.
