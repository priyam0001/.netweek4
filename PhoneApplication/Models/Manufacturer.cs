using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneApplication.Models
{
    public class Manufacturer
    {

        public Manufacturer()
        {
            
            ManufacturerName = "";


            Founded = new DateTime();

        }



        [Key]
        public int ManufacturerID { get; set; }
        public String ManufacturerName { get; set; }

        public String URL { get; set; }
        public ICollection<Phone> PhoneList { get; set; }
       
        public DateTime Founded { get; set; }
    }
}