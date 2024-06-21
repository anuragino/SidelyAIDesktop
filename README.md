# Sidely Form Desktop App

## Overview

This Windows Desktop Application is designed to replicate the functionality of Google Forms within a local desktop environment.
It allows users to create new submissions with various fields and view submitted entries sequentially. 
The application is built using Visual Basic in Visual Studio and includes basic CRUD operations for managing submissions.

## 🌟 Features
- **Create New Submission:**
  - Enter details such as Name, Email, Phone Number, and a GitHub repo link.
  - Start and pause a stopwatch.
  - Submit the form to store the submission.

- **View Submissions:**
  - Navigate through submitted entries using "Previous" and "Next" buttons.

- **Keyboard Shortcuts:**
  - Ctrl + S: Submits the form in the Create Submission page.

## Requirements

- Windows Desktop Environment
- Visual Studio (preferably 2019 or later) with Visual Basic support

## 🚦 Setup Instructions

1. **Clone the repository:** git clone `https://github.com/anuragino/SidelyAIDesktop.git`
2. Navigate to `File > Open > Project/Solution`
3. **Build and Run:** Press F5 or click on Start Debugging to build and run the application.

## Dependencies
.NET Framework (version used in Visual Studio project settings).

## Unresolved Issue: Data Not Being Stored in Database via API Endpoint
While testing the Windows Desktop Application, there is an issue where data submitted through the application's API endpoint is not being stored in the database, **despite the endpoint functioning correctly when tested with Postman**.
Unfortunately, I have **my end-term exam tomorrow** and need to focus on studying, so I won't be able to fix the bug today.

