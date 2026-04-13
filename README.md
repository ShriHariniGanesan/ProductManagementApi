# 🚀 Product Management API

A backend RESTful API built using **ASP.NET Core Web API**, **SQL Server**, and **Entity Framework Core**.
This project demonstrates real-world backend development concepts like CRUD operations, layered architecture, and database integration.

---

## 📌 Features

* 🔹 Create, Read, Update, Delete (CRUD) operations for Products
* 🔹 Search products by category
* 🔹 SQL Server integration using Entity Framework Core
* 🔹 Clean architecture (Controller → Service → Repository)
* 🔹 Swagger UI for API testing
* 🔹 Data validation using DTOs

---

## 🧰 Tech Stack

* **.NET 8 (ASP.NET Core Web API)**
* **Entity Framework Core**
* **SQL Server (SQLEXPRESS)**
* **Swagger (OpenAPI)**
* **C#**

---

## 📂 Project Structure

```
ProductManagementApi/
│
├── Controllers/
├── Models/
├── DTOs/
├── Services/
├── Repositories/
├── Data/
├── Program.cs
├── appsettings.json
```

---

## ⚙️ Setup Instructions

### 1️⃣ Clone the repository

```
git clone https://github.com/ShriHariniGanesan/ProductManagementApi.git
cd ProductManagementApi
```

---

### 2️⃣ Configure Database

Update `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=<yourservername>;Database=ProductManagementDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

### 3️⃣ Run Migrations

```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

### 4️⃣ Run the Application

```
dotnet run
```

---

### 5️⃣ Open Swagger UI

```
https://localhost:xxxx/swagger
```

---

## 📡 API Endpoints

| Method | Endpoint                            | Description       |
| ------ | ----------------------------------- | ----------------- |
| GET    | `/api/products`                     | Get all products  |
| GET    | `/api/products/{id}`                | Get product by ID |
| GET    | `/api/products/category/{category}` | Get by category   |
| POST   | `/api/products`                     | Create product    |
| PUT    | `/api/products/{id}`                | Update product    |
| DELETE | `/api/products/{id}`                | Delete product    |

---

## 🧪 Sample Request

### Create Product

```json
{
  "name": "Monitor",
  "category": "Electronics",
  "price": 300,
  "stockQuantity": 20
}
```

---

## 📊 What I Learned

* Building REST APIs using ASP.NET Core
* Implementing layered architecture (Repository + Service pattern)
* Integrating SQL Server with EF Core
* Using Swagger for API testing and documentation
* Handling data validation using DTOs

---

## 🚀 Future Enhancements

* 🔐 Add JWT Authentication
* 📄 Add pagination and filtering
* 📊 Connect API to Power BI / frontend
* ☁️ Deploy to Azure

---

## 👩‍💻 Author

**Shri Harini Ganesan**

* GitHub: https://github.com/ShriHariniGanesan
* LinkedIn: https://www.linkedin.com/in/shriharini14/

---

## ⭐ If you like this project

Give it a ⭐ on GitHub!
