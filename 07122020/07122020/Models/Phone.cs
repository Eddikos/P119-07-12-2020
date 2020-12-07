using System;
using System.Collections.Generic;
using System.Text;

namespace _07122020.Models
{
    public class OperatingSystem
    {
        public string Name { get; set; }
        public bool IsOpenSource { get; set; }



        public virtual string Main()
        {
            return this.Name;
        }
    }

    public class Android : OperatingSystem
    {
        public string XML { get; set; }

        public void WriteJavaCode()
        {
            Console.WriteLine("inner class");
        }
    }

    public class iOS : OperatingSystem
    {
        public string iCloud { get; set; }

        public void WriteSwiftCode()
        {
            Console.WriteLine(base.ReturnOSName() + " " + ReturnOSName() + ": wilSet asdasdsd");
        }

        public override string ReturnOSName()
        {
            return "ios";
        }
    }
}
