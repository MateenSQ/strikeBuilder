namespace StrikeBuilderMVC.Models
{
    public class Strike
    {
        public int Id { get; set; }
        public int? Order { get; set; } = null;
        public string Name { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public string OriginDescription { get; set; } = string.Empty;
    }
}
