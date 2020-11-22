using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Data
{
    public class EmployeeInfo
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }

    }
}
