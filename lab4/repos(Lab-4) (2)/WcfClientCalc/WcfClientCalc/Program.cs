using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfClientCalc.ServiceReference1;

namespace WcfClientCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)3072;
            Service1Client client = new Service1Client();
            // Ener arguments from console.
            Console.Write("Enter value 1: ");
            double value1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value 2: ");
            double value2 = Convert.ToDouble(Console.ReadLine());
            // Call the Add service operation.
            double result = client.Add(value1, value2);
            Console.WriteLine("\nAdd({0},{1}) = {2}", value1, value2, result);
            // Call the Subtract service operation.
            result = client.Subtract(value1, value2);
            Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);
            // Call the Multiply service operation.
            result = client.Multiply(value1, value2);
            Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);
            // Call the Divide service operation.
            result = client.Divide(value1, value2);
            Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);
            Console.WriteLine("\nPress <ENTER> to terminate client.");
            Console.ReadLine();
            //Closing the client releases all communication resources.
            client.Close();
        }
    }
}
