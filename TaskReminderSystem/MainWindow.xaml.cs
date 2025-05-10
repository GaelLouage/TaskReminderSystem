using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaskReminderSystemInfra.Models;
using TaskReminderSystemInfra.Services.Classes;
using TaskReminderSystemInfra.Services.Interfaces;

namespace TaskReminderSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ITaskReminderService _taskService;

        public MainWindow(ITaskReminderService taskService)
        {
            _taskService = taskService;
        }

        public MainWindow() : this (new TaskReminderService())
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {


            // Add sample tasks
            _taskService.AddTask(new TaskItemEntity
            {
                Title = "Task 1",
                Description = "Old task",
                DueDate = DateTime.Now.AddDays(-10)
            });

            _taskService.AddTask(new TaskItemEntity
            {
                Title = "Task 2",
                Description = "Upcoming task",
                DueDate = DateTime.Now.AddDays(3)
            });

            _taskService.AddTask(new TaskItemEntity
            {
                Title = "Task 3",
                Description = "Far future task",
                DueDate = DateTime.Now.AddDays(10)
            });
        }

        private void btnGetUpcomingTasks_Click_1(object sender, RoutedEventArgs e)
        {
            // Clean up old tasks
            _taskService.CleanupOldTasks(7);
            lvTasks.ItemsSource = null;
            lvTasks.ItemsSource = _taskService.GetUpcomingTasks(7);
        }
    }
}