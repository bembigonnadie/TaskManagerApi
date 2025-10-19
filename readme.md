# 📘 Task Manager API

A simple **Task Manager REST API** built with **ASP.NET Core 9 Minimal API** and **Entity Framework Core (SQLite)**.  
Perfect as a starting point for small projects, CRUD examples, or freelance API prototypes.

---

## ⚙️ Features

- 🧱 CRUD operations for tasks (`GET`, `POST`, `PUT`, `DELETE`)
- 🗂 SQLite database with Entity Framework Core
- 🔍 Swagger UI documentation
- 🧩 Clean and minimal one-file structure
- ⚡ Compatible with .NET 9

---

## 🧩 Tech Stack

| Component | Description |
|------------|--------------|
| **Framework** | .NET 9 (Minimal API) |
| **ORM** | Entity Framework Core 9 |
| **Database** | SQLite |
| **Docs** | Swagger / OpenAPI |
| **Language** | C# |

---

## 🚀 How to Run Locally

### 1️⃣ Clone the repo
```bash
git clone https://github.com/<your-username>/TaskManagerApi.git
cd TaskManagerApi
```

### 2️⃣ Install dependencies
```bash
dotnet restore
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 9.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.0
dotnet add package Swashbuckle.AspNetCore --version 6.6.2
```

### 3️⃣ Apply database migrations
```bash
dotnet ef migrations add Init
dotnet ef database update
```

### 4️⃣ Run the API
```bash
dotnet run
```

Swagger will open automatically at:  
👉 https://localhost:7199/swagger

---

## 📄 API Endpoints

| Method | Endpoint | Description |
|---------|-----------|-------------|
| `GET` | `/api/tasks` | Get all tasks |
| `GET` | `/api/tasks/{id}` | Get a specific task by ID |
| `POST` | `/api/tasks` | Create a new task |
| `PUT` | `/api/tasks/{id}` | Update an existing task |
| `DELETE` | `/api/tasks/{id}` | Delete a task |

---

## 🧱 Database Schema

| Column | Type | Description |
|---------|------|-------------|
| `Id` | `int` | Primary key |
| `Title` | `string` | Task title |
| `Description` | `string?` | Optional description |
| `IsCompleted` | `bool` | Task status |
| `CreatedAt` | `DateTime` | Creation date (UTC) |

---

## 🧠 Example Request

**POST /api/tasks**
```json
{
  "title": "Finish freelance project",
  "description": "Add README and test CRUD operations",
  "isCompleted": false
}
```

**Response**
```json
{
  "id": 1,
  "title": "Finish freelance project",
  "description": "Add README and test CRUD operations",
  "isCompleted": false,
  "createdAt": "2025-10-19T14:10:00Z"
}
```

---

## 📦 Project Structure
```
TaskManagerApi/
├── Program.cs
├── AppDbContext.cs
├── TaskItem.cs
├── appsettings.json
├── Migrations/
└── README.md
```

---

## 💬 License
This project is open source and available under the [MIT License](https://opensource.org/licenses/MIT).
