using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab04.Models{
    public class Province {
        [Key]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public List<City> Cities { get; set; }
    }
}