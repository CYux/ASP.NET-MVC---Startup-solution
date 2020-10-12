using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Otthonbazar.Data
{
    public class Advertisement
    {
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public AdvertisementType AdvertisementType { get; set; }
        [Required]
        public int BuildDate { get; set; }
        [Required]
        public int CityId { get; set; }

        [Display(Name ="City Zip")]
        public City City { get; set; }
        public string Description { get; set; }
        [Required]
        public int HalfRoom { get; set; }
        [Required]
        public int Room { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Size { get; set; }
    }

    public enum AdvertisementType
    {
        [Display(Name = "Flat")]
        Flat,
        [Display(Name = "House")]
        House,
        [Display(Name = "HolidayHouse")]
        HolidayHouse,
        [Display(Name = "BuildingPlot")]
        BuildingPlot
    }
}