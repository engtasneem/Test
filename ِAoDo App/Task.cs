﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ِAoDo_App
{
    class Task
    {
        private string name;
        public Task(string name)
        {
            this.name = name;
        }
        public void PrintTask()
        {
            Console.WriteLine(name);
        }
    }

}

