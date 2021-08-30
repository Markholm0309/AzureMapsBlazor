using System;
using System.Collections.Generic;

namespace AzureMaps.Data.Entities
{
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Category
    {
        public string id { get; set; }
        public string title { get; set; }
    }

    public class Source
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Geometry
    {
        public object magnitudeValue { get; set; }
        public object magnitudeUnit { get; set; }
        public DateTime date { get; set; }
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Event
    {
        public string id { get; set; }
        public string title { get; set; }
        public object description { get; set; }
        public string link { get; set; }
        public object closed { get; set; }
        public List<Category> categories { get; set; }
        public List<Source> sources { get; set; }
        public List<Geometry> geometry { get; set; }
    }

    public class Root
    {
        public string title { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public List<Event> events { get; set; }
    }
}