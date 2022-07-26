using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExample1
{
    class Student:User
    {
        public Student()
        {
            Console.WriteLine("Creating Student Object");
        }
        public override void HelloToConsole()
        {
            Console.WriteLine("Hi i am student " + FullName);
            
        }

       
    }
}
