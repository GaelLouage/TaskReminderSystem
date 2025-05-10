using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskReminderSystemInfra.Models;

namespace TaskReminderSystemInfra.Services.Interfaces
{
    public interface ITaskReminderService
    {
        void AddTask(TaskItemEntity task);
        List<TaskItemEntity> GetUpcomingTasks(int days);
        void CleanupOldTasks(int days);
    }
}
