using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using Npgsql;

namespace Productivity_Dashboard
{
    public static class DBHelper
    {
        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["PostgresConnection"].ConnectionString;

        public static bool InsertTask(TaskItem task)
        {
            try
            {
                using var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                string query = @"INSERT INTO tasks (name, due_date, status)
                                 VALUES (@name, @due_date, @status);";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("name", task.Name);
                cmd.Parameters.AddWithValue("due_date", task.DueDate);
                cmd.Parameters.AddWithValue("status", task.Status);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static List<TaskItem> GetAllTasks()
        {
            var tasks = new List<TaskItem>();

            try
            {
                using var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                string query = "SELECT name, due_date, status FROM tasks;";
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var task = new TaskItem
                    {
                        Name = reader.IsDBNull(0) ? "" : reader.GetString(0),
                        DueDate = reader.GetDateTime(1),
                        Status = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2)
                    };
                    tasks.Add(task);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tasks;
        }
    }
}
