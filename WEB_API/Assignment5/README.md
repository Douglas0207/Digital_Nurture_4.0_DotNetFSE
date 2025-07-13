# Assignment 5 – CORS, JWT Authentication & Role-Based Security in ASP.NET Core Web API

**Student:** Robinson Douglas
**Week:** 5
**Assignment:** Implement JWT Token Authentication with Role-Based Authorization and CORS in ASP.NET Core (.NET 8)

---

## Objectives

* Enable and test CORS for frontend access from different ports (e.g., React/Angular)
* Implement JWT-based Authentication and Role-based Authorization
* Use `[Authorize]`, `[AllowAnonymous]`, and `Roles` attributes to secure API endpoints
* Generate and validate tokens containing claims like UserId and Role
* Test different scenarios using Swagger and Postman, including token expiry and role mismatches

---

## Tools Used

* **Operating System:** macOS
* **Editor:** Visual Studio Code
* **.NET SDK Version:** 8.0.411
* **API Testing Tools:** Swagger UI, Postman
* **Terminal:** macOS zsh/bash terminal
* **NuGet Packages:**

  * Microsoft.AspNetCore.Authentication.JwtBearer

---

## Steps Performed

### Step 1: Created Web API Project

```bash
dotnet new webapi -n Assignment5
```

### Step 2: Configured JWT Authentication in `Program.cs`

* Registered the authentication middleware
* Used a symmetric key for token signing
* Configured validation for:

  * Issuer
  * Audience
  * Expiry
  * Signature
* Disabled default 5-minute `ClockSkew`

```csharp
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "mySystem",
            ValidAudience = "myUsers",
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("mysuperdupersecretkeyformyapi123456")),
            ClockSkew = TimeSpan.Zero
        };
    });
```

### Step 3: Enabled CORS for Localhost Frontends

Allowed cross-origin requests from `localhost:3000` and `localhost:4200`:

```csharp
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost", policy =>
    {
        policy.WithOrigins("http://localhost:3000", "http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
```

---

## Controller Implementation

### AuthController (Token Generator)

* Endpoint: `GET /api/Auth/login`
* Generates JWT token with claims:

  * `UserId`
  * `Role` = `"Admin"` (initially)
* Token expiration was:

  * 10 minutes initially
  * 2 minutes later (for expiry testing)

```csharp
[HttpGet("login")]
[AllowAnonymous]
public IActionResult Login()
{
    var token = GenerateJSONWebToken(1, "Admin");
    return Ok(new { token });
}
```

### EmployeeController (Protected Endpoint)

* Applied `[Authorize(Roles = "Admin")]`
* Endpoint: `GET /api/Employee`
* Returns:

  * `200 OK`: "Welcome Admin" if valid token and role
  * `403 Forbidden`: if token exists but role is not `"Admin"`
  * `401 Unauthorized`: if token is missing, invalid, or expired

```csharp
[Authorize(Roles = "Admin")]
[HttpGet]
public IActionResult Get()
{
    return Ok("Welcome Admin");
}
```

---

## Middleware Pipeline in Program.cs

```csharp
app.UseCors("AllowLocalhost");
app.UseHttpsRedirection();
app.UseAuthentication(); // Required before UseAuthorization
app.UseAuthorization();
app.MapControllers();
```

---

## Testing Summary

### Token Issuance

* Called `/api/Auth/login`
* Received a valid JWT token

### Authorization Success (Admin Role)

* Sent `Bearer {token}` in Authorization header to `/api/Employee`
* Received: `"Welcome Admin"` (HTTP 200)

### Role Mismatch

* Changed role to `"POC"` in token
* Received: `403 Forbidden` on `/api/Employee`

### Token Expiry Test

* Set token expiry to 2 minutes
* Waited for 2+ minutes
* Used the same token → Received: `401 Unauthorized`

---

## Key Concepts Learned

| Concept                           | Status    |
| --------------------------------- | --------- |
| CORS Policy Configuration         | Completed |
| JWT Token Creation                | Completed |
| Token Claims & Signing            | Completed |
| Authentication Middleware Setup   | Completed |
| Authorization with Roles          | Completed |
| `[Authorize]`, `[AllowAnonymous]` | Completed |
| Swagger & Postman Token Testing   | Completed |
| Token Expiry Handling             | Completed |
| Clock Skew Configuration          | Completed |

---

## Output

<img width="1440" height="900" alt="Screenshot 2025-07-13 at 6 25 03 PM" src="https://github.com/user-attachments/assets/ecf175d8-794e-4a60-8cc3-00cf038bacf5" />

<img width="1440" height="900" alt="Screenshot 2025-07-13 at 6 25 40 PM" src="https://github.com/user-attachments/assets/4b6ab48c-eea2-437d-8cfd-a5fdf35ad78b" />

<img width="1440" height="900" alt="Screenshot 2025-07-13 at 6 44 54 PM" src="https://github.com/user-attachments/assets/a84a388b-fa3c-489a-bbe0-64c950517033" />


---
## Conclusion

Successfully built and tested a secure ASP.NET Core Web API that supports:

* Cross-Origin access (CORS)
* JWT Authentication
* Role-based Authorization

Implemented custom logic for issuing and validating JWT tokens, and verified behavior for various security scenarios using Postman and Swagger UI. This assignment strengthens the foundation for securing real-world APIs using industry best practices.

---

