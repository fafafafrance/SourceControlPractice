using System;
using System.Collections.Generic;
using System.Text;

namespace SourceControlPractice
{
    public class ThreeDPrinter
    {
        // Auto Implented properties
        public string ProductName { get; set; }
        public string BuildVolume { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateRelease { get; set; }
        public List<string> SupportFilament { get; set; }

        // Constructor to initialize the collection
        public ThreeDPrinter() 
        {
            SupportFilament = new List<string>();
        }
    }
}
