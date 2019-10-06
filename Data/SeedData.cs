using System.Collections.Generic;
using Lab04.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab04.Data{
    public static class SeedData {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
        }
        public static List<Province> GetProvinces() {
            List<Province> provinces = new List<Province>() {
                new Province() {    // 1
                    ProvinceCode ="BC",
                    ProvinceName="British Columbia",
                },
                new Province() {    // 2
                    ProvinceCode ="ON",
                    ProvinceName="Ontario",
                },
                new Province() {    // 3
                    ProvinceCode ="QC",
                    ProvinceName="Québec",
                },
            };

            return provinces;
        }

        public static List<City> GetCities() {
            List<City> cities = new List<City>() {
                new City {
                    CityId = 1,
                    CityName = "Vancouver",
                    ProvinceName="British Columbia",
                    Population = 675218
                },
                new City {
                    CityId = 2,
                    CityName = "Richmond",
                    ProvinceName="British Columbia",
                    Population = 216288 
                },
                new City {
                    CityId = 3,
                    CityName = "Surrey",
                    ProvinceName="British Columbia",
                    Population = 518467 
                },
                new City {
                    CityId = 4,
                    CityName = "Toronto",
                    ProvinceName="Ontario",
                    Population = 2930000 
                },
                new City {
                    CityId = 5,
                    CityName = "Ottawa",
                    ProvinceName="Ontario",
                    Population = 994837 
                },
                new City {
                    CityId = 6,
                    CityName = "Mississauga",
                    ProvinceName="Ontario",
                    Population = 828854 
                },
                new City {
                    CityId = 7,
                    CityName = "Montreal",
                    ProvinceName="Quebéc",
                    Population = 1780000 
                },
                new City {
                    CityId = 8,
                    CityName = "Quebéc City",
                    ProvinceName="Quebéc",
                    Population = 542298 
                },
                new City {
                    CityId = 9,
                    CityName = "Gatineau",
                    ProvinceName="Quebéc",
                    Population = 284557 
                },
            };

            return cities;
        }
    }
}