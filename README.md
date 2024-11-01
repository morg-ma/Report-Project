# Report Application

**Report Application** is a demo Windows Forms application designed to practice and demonstrate CRUD (Create, Read, Update, Delete) operations for managing employee and manager information. This project serves as a practical tool for exploring Windows Forms and showcases a structured approach to application development using .NET Core and Entity Framework Core.

## Features

- **Admin Panel**: 
  - Full functionality for managing employee and manager records, including:
    - Add new employees and managers
    - Update existing records
    - Delete records as needed
    - View detailed information for each record
- **User-Friendly Interface**: 
  - An intuitive design that simplifies navigation and operational tasks, ensuring a smooth user experience.
- **Data Validation**: 
  - Ensures data integrity by validating input before database operations.
  
## Technologies Used

- **.NET Core 7**: For building cross-platform applications.
- **Windows Forms**: For creating the desktop application interface.
- **Entity Framework Core**: For data access and manipulation, leveraging the power of Object-Relational Mapping (ORM).
- **SQL Server**: For storing and managing application data.

## Architecture & Design Patterns

This application is structured using the **N-Tier Architecture** pattern, providing a clear separation of concerns across three main layers:

1. **Data Access Layer (DAL)**: 
   - Responsible for all interactions with the database. It handles data retrieval, updates, and persistence.
2. **Business Logic Layer (BLL)**: 
   - Contains business logic that processes data between the DAL and the Presentation Layer, ensuring that the application rules and workflows are followed.
3. **Presentation Layer (PL)**: 
   - The Windows Forms interface that allows users to interact with the application, providing an engaging and responsive user experience.

## Database

The application comes with a pre-configured SQL Server database that includes:
- Employee and manager tables with sample data
- Necessary relationships and constraints
- Pre-configured connection strings

To use the database:
1. Locate the database backup file in the `Database` folder
2. Restore it using SQL Server Management Studio
3. Update the connection string in the application's configuration file if needed

## Getting Started

### Prerequisites

- .NET Core 7 SDK installed on your machine
- Visual Studio or any IDE that supports Windows Forms applications
- SQL Server (Express edition or higher)
- SQL Server Management Studio (recommended for database management)

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/morg-ma/Report-Project.git
   cd Report-Project
   ```

2. **Set up the database**:
   - Open SQL Server Management Studio
   - Restore the provided database backup file
   - Verify the database connection

3. **Open the solution**:
   - Launch Visual Studio and open the solution file (`.sln`).

4. **Build the application**:
   - Restore any required NuGet packages.
   - Build the solution to ensure all dependencies are correctly set.

5. **Run the application**:
   - Start the application from Visual Studio by pressing `F5` or clicking on the Start button.

## Contribution

Contributions are welcome! Feel free to submit pull requests or report issues to improve the functionality and usability of the Report Application.
