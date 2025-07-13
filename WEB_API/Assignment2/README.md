# Assignment 2 – Swagger Integration and Route Customization in ASP.NET Core Web API

### Student: Robinson Douglas  
### Week: 4  
### Assignment: Demonstrate Swagger, Postman, and Route attribute in Web API

---

## Objectives

- Install and configure Swagger (Swashbuckle.AspNetCore)
- Display custom metadata in Swagger UI
- Use Postman to test Web API endpoints
- Customize controller routing using `[Route]`, `[Http*]`, and name attributes
- Demonstrate multiple `GET`, `POST`, `PUT`, and `DELETE` endpoints

---

## Tools Used

- **Operating System:** macOS  
- **Editor:** Visual Studio Code  
- **.NET SDK Version:** 8.0.411  
- **API Testing Tools:** Swagger UI, Postman  
- **NuGet Package:** Swashbuckle.AspNetCore

---

## Steps Performed

### Step 1: Created New Web API Project

Created a fresh project using:
- `dotnet new webapi -n Assignment2`

Confirmed the default Weather API was running and accessible at:
- `http://localhost:[port]/swagger`

---

### Step 2: Installed Swagger (Swashbuckle)

Added the NuGet package:
- `dotnet add package Swashbuckle.AspNetCore`

Updated Swagger configuration in `Program.cs`:

- Added custom metadata like title, version, description, contact, and license
- Used `AddSwaggerGen()` and `UseSwaggerUI()` in the pipeline

Swagger UI displayed:
- Title: Swagger Demo  
- Version: 1.0.0  
- Author: John Doe  
- License and Contact details shown on the Swagger page

---

### Step 3: Created HelloController (Basic Demo)

Created a simple controller to test Swagger integration:

- GET `/api/hello` returned a plain string message:
  - `"Hello from Swagger-enabled API!"`
- Tested using both Swagger and Postman

---

### Step 4: Created EmployeeController with CRUD

Custom controller with route `[Route("api/emp")]`. Implemented:

- GET `/api/emp` → List of employee names
- GET `/api/emp/{id}` → Get employee by index
- GET `/api/emp/name/{name}` → Get employee by name
- POST `/api/emp` → Add new employee
- PUT `/api/emp/{id}` → Update employee at index
- DELETE `/api/emp/{id}` → Remove employee at index

---

## Postman Testing

- **GET /api/emp** → Returned full list of names like:  
  `[ "Robinson", "Daniel", "Kumar" ]`
- **POST /api/emp** → Sent `"Joseph"` in body → Got `201 Created`  
- **GET /api/emp/0** → Returned `"Robinson"`  
- **DELETE /api/emp/1** → Removed `Daniel`

Verified:
- JSON response in **Body**
- Status code `200 OK` or `201 Created`
- Authorization headers can be added (for advanced usage)

---

## Key Concepts Learned

| Concept                              | Status |
|-------------------------------------|--------|
| Swagger Customization               | ✅     |
| Swagger UI Metadata                 | ✅     |
| Swashbuckle Package Installation    | ✅     |
| Postman Testing of Web API          | ✅     |
| ActionName & Route Attribute Usage  | ✅     |
| Multiple GET Methods in One Controller | ✅  |
| RESTful CRUD in Controller          | ✅     |

---

## Output

<img width="1440" height="900" alt="Screenshot 2025-07-12 at 10 29 44 PM" src="https://github.com/user-attachments/assets/8476a0d3-3e90-4e64-933d-8ed00e9210e6" />

<img width="1440" height="900" alt="Screenshot 2025-07-12 at 10 29 49 PM" src="https://github.com/user-attachments/assets/e041a3c6-1a12-4d5b-81c5-8bcedc3b5bc2" />

<img width="1440" height="900" alt="Screenshot 2025-07-12 at 10 29 53 PM" src="https://github.com/user-attachments/assets/7269a517-5cc2-4bf5-9a81-a817b6c41264" />

---

## Conclusion

Successfully completed Assignment 2 by:
- Integrating Swagger with detailed metadata
- Customizing Web API routes
- Creating full CRUD endpoints
- Testing all API calls through both Swagger and Postman

Gained confidence in debugging Swagger issues, interpreting HTTP status codes, and verifying JSON payloads across different tools.

---

