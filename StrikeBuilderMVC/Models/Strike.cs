namespace StrikeBuilderMVC.Models
{
    public class Strike
    {
        public int Id { get; set; }
        public int? Order { get; set; } = null;
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
