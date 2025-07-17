using System;

public class Program2
{
        static Program2()
        {
            Console.WriteLine("This is a static constructor and it is only called once");
        }

        public String CallMyName(String UserName)
        {
            return "Hello " + UserName;
        }
}