using System;
using System.Collections.Generic;
using System.Text;

namespace WorkPlace.Model
{
    // administrator = child > , Employee = Parent/ child > , person = parent/child > , Iinformation = Parent
   
    class Administrator : Employee
    {
        List<Employee> employeesList;
        public int Bonus { get; set; }
       
        
        public new string Info()
        {
            return base.Info() + $"\n  Bonus: {Bonus}";
        }


        public override string[] TasksToDO()
        {
            return 
        }
    }
}
