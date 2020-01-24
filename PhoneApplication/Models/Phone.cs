using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
       

        int PhoneId = 0;
        
        public Phone()
        {
            
            PhoneName="";
            Manufacturer="";
        
            DateRelease=new DateTime();

        }
        public int PhoneID { get; set; }
        public String PhoneName { get; set; }

        public String Manufacturer { get; set; }
        public float MSRP { get; set; }
        public int ScreenSize { get; set; }
        public DateTime DateRelease { get; set; }
    }
}