using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Otthonbazar.Data
{
    public class City
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "required!"), StringLength(4, MinimumLength = 4)]
        public string Zip { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Advertisement> Advertisements { get; set; }
    }
}
