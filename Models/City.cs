using System;

namespace Lab04.Models{
    public class City {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string ?ProvinceName {get; set;}
        public int Population {get; set;}
    }
}
