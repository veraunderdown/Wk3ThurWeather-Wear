using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3ThurWeather_Wear
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature;
            int humidity;
            int windspeed;
            int cloudcover;

            Console.Write("Enter temperature: ");
            temperature = int.Parse(Console.ReadLine());

            Console.Write("Enter humidity: ");
            humidity = int.Parse(Console.ReadLine());

            Console.Write("Enter windspeed: ");
            windspeed = int.Parse(Console.ReadLine());

            Console.Write("Enter cloudcover: ");
            cloudcover = int.Parse(Console.ReadLine());

            if((temperature > 20) && (windspeed < 30));
            Console.Write("Wear swimwear!");
            
            if (cloudcover < 5) ;
            Console.Write("Wear a hat!");
            
            if((humidity > 70) && (windspeed < 10));
            Console.Write("Take an umbrella!");
            
            else 
            Console.Write("Wear a raincoat!");
            
            if ((temperature > 15) && (temperature < 20));
            Console.Write("Wear shorts!"); 

            else if (temperature <= 15)
                Console.Write("Wear trousers!");

        }
    }
}
