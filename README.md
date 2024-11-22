# CMCS!

Overview

The Contract Monthly Claim System (CMCS) is a web-based application designed to streamline the claim submission, approval, and processing workflows for educational institutions. It automates calculations, validation, and report generation, improving efficiency and accuracy for lecturers, program coordinators, academic managers, and HR teams.

Features

Lecturer View
Claim Submission: Lecturers can input their worked hours and hourly rates to submit claims.
Auto-Calculation: Automatically computes final payment based on inputs.
Validation: Ensures accurate data entry, such as non-negative numbers and valid hourly rates.
Program Coordinator & Academic Manager View
Claim Verification: Automated checks against predefined criteria (e.g., hours worked, hourly rates).
Approval Workflow: Streamlines the approval process for submitted claims.
Secure Access: Role-based authentication and authorization using ASP.NET Identity.
HR View
Claim Processing: Generates invoices and reports summarizing approved claims.
Lecturer Data Management: Allows updates to lecturer details, such as contact information.
Reporting: Uses integrated tools like Crystal Reports or SSRS for detailed reporting.
Technologies Used

Backend:

ASP.NET Core MVC: Framework for building the web application.
Entity Framework: ORM for managing data (future database integration optional).
Frontend:

HTML/CSS: For page structure and styling.

Authentication & Authorization:

ASP.NET Identity: Secures the application with user roles and permissions.
Reporting:

Placeholder for tools like Crystal Reports or SSRS for future reporting enhancements.
Installation and Setup

Clone the Repository

git clone https://github.com/your-repo/CMCS.git
cd CMCS
Open the Project

Launch Visual Studio and open the .sln file.
Run the Application

Press F5 or click Start in Visual Studio to run the application.
Login Credentials

Default roles and accounts for testing:
Lecturer: lecturer@example.com / password123
Program Coordinator: coordinator@example.com / password123
HR Manager: hr@example.com / password123
Usage
Lecturer:

Navigate to the "Submit Claim" page.
Enter hours worked and hourly rate.
Submit the claim and view the calculated payment.
Program Coordinator/Academic Manager:

Review submitted claims.
Approve or reject claims based on criteria.
HR:

Generate reports or invoices for approved claims.
Update lecturer data.
Commit Workflow
Stage Changes


git add .
Commit Changes


git commit -m "Descriptive commit message"
Push to GitHub


git push
Future Enhancements
Integration with a database for real-time data storage and retrieval.
Comprehensive reporting features using SSRS or similar tools.
Notification system for approval and claim status updates.
Responsive design for mobile and tablet compatibility.
Contributing
Fork the repository.
Create a new feature branch:

git checkout -b feature-name
Commit your changes and push to your forked repo.
Submit a pull request.


Contact
For any queries or issues, please contact:
Email: ST10345300@VCCONNECT.EDU.ZA
GitHub: ST10345300
