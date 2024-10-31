# Report Application

**Report Application** is a demo Windows Forms application developed to practice and demonstrate CRUD operations for managing employee and manager information. This project serves as a tool for exploring Windows Forms and showcases a structured approach to application development with .NET Core and Entity Framework Core.

## Features

- **Admin Panel**: Enables CRUD (Create, Read, Update, Delete) operations on employee and manager records.
- **User-Friendly Interface**: Simple and intuitive design for ease of navigation and operation.

## Technologies Used

- **.NET Core 7**
- **Windows Forms**
- **Entity Framework Core**

## Architecture & Design Patterns

This application is structured using the **N-Tier Architecture** pattern, providing a clear separation of concerns across three main layers:

1. **Data Access Layer (DAL)**: Manages all interactions with the database.
2. **Business Layer (BL)**: Contains business logic for processing data between the DAL and the Presentation Layer.
3. **Presentation Layer (PL)**: Windows Forms interface for interacting with the application.

---
