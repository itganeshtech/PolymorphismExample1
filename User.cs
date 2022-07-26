using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExample1
{
    public abstract class User
    {
        public string FullName
        {
            get
            { return FirstName + " " + LastName;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void HelloToConsole();
    }
}
