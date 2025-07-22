# BasicApi (.NET 9, C# 13)

A minimal API project with JWT authentication and protected endpoints.

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or later (recommended)

## Getting Started

1. **Clone the repository**
2. **Install the dependencies**
dotnet restore
4. **Run the project**
dotnet run

By default, the API will be available at:
   - `https://localhost:7074`
   - `http://localhost:5049`

## API Endpoints

### 1. Login

**POST** `/login`

Request body (JSON):{
  "username": "user",
  "password": "password"
}
Response (200 OK):

# Response
{
  "token": "YOUR_JWT_TOKEN",
}
### 2. Get Accounts (Protected)

**GET** `/accounts`

**Headers:**
- `Authorization: Bearer YOUR_JWT_TOKEN`

# Response
200 ok.
{list of accounts}
## Note
If the JWT is missing or invalid, you will receive a `401 Unauthorized` response.

#Swagger
/swagger/v1/swagger.json

## Notes

- The JWT secret is hardcoded for demo purposes. For production, store secrets securely.
- The user store is in-memory and for demonstration only.
- You can test endpoints using tools like [Postman](https://www.postman.com/) or [curl](https://curl.se/).

## Swagger UI

To explore the API, you can use the Swagger UI.

After running the project, navigate to `https://localhost:7074/swagger` to see the available endpoints and try them out.

## Troubleshooting

- If you encounter issues, ensure that the .NET 9 SDK is correctly installed.
- Check the output logs for any error messages during `dotnet run`.
- Ensure no other services are using the same ports (7074 for HTTPS, 5049 for HTTP).


builder.Services.AddOpenApi();

