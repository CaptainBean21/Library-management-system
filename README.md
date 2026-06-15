# Relational Database & Role-Based Access Control Platform

A desktop management system built with C# and .NET that simulates a public library infrastructure. The project demonstrates architectural patterns, dynamic UI components, and relational database persistence using an Object-Relational Mapper (ORM).

# Key Features
* **Role-Based Access Control:** Provides different application modules and database privileges based on user authorization levels (`Admin`, `Librarian`, `Client`).
* **ORM Architecture:** Utilizes Entity Framework Core to map relational entities and manage data transactions.
* **Embedded Data Persistence:** Powered by a local SQLite database engine (`biblioteca.db`) ensuring lightweight, serverless data management.
* **Dynamic Business Logic:** Automated property getters that perform live evaluations (calculating custom late fees and rental states).
* **Centralized Viewport Rendering:** Uses a unified container window to swap between customized user controls.

# Technical Stack
* **Language:** C# (.NET)
* **Framework:** Windows Forms (WinForms)
* **Database & ORM:** EF Core, SQLite
* **Core Patterns:** Inheritance, Encapsulation, Single Responsibility Principle (SRP), Database Seeding.
