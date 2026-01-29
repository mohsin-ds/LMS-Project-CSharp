This is a professional, high-quality `README.md` template designed specifically for your project. You can copy and paste this directly into a file named **README.md** in your project folder.

---

# 🎓 Learning Management System (LMS)

Developed by **Muhammad Mohsin** & **Ahmed Dawood**

A comprehensive, full-stack Learning Management System built to streamline the education process. This application provides distinct, secure interfaces for both **Teachers** and **Students**, allowing for seamless course management, automated grading, and real-time data tracking.

---

## 🚀 Key Features

### **For Teachers 👨‍🏫**

* **Course Management:** Create, update, and manage multiple courses with unique codes.
* **Assignment Module:** Publish assignments with specific due dates, point values, and file attachments.
* **Quiz Engine:** Build interactive MCQ-based quizzes with custom timers and question banks.
* **Grade Book:** A centralized view to grade student submissions and track overall class performance.

### **For Students 👨‍🎓**

* **Personal Dashboard:** Track enrolled courses, pending assignments, and upcoming quizzes.
* **Submission Portal:** Upload assignment files directly through the app.
* **Real-time Results:** Take quizzes and receive instant scoring and performance feedback.
* **Grade Tracking:** View a complete history of obtained marks and feedback for all activities.

### **System & Security 🛡️**

* **Role-Based Access:** Secure login system that directs users to their specific dashboard based on their role.
* **Password Recovery:** Integrated **SMTP (Gmail API)** to send recovery codes directly to the user's email.
* **Activity Logs:** Real-time tracking of project actions (Course creation, Enrollments, etc.).

---

## 🛠️ Tech Stack

| Category | Technology |
| --- | --- |
| **Language** | C# (.NET Framework) |
| **UI Framework** | Windows Forms (WinForms) |
| **Database** | MySQL (Relational Schema) |
| **Integration** | SMTP Protocol (Gmail) |
| **Version Control** | Git / GitHub |

---

## 📦 Database Setup

To run this project locally, you will need to set up the MySQL database:

1. **Install MySQL Workbench.**
2. **Import Schema:** Locate the `database_export.sql` file in this repository.
3. **Run Script:** Execute the script to create the tables (`users`, `courses`, `assignments`, `quizzes`, `submissions`, etc.).
4. **Connection String:** Update the `App.config` or connection class in the C# code with your local MySQL `server`, `user`, and `password`.

---

## 📸 Demo Preview

> [!TIP]
> **Showcase Tip:** You can upload screenshots of your Teacher Dashboard and Student Quiz screens here to make the README more visual!

---

## 🤝 The Development Team

This project was a collaborative effort between:

* **Muhammad Mohsin** – Lead Developer / Logic & Backend
* **Ahmed Dawood** – Lead Developer / UI Design & Database Architecture

---

### **Security Warning**

> [!IMPORTANT]
> For security reasons, the Gmail SMTP password and MySQL root password have been removed from the public code. Please use your own credentials in the configuration file to test the email and database features.
