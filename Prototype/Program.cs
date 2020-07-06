using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone10plan = new PhoneSketch
            {
                Model = "phone10",
                Hardware = "Ram 4 & ...",
                OS = new OperationSystem
                {
                    Name = "Android",
                    Version = 10
                }
            };
                
            var phone10PROplan = phone10plan.Clone() as PhoneSketch;
            phone10PROplan.Model = "phone10 Pro";
            phone10PROplan.Hardware = "Ram 6";

            phone10PROplan.OS.Version = 11;

            Console.WriteLine(phone10plan.OS.Version.ToString());
            Console.WriteLine(phone10PROplan.OS.Version.ToString());

        }
    }
}
