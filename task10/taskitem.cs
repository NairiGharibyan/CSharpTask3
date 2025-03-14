using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public  class TaskItem
    {
        static int counter = 0;
        public string Description;
        public bool IsCompleted;

        public TaskItem(string descr, bool flag) {
            Description = descr;
            IsCompleted = flag;
        }

        public void MarkComplete() {
            IsCompleted = true;
        }

        public void MarkInComplete() {
            IsCompleted = false;
        }
        public static void AddTask(List<TaskItem> list) {
            Console.WriteLine("Write your Task description");
            string desc = Console.ReadLine();
            list.Add(new TaskItem(desc, false));
            counter = 0;
        }
        public static void RemoveTask(List<TaskItem> list) {
            Console.WriteLine("Enter number of task you wanna Remove");
            int choice = int.Parse(Console.ReadLine());
            if (choice >= 0 && choice < list.Count)
            {
              
                list.RemoveAt(choice);
                Console.WriteLine($"Task{choice} removed succesfully");
                counter = 0;
            }
        }
        public static void showOptions() {
            Console.WriteLine("Select your option(Remove/Add)");
            Console.WriteLine($"Add task - 'add'");
            Console.WriteLine($"Remove Task - 'remove'");
            
        }
        public void Display() {
        
            Console.WriteLine($"({counter})  Task: '{Description}', Complete? - {IsCompleted}");
            counter++;
        }



    }
}

