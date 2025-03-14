using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaskItem> list = new List<TaskItem> {
                new TaskItem("Create ToDo List", false),
                new TaskItem("Write multiply table", false),
                new TaskItem("Create BuyMovieTicket system", false)
                
            };
            foreach (TaskItem task in list) {
                task.Display();
            }
            TaskItem.showOptions();
            string select = Console.ReadLine();
            if (select == "add")
            {
                TaskItem.AddTask(list);
            }
            else if (select == "remove") {

                TaskItem.RemoveTask(list);
            }



            foreach (TaskItem task in list)
            {
                task.Display();

            }
        
      
            

            Console.Read();
        }
    }
}

