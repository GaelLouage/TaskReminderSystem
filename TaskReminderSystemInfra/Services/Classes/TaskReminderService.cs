using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskReminderSystemInfra.Models;
using TaskReminderSystemInfra.Services.Interfaces;

namespace TaskReminderSystemInfra.Services.Classes
{
    public class TaskReminderService : ITaskReminderService
    {
        private List<TaskItemEntity> _tasks = new List<TaskItemEntity>();
        public void AddTask(TaskItemEntity task)
        {
            _tasks.Add(task);
        }
        // remove tasks with DueDate <= now -  days
        public void CleanupOldTasks(int days)
        {
           var oldDates =  _tasks.Where(x => x.DueDate <= DateTime.Now.AddDays(-days)).ToList();
           foreach (var task in oldDates) 
           {
               var taskId = task.Id;
               _tasks.RemoveAll(x => x.Id == taskId);
           }
        }
        // return tasks with DueDate <= now + days
        public List<TaskItemEntity> GetUpcomingTasks(int days)
        {
            return _tasks.Where(x => x.DueDate <= DateTime.Now.AddDays(days)).ToList();
        }
    }
}
