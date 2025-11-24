using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHomeController
{
    public class SmartSecurityCamera
    {
        // Private fields
        private string resolution;
        private bool recordingStatus;

        // Public properties
        public string Resolution
        {
            get { return resolution; }
            set { resolution = value; }
        }


        public SmartSecurityCamera(string cameraResolution)
        {
            this.Resolution = cameraResolution;
            recordingStatus = false; // Default recording status

        }
     
    }
}
