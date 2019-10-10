using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab25New.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Price is required")]
        [Range(1,150)]
        
        public float Price { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
       [Range(1,1000)]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(2000, MinimumLength = 1)]
        public string Description { get; set; }


    }
}
