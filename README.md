# Productivity Dashboard

A modern C# WinForms-based productivity dashboard that allows users to manage tasks using a PostgreSQL backend.

## 🧩 Features

- Add, edit, and delete tasks
- PostgreSQL integration using Npgsql
- Responsive UI with Segoe UI styling
- Task list auto-refreshes after any operation
- Edit existing tasks via double-click

## 🚀 Tech Stack

- .NET 9.0 (WinForms)
- PostgreSQL
- Npgsql (.NET data provider)
- Visual Studio 2022+
- pgAdmin 4 for DB management

## 🛠️ Setup Instructions

1. **Clone the repository**

2. **Create PostgreSQL database and table**

```sql
CREATE TABLE tasks (
    id SERIAL PRIMARY KEY,
    name TEXT NOT NULL,
    due_date DATE NOT NULL,
    status TEXT NOT NULL
);
