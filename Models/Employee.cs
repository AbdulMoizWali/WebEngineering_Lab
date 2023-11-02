using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEngineering.Models
{
    public class Employee
    {
        public Employee() { }
        public Employee(int id, string name, string email, int age, string phoneContact, DateTime dOJ, string country)
        {
            Id = id;
            this.name = name;
            this.email = email;
            this.age = age;
            this.phoneContact = phoneContact;
            DOJ = dOJ;
            this.country = country;
        }

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name of employee is required")]
        [DisplayName("Name")]
        public string name { get; set; }

        [Required(ErrorMessage ="Email of employee is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$", ErrorMessage ="Must be valid email")]
        [DisplayName("Email")]
        public string email { get; set; }


        [Range(16,60)]
        [DisplayName("Age")]
        public int age { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone Contact")]
        public string phoneContact { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date of Joining")]
        public DateTime DOJ { get; set; }

        [DisplayName("Country")]
        public string country { get; set; }
    }
}