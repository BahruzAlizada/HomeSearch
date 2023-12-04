using System;
namespace EntityLayer.Concrete
{
    public class Home
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int TypeeId { get; set; }
        public int AppUserId { get; set; }
        public int CityId { get; set; }
        public int RepairId { get; set; }
        public int? RoomId { get; set; }
        public int DistrictId { get; set; }
        public int? MetroId { get; set; }


        public string Description { get; set; }
        public int Price { get; set; } // Qiymet
        public double Area { get; set; } // Sahe

        public int? Floor { get; set; } // Mertebe
        public int? FlourNumber { get; set; } //Mertebelerin sayi
        public bool? IsNewBuilding { get; set; } //Yeni tikilib

        public double? LandArea { get; set; } //Opsi sahe

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }

        public bool IsMortgage { get; set; } // Ipoteka
        public bool IsExtract { get; set; } //Cixaris
        public bool IsPremium { get; set; }
        public bool IsDeactive { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow.AddHours(4);
        public DateTime? PremiumDeadLine { get; set; }
        public DateTime Deadline { get; set;}


        public Category Category { get; set; }
        public Typee Typee { get; set; }
        public AppUser AppUser { get; set; }
        public City City { get; set; }
        public Repair Repair { get; set; }
        public Room? Room { get; set; }
        public District District { get; set; }
        public Metro? Metro { get; set; }
        public List<HomeImage> HomeImages { get; set; }
    }
}
