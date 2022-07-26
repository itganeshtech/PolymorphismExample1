using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExample1
{
    class Teacher : User
    {

        public Teacher()
        {
            Console.WriteLine("Creating Teacher Object");
        }
        public override void HelloToConsole()
        {
            Console.WriteLine("Hi i am Teacher" + FullName);

        }

    }
}
