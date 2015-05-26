namespace RaspberryPi.Sensor.Program
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading;

    using RaspberryPi.DotNet;

    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            if (File.Exists("testFile.xml"))
            {
                Console.WriteLine("File exists");
            }

            if (Directory.Exists("TestDir"))
            {
                DirectoryInfo di = new DirectoryInfo("TestDir");
                Debug.WriteLine(string.Format(" dir {0}", di.Name));
            }

            Thread.Sleep(300);

            GPIOFile fp = new GPIOFile(GPIOPins.GPIO_00);
        }
    }
}
