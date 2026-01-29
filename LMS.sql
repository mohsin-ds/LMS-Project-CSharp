DROP DATABASE LMS;
CREATE DATABASE LMS;
USE LMS;

-- 1. Users Table
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Role VARCHAR(50) NOT NULL
);

-- 2. Courses Table
CREATE TABLE Courses (
    CourseID INT AUTO_INCREMENT PRIMARY KEY,
    CourseName VARCHAR(100) NOT NULL, 
    Description TEXT,
    JoinCode VARCHAR(20) UNIQUE NOT NULL,
    TeacherID INT,
    FOREIGN KEY (TeacherID) REFERENCES Users(UserID) ON DELETE CASCADE
);

-- 3. Enrollments Table
CREATE TABLE Enrollments (
    EnrollmentID INT AUTO_INCREMENT PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    EnrollmentDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (StudentID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE,
    UNIQUE(StudentID, CourseID) 
);

-- 4. Assignments Table
CREATE TABLE Assignments (
    AssignmentID INT AUTO_INCREMENT PRIMARY KEY,
    CourseID INT,
    Title VARCHAR(100),
    DueDate DATETIME,
    FilePath VARCHAR(255),
    MaxAttempts INT DEFAULT 1, 
    TotalMarks INT DEFAULT 10,
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);

-- 5. Quizzes Table
CREATE TABLE Quizzes (
    QuizID INT AUTO_INCREMENT PRIMARY KEY,
    CourseID INT,
    Title VARCHAR(100),
    DurationMinutes INT,
    DueDate DATETIME, 
    TotalAttempts INT DEFAULT 1,
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);

-- 6. Quiz Questions Table
CREATE TABLE QuizQuestions (
    QuestionID INT AUTO_INCREMENT PRIMARY KEY,
    QuizID INT,
    Statement TEXT NOT NULL,
    OptionA VARCHAR(255) NOT NULL,
    OptionB VARCHAR(255) NOT NULL,
    OptionC VARCHAR(255) NOT NULL,
    OptionD VARCHAR(255) NOT NULL,
    CorrectOption VARCHAR(50) NOT NULL,
    FOREIGN KEY (QuizID) REFERENCES Quizzes(QuizID) ON DELETE CASCADE
);

-- 7. Submissions Table
CREATE TABLE Submissions (
    SubmissionID INT AUTO_INCREMENT PRIMARY KEY,
    AssignmentID INT,
    StudentID INT,
    FilePath VARCHAR(255),
    Score INT DEFAULT NULL,
    Status VARCHAR(20) DEFAULT 'Pending',
    SubmissionDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Attempts INT DEFAULT 1,
    FOREIGN KEY (AssignmentID) REFERENCES Assignments(AssignmentID) ON DELETE CASCADE,
    FOREIGN KEY (StudentID) REFERENCES Users(UserID) ON DELETE CASCADE
);

-- 8. Quiz Results Table
CREATE TABLE QuizResults (
    ResultID INT AUTO_INCREMENT PRIMARY KEY,
    QuizID INT,
    StudentID INT,
    Score INT,
    Attempts INT DEFAULT 1,
    AttemptDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (QuizID) REFERENCES Quizzes(QuizID) ON DELETE CASCADE,
    FOREIGN KEY (StudentID) REFERENCES Users(UserID) ON DELETE CASCADE
);

-- 9. Activity Log Table
CREATE TABLE ActivityLog (
    LogID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT,
    ActivityText VARCHAR(255),
    ActivityTime DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);

-- Dummy Data
INSERT INTO Users (FullName, Email, Password, Role) VALUES
('Bilal Sadiq', 'teacher@test.com', '123', 'Teacher'),
('Ali Khan', 'student@test.com', '123', 'Student');