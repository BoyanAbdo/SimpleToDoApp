using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }


        [StringLength(25, MinimumLength = 2), Required]
        public string FirstName { get; set; }

        [StringLength(25, MinimumLength = 2), Required]
        public string LastName { get; set; }

        public string Position { get; set; }

        public int Age { get; set; }

        public void Update(Employee employee)
        {
            this.FirstName = employee.FirstName;
            this.LastName = employee.LastName;
            this.Position = employee.Position;
            this.Age = employee.Age;
        }
    }
}
