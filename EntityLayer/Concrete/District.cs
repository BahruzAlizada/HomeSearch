using CoreLayer.Entity;
using System;

namespace EntityLayer.Concrete
{
    public class District : IEntity
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public bool IsMain { get; set; }
        public List<District> Children { get; set; }
        public District Parent { get; set; }
        public int? ParentId { get; set; }
        public bool IsDeactive { get; set; }

        public List<Home> Homes { get; set; }
    }
}
