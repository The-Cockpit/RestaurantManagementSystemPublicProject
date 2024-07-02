# Shift Management System
## Overview
The Shift Management System is a comprehensive web application designed for managing shifts at a restaurant. It is built with a .NET backend and a React TypeScript frontend. The application allows employees to submit their available schedules for the upcoming week and enables managers to edit and finalize the weekly schedule through a user-friendly interface. The login and registration system leverages Google OAuth for quick and easy access. The project is designed with flexibility and future expansion in mind.

## Features
- Employee Schedule Submission: Employees can submit their availability for the upcoming week.
- Manager Schedule Editing: Managers can edit and finalize the weekly schedule.
- Google OAuth Authentication: Quick and simple login and registration using Google accounts.
- Clean and Intuitive UI: Easy-to-use interface for both employees and managers.
- Flexible Design: The project is written in a generic way, allowing for future expansion and adaptability.

## Technologies Used
### Backend
- .NET 8: For building the web API server.
- Entity Framework Core: For database interactions.
- ASP.NET Core Identity: For managing user authentication and authorization.

### Frontend
- React: For building the user interface.
- TypeScript: For type-safe JavaScript code.
- Syncfusion: For a clean and modern UI design.

## Setup Instructions
### Prerequisites
- .NET 8 SDK
- npm
- SQL Server or any other compatible database
- syncfusion community license

### Clone the repository:
- git clone https://github.com/AviHeifets/RestaurantManagementSystem.git

### backend setup:
- Install the required packages:
- Update the appsettings.json file with your database connection.
- update userSecrets with the google auth keys as
- "Authentication:Google:ClientId":
- "Authentication:Google:ClientSecret":

### Apply migrations and update the database:
- update database
- Run the application

### Frontend Setup:
- use npm install
- in main.app 
- add the syncfusion key and the google client Id

- Start the development server:

## Usage
- Login: Use your Google account to log in.
- Submit Availability: Employees can submit their available times for the upcoming week.
- Edit Schedule: Managers can view, edit, and finalize the weekly schedule.
- View Schedule: All users can view the finalized schedule.

## Screenshots
![Alt Text](screenshots/login.png?raw=true "login")
![Alt Text](screenshots/template.png?raw=true "templates")
![Alt Text](screenshots/submitted.png?raw=true "submitted")
![Alt Text](screenshots/checked.png?raw=true "checked")
![Alt Text](screenshots/edited.png?raw=true "edited")
![Alt Text](screenshots/shiftEdit.png?raw=true "edit menu")
![Alt Text](screenshots/configuration.png?raw=true "configuration")
![Alt Text](screenshots/types.png?raw=true "types")



## Future Enhancements
- Google Calander Output: output all the shifts to your google calander.
- Notifications: Implement email/SMS notifications for schedule updates.
- Mobile App: Develop a mobile application for easier access.
- Advanced Reporting: Add detailed reports and analytics for shift management.

## License
- This project is licensed under the MIT License. See the LICENSE file for more information.

## Contact
For any questions or feedback, please contact us at 
aviel30045@gmail.com
natanbutbul@gmail.com

Thank you for using the Shift Management System! We hope it makes managing shifts easier and more efficient.





