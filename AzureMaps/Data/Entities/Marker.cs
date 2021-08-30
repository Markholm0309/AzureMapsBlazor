namespace AzureMaps.Data.Entities
{
    public class Marker
    {
        public Marker(double lat, double lon, string name, string description)
        {
            this.Lat = lat;
            this.Lon = lon;
            this.Name = name;
            this.Description = description;
        }

        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}