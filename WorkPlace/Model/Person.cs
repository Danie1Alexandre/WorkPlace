using System;
using System.Collections.Generic;
using System.Text;

namespace WorkPlace.Model
{
    // person = child, Iinformation = Parent 
    class Person : Iinformation
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string ContactAdress { get; set; }

        public string Info()
        {
            return $"{Iinformation.INFOTEXT}\n  {Name}\n  {Phone}\n  {ContactAdress}";
        }
    }
}
