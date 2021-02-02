using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_From_Scratch.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required (ErrorMessage ="Please Enter your Name")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Please Give your Addess")]
        public String Address { get; set; }
        [Required(ErrorMessage = "Please Enter your Age")]
        public int Age { get; set; }
   

        public Customer ()
            {


           }
        public Customer(int id, string name, string address, int age)
        {
            ID = id;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}