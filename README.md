Gym Membership Management System

Project Description

The Gym Membership Management System is a C# Windows Forms application designed to help a gym manage member information and membership details.

The system allows users to add, view, edit, remove, and search gym members. It also manages membership types, membership fees, membership dates, membership expiry status, payment status, and local JSON data persistence.

Main Features

* Add a new gym member
* View member details
* Edit member information
* Remove an existing member
* Clear input fields
* Search members by name or Member ID
* Select Basic, Standard, or Premium membership
* Display monthly membership fees
* Automatically calculate membership expiry dates
* Display membership status:
    * Active
    * About to Expire
    * Expired
* Track payment status:
    * Paid
    * Outstanding
* Save member records to a local JSON file
* Load saved member records from a local JSON file
* Validate user input
* Prevent duplicate member IDs
* Display Premium member information, including personal trainer availability
* Handle runtime errors using exception handling

Technologies Used

* C#
* .NET
* Windows Forms
* Visual Studio
* Git and GitHub
* Object-Oriented Programming
* JSON

Object-Oriented Programming Concepts

The project demonstrates the following object-oriented programming concepts.

Abstraction

The Person class is an abstract class that provides common properties and behaviour for people in the system.

Encapsulation

Member information is stored inside classes using properties, while member management operations are controlled through the GymManager class.

The GymManager class maintains the member collection internally and provides methods such as AddMember(), FindMemberById(), RemoveMember(), and SetMembers() to manage the data.

Inheritance

The Member class inherits from Person.

The PremiumMember class inherits from Member.

Polymorphism

The GetDetails() method is overridden in the Member and PremiumMember classes. This allows different member types to provide their own implementation of the method.

Exception Handling

The application uses validation and try-catch exception handling to deal with invalid input, duplicate member IDs, missing information, file operations, and other runtime errors.

Project Structure

GymMembershipManagementSystem
│
├── Models
│   ├── Person.cs
│   ├── Member.cs
│   ├── PremiumMember.cs
│   └── Membership.cs
│
├── Services
│   ├── GymManager.cs
│   └── JsonStorageService.cs
│
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
└── Program.cs

Membership Types

Membership Type	Monthly Fee
Basic	$30.00
Standard	$45.00
Premium	$60.00

Membership Status

The application calculates membership status based on the membership expiry date.

* Active — membership has not expired and is not within the 30-day expiry period.
* About to Expire — membership expires within 30 days.
* Expired — the expiry date has passed.

Payment Status

Each membership can have one of two payment statuses:

* Paid
* Outstanding

The selected payment status is displayed in the member table and is retained when member information is edited.

JSON Data Persistence

Member records can be saved to a local members.json file.

The application can also load previously saved member records using the Load function.

If the JSON file does not exist, the application starts with an empty member list. File-related operations are handled using exception handling.

How to Run

1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Build the solution.
4. Run the application.
5. Enter the member information using the form.
6. Select a membership type and payment status.
7. Use the available buttons to manage members.
8. Use Save to store member records in JSON format.
9. Use Load to retrieve saved member records.

Validation

The application checks that:

* Member ID is numeric.
* Member name is not empty.
* Phone number is provided.
* Email address is provided.
* A membership type is selected.
* Duplicate Member IDs are not allowed.
* A member must be selected before editing, viewing, or removing.
* Appropriate error messages are displayed when invalid information is entered.

Development

The project was developed incrementally using Visual Studio and GitHub.

GitHub commits were used to record meaningful development changes throughout the project, including implementation of member management, membership information, payment status, membership expiry status, member searching, and JSON persistence.

The application was tested after implementing individual features to confirm that the functionality worked as expected.

References and Tools Used

* Microsoft Learn — C# documentation
* Microsoft Learn — Windows Forms documentation
* Microsoft Learn — .NET documentation
* GitHub documentation
* Visual Studio documentation
* Generative AI used as a study and development support tool

Generative AI Usage

Generative AI was used as a study and development support tool for explanations, debugging guidance, programming concepts, and troubleshooting during development.

The student reviewed, tested, modified, and worked through the implementation and should be able to explain the functionality and design decisions demonstrated in the project.

Author

Jiban Budhathoki

Student ID: S2400429