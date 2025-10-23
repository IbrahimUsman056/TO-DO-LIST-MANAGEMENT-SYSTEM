using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLibrary
{
    public class TaskItem
    {
        private int taskId; 
        private string title; 
        private string description; 
        private DateTime dueDate; 
        private bool isCompleted;
        public int TaskId { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public TaskItem(int id, string title, string desc, DateTime due) { 
            TaskId = id; 
            Title= title;
            Description = desc; 
            DueDate = due; 
            IsCompleted = false; 
        }
    }
}
