using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ِAoDo_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task("wake up at 5:00");
            Task h = new Task("go to university");
            Task u = new Task("weekly family visit");
            Task n = new Task("sleeping early");
            TaskManager.AddTask(t);
            TaskManager.AddTask(h);
            TaskManager.AddTask(u);
            TaskManager.AddTask(n);
           
            

        }
    }
}
