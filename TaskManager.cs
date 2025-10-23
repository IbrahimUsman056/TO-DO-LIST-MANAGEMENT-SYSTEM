using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLibrary
{
    public class TaskManager
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        public void AddTask(TaskItem task)
        {
            tasks.Add(task);
        }
        public void UpdateTask(int id, TaskItem updatedTask)
        {
            foreach(TaskItem t in tasks)
            {
                if(t.TaskId == id)
                {
                    t.Title = updatedTask.Title;
                    t.Description = updatedTask.Description;
                    t.DueDate = updatedTask.DueDate;
                    t.IsCompleted = updatedTask.IsCompleted;
                }
            }
        }
        public void DeleteTask(int id)
        {
            foreach (TaskItem t in tasks)
            {
                if (t.TaskId == id)
                {
                    tasks.Remove(t);
                    return;
                }
            }
        }
        public List<TaskItem> GetAllTasks()
        {
            return tasks;
        }
        public void MarkAsCompleted(int id)
        {
            foreach (TaskItem t in tasks)
            {
                if (t.TaskId == id)
                {
                    t.IsCompleted= true;
                    return;
                }
            }
        }
    }
}
