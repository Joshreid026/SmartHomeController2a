using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class SmartLight : SmartDevice
    {
        // Private fields
        private double brightness;
        private string colour;

        // Public properties
        public double Brightness
        {
            get { return brightness; }
            set { brightness = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        // Constructor
        public SmartLight(int deviceID, string deviceName) : base(deviceID, deviceName)
        {
            this.Brightness = 0.5; // Default brightness
            this.Colour = "White"; // Default colour
        }


        public void SetBrightness(double brightness)
        {
            this.Brightness = brightness;
            Console.WriteLine($"Brightness now set to {Brightness}");
        }

        public void SetColour(string colour)
        {
            this.Colour = colour;
            Console.WriteLine($"Colour now set to {Colour}");
        }


    }
}