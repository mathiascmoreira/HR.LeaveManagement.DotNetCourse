# 🚀 HR Leave Management System API

This project is built using **.NET 8** and is based on a comprehensive course taught by Microsoft MVP **Trevoir Williams**.

## 🎯 Key Project Focus

The core focus of this repository is the implementation of a robust **ASP.NET Core Web API** designed for Human Resources (HR) leave management. It serves as a practical example for implementing modern, scalable back-end architecture and practices:

* **Architectural Pattern:** Implementation of the **CQRS (Command Query Responsibility Segregation)** pattern. 
* **Design Principles:** Strict adherence to **SOLID principles** and **Clean Architecture**.
* **Messaging:** Utilization of the **Mediator pattern** (specifically using MediatR) for efficient command and query handling.
* **Testing:** Comprehensive coverage with both **Unit Tests** and **Integration Tests**.

The application provides essential API functionality for managing employee leave, including handling leave requests, defining leave types, and tracking leave periods.

## 🏗️ Architecture and Project Structure

The solution strictly follows the principles of **Clean Architecture**  to ensure optimal separation of concerns, testability, and long-term maintainability. This structure naturally organizes the codebase into distinct, decoupled layers.

> **Dependency Inversion:** This structure ensures that higher-level layers, such as **Application** and **Domain**, are decoupled from lower-level concerns (**Persistence**, **Infrastructure**). This is achieved by depending on **abstractions (interfaces)** rather than concrete implementations.

### Project Breakdown

| Project Name | Layer | Key Responsibilities |
| :--- | :--- | :--- |
| **API** | Presentation | The application's entry point, containing **Controllers** and API **Endpoints**. |
| **Domain** | Core Layer | Holds **Entities**, **Enums**, **Exceptions**, and **Domain Events**. It defines the core business logic and rules. |
| **Application** | Use Case Layer | Coordinates business logic flow. Implements **CQRS Features (Commands & Queries)**, **Handlers**, and application-level **Interfaces** (e.g., repository interfaces). |
| **Infrastructure** | Infrastructure | Provides concrete implementations for external concerns (e.g., Email Services, File Storage) defined by interfaces in the Application layer. |
| **Persistence** | Infrastructure | Manages data access implementation, typically utilizing **Entity Framework Core** for database interactions. |
| **Identity** | Security | Dedicated project for managing user identity, roles, and security/authentication concerns. |
| **BlazorUI** | Presentation (Briefly Covered) | A basic UI implementation using **Blazor** to consume the API endpoints. (Note: The API is the primary focus of this project). |
| **Unit and Integration Tests** | Testing | Contains comprehensive test suites for validating application logic and integration points. |

---

## ▶️ Getting Started (Local Setup)

Follow these instructions to get the project up and running on your local machine.

### 1. Configure the Database Connection

The project uses **Entity Framework Core** for data access. You need to configure your local connection string.

1.  Open the `appsettings.json` file inside the **API** project.
2.  Locate the `"ConnectionStrings"` section and update the `"DefaultConnection"` value to point to your local SQL Server instance.

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=HRLeaveManagementDb;Trusted_Connection=True;TrustServerCertificate=True;"
    }
    ```
    > **Note:** Replace `YOUR_SERVER_NAME` with the name or IP of your local SQL Server instance (e.g., `(localdb)\mssqllocaldb`).

### 2. Create and Migrate the Database

Use the **Package Manager Console** in Visual Studio or the **dotnet CLI** to apply the existing migrations and create the database schema.

1.  In Visual Studio, go to **Tools** > **NuGet Package Manager** > **Package Manager Console**.
2.  Set the **Default Project** to **`Persistence`**.
3.  Execute the following command to apply all migrations and create the database:

    ```bash
    Update-Database
    ```
    *Alternatively, using the **dotnet CLI** (ensure you are in the project's root directory):*
    ```bash
    dotnet ef database update --project .\Persistence\
    ```

### 3. Set the API as the Startup Project

You must configure the **API** project as the starting point for the application.

1.  In the **Solution Explorer**, right-click the **`API`** project.
2.  Select **Set as Startup Project**.

### 4. Run the Application

You can now run the application.

1.  Press **F5** or click the **Run** button in Visual Studio.
2.  The API will start, and the default browser should open the **Swagger UI** (OpenAPI documentation), allowing you to interact with all available endpoints.

## 🧪 Testing Strategy

The project includes dedicated testing projects to ensure a high level of code quality and functional reliability:

* **Unit Tests:** Focused on testing individual components and pure business logic (within the Domain and Application layers) in isolation.
* **Integration Tests:** Designed to verify that different application layers and external dependencies (like the database, via the Persistence layer) work correctly together.
