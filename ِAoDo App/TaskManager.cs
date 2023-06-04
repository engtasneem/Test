using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _ِAoDo_App
{
   static class TaskManager
    {
        static ArrayList task = new ArrayList();
        public static void AddTask(Task tas)
        {
            task.Add(tas);
        }
        public static void DeleteTask(Task tas)
        {
            task.Remove(tas);
        }
        public static void SearchForTask(Task tas)
        {
            if (task.IndexOf(tas) >= 0)
                Console.WriteLine(task.IndexOf(tas));
            else
                Console.WriteLine("-1");

        }

    }
}
