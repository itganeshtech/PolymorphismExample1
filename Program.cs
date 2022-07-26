using System;
using System.Collections.Generic;

namespace PolymorphismExample1
{
    class Program
    {
        public static void Main(string[] args)
        {
            new Program().DoSomething();
           // DoSomething();
        }

        public void DoSomething()
        {
            Student me = new Student();
            me.FirstName = "AAA";
            Teacher you = new Teacher();
            you.FirstName = "Bagchi";
            List<User> users = new List<User>() { me, you };
            {
                foreach(User c in users)
                {
                    c.HelloToConsole();
                }
            }

        }
    }
}
