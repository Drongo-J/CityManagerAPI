﻿namespace CityManagerApi.Models
{
    public class City
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Photo> Photos { get; set; }
        public City()
        {
            User = new User();  
            Photos = new List<Photo>();
        }
    }
}
