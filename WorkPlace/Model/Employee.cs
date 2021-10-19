using System;
using System.Collections.Generic;
using System.Text;

namespace WorkPlace.Model
{
    // Employee = child, person = parent 
    class Employee : Person
    {
        int salery;
        protected string[] tasks;

        public int Salery { get { return salery; }  set { salery = value; } }
        public string Department { get; set; }


        public new string Info()
        {
            return base.Info() + $"\n  Salery: {Salery}";
        }


        public virtual string[] TasksToDO()
        {
            return tasks;
        }

    }
    
}
