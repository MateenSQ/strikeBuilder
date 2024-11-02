using MongoDB.Bson;

namespace StrikeBuilderMVC.Models
{
    public class Planets
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; } = null!;
        public int OrderFromSun { get; set; }
        public bool HasRings { get; set; }
        public string[] MainAtmosphere { get; set; } = null!;
        public SurfaceTemperatureC SurfaceTemperatureC { get; set; } = null!;
    }
}
