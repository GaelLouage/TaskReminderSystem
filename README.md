# 🧠 Task Reminder System

A simple C# service to manage task reminders with auto-cleanup functionality.  
Ideal for practicing service design, LINQ, and clean code principles.

---

## 🔧 Features

- Add new tasks with title, description, and due date.
- Get a list of upcoming tasks within a custom number of days.
- Automatically remove tasks that are overdue by more than N days.
- Clean, testable service structure using interfaces and dependency injection.

---

## 📁 Project Structure

TaskReminderSystemInfra/
├── Models/
│ └── TaskItemEntity.cs
├── Services/
│ ├── Classes/
│ │ └── TaskReminderService.cs
│ └── Interfaces/
│ └── ITaskReminderService.cs


---

## 🛠️ Technologies

- C# (.NET 6+)
- LINQ
- Console Application
- SOLID Principles

---

## 🚀 Getting Started

1. Clone the repo:
   ```bash
   git clone https://github.com/YourUsername/TaskReminderSystem.git

    Open the solution in Visual Studio or VS Code.

    Run the program:

        Add sample tasks using the AddTask() method.

        Call GetUpcomingTasks(days) to list near-due tasks.

        Use CleanupOldTasks(days) to remove expired ones.

🧪 Example Usage

ITaskReminderService service = new TaskReminderService();

service.AddTask(new TaskItemEntity {
    Title = "Finish report",
    Description = "Q2 financials",
    DueDate = DateTime.Now.AddDays(2)
});

var upcoming = service.GetUpcomingTasks(3);
service.CleanupOldTasks(7);
