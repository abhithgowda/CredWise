# CredWise - Bank Loan Management System

![Project Banner](https://placehold.co/1200x400/4F46E5/FFFFFF?text=CredWise&font=raleway)

CredWise is a comprehensive, web-based application designed to streamline the entire loan management lifecycle for banking institutions. Built with **ASP.NET 8** and following the **MVC architecture**, this system provides a robust and user-friendly solution for managing loan applications, approvals, disbursements, and repayments.

---

## ✨ Core Features

The system is built upon a modular architecture, ensuring it is both scalable and easy to maintain.

* **👤 Customer Management:** Securely handles customer registration, profile management, and KYC (Know Your Customer) verification.
* **🏦 Loan Product Management:** Allows bank administrators to create, define, and manage various loan products (e.g., Personal, Home, Vehicle), including their interest rates, tenures, and eligibility criteria.
* **📄 Loan Application & Approval:** Provides a seamless workflow for customers to apply for loans online and for administrators to review and process these applications (approve/reject) efficiently.
* **💳 Repayment Management:** Automates the generation of repayment schedules, tracks payments made, and calculates outstanding balances to ensure timely compliance and reduce manual errors.
* **📊 Reporting & Auditing:** Generates insightful reports on loan statistics, repayment statuses, and customer portfolios, offering transparent oversight for administrative and auditing purposes.

---

## 🛠️ Tech Stack & Tools

This project was built using a modern and robust technology stack:

* **Backend:** ASP.NET 8 Core MVC
* **Frontend:** HTML5, CSS3, JavaScript (ES6+), jQuery, Bootstrap 5
* **Database:** Microsoft SQL Server (can be adapted for MySQL)
* **Architecture:** Model-View-Controller (MVC)
* **Development IDE:** Visual Studio
* **Version Control:** Git & GitHub

---

## 🚀 Getting Started

Follow these instructions to set up and run the project on your local machine for development and testing purposes.

### Prerequisites

Make sure you have the following software installed on your machine:

* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* [Visual Studio](https://visualstudio.microsoft.com/) (with ASP.NET and web development workload)
* [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or another SQL Server instance.

### Local Deployment Steps

1.  **Clone the Repository**
    ```sh
    git clone https://github.com/abhithgowda/CredWise.git
    ```
    *(Replace `YOUR_USERNAME` with your GitHub username)*

2.  **Configure the Database**
    * Open the project in Visual Studio.
    * Navigate to the `appsettings.json` file.
    * Update the `ConnectionString` to point to your local SQL Server instance.
    * Run the database schema scripts provided below in SQL Server Management Studio (SSMS) or your preferred database tool to create the necessary tables.

3.  **Build and Run the Application**
    * Use Visual Studio to build the solution (`Build > Build Solution`). This will restore all necessary NuGet packages.
    * Run the application by pressing `F5` or clicking the "Start" button.
    * The application will launch in your default web browser, typically on a port like `http://localhost:5000`.

