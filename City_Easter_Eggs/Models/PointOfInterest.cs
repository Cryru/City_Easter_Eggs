﻿namespace City_Easter_Eggs.Models
{
    public class PointOfInterest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
        public int TimeStamp { get; set; }
        public string UserId { get; set; }
        public int Likes { get; set; }

    }
}
