# Study Manager: 

A web application, designed for students to keep track of their modules and their study times:

## Live Web Version:

- **Access**: Click the link: [Study Manager Website](https://studymanagementprj.azurewebsites.net/)
  
### Features:
- Pre-populated demo with sample users and modules.
- User registration and login.
- Navigation bar for managing modules, viewing reports, and visualizing study data.
- Secured password hashing for user accounts.

### Supported Browsers:
- Chrome
- Firefox
- Edge

---

## Local Setup (For Developers):

This option allows you to run the application on your machine.

### Prerequisites:
- Git installed
- Visual Studio
- SQL Server Management Studio

### Steps:

1. **Clone the project**: Click the green "Clone" button on the project repository.
2. **Set up database**:
   - Run the `POE.sql` script in SQL Server Management Studio to create the database.
   - Copy the connection string from the database properties.
   - Update the `StudentConnectionString` in the cloned project's `appsettings.json` file.
3. **Database Migration**:
   - Open the NuGet Package Manager Console in Visual Studio.
   - Run the commands:
     ```
     add-migration AddStudentToDatabase (or a custom name)
     update-database
     ```
   
   **Important**:
   - In the SQL script, drop the `Module` table and recreate it to change `datetime2` to `datetime`.
   - Run the provided insert statements to populate the `Module` table with sample data.

4. **Run the application**:
   - Run the project in Visual Studio.
   - Register a new user with the username "JohnDoe".

### Functionality:
- Register or login as a user.
- Use the navigation bar to enter module details, view reports, and visualize study data.
- Logout functionality is also included.

---

## Additional Resources:

- A video walkthrough of the application can be found here: [https://youtu.be/FdzMHWEDK7I](https://youtu.be/FdzMHWEDK7I)
- Project documentation (PDF slides) is available in the project's documents folder.


