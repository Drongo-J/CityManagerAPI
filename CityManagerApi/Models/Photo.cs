﻿namespace CityManagerApi.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        public Photo()
        {
            City = new City();
        }
    }
}
