# Gym Membership Management System

 Project Description

The Gym Membership Management System is a C# Windows Forms application designed to help a gym manage member information and membership details.

The system allows users to add, view, edit, and remove gym members. It also provides membership types and monthly membership fees.

 Main Features

* Add a new gym member
* Remove an existing member
* Edit member information
* Clear input fields
* View member details
* Select Basic, Standard, or Premium membership
* Display monthly membership fees
* Validate user input
* Prevent duplicate member IDs
* Display Premium member information, including personal trainer availability

 Technologies Used

* C#
* .NET
* Windows Forms
* Visual Studio
* Git and GitHub

 Object-Oriented Programming Concepts

The project demonstrates the following object-oriented programming concepts:

 Abstraction

The `Person` class is an abstract class that provides common properties and behaviour for people in the system.

 Encapsulation

Member information is stored inside classes using properties, while member management operations are controlled through the `GymManager` class.

 Inheritance

The `Member` class inherits from `Person`.

The `PremiumMember` class inherits from `Member`.

 Polymorphism

The `GetDetails()` method is overridden in the `Member` and `PremiumMember` classes. This allows different member types to provide their own implementation of the method.

 Exception Handling

The application uses validation and exception handling to deal with invalid input, duplicate member IDs, missing information, and other errors.

 Project Structure

```text
GymMembershipManagementSystem
│
├── Models
│   ├── Person.cs
│   ├── Member.cs
│   ├── PremiumMember.cs
│   └── Membership.cs
│
├── Services
│   └── GymManager.cs
│
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
└── Program.cs
```

 Membership Types

| Membership Type | Monthly Fee |
| --------------- | ----------: |
| Basic           |      $30.00 |
| Standard        |      $45.00 |
| Premium         |      $60.00 |

 How to Run

1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Build the solution.
4. Run the application.
5. Enter member information using the form.
6. Select a membership type.
7. Use the available buttons to manage members.

 Validation

The application checks that:

* Member ID is numeric.
* Member name is not empty.
* Phone number is provided.
* Email address is provided.
* A membership type is selected.
* Duplicate member IDs are not allowed.
* A member must be selected before editing, viewing, or removing.

 Development

This project was developed using Visual Studio and GitHub. Development commits are used to track meaningful changes to the application throughout the project.

 References and Tools

* Microsoft Learn — C# documentation
* Microsoft Learn — Windows Forms documentation
* Visual Studio documentation
* GitHub documentation

Generative AI Usage

Generative AI was used as a study and development support tool for explanations, debugging guidance, and understanding programming concepts. All code used in the project was reviewed, tested, and understood by the student.

 Author

**Jiban Budhathoki**

**Student ID:** S2400429
