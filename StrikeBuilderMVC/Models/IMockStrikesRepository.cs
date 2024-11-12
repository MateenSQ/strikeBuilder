namespace StrikeBuilderMVC.Models
{
    public interface IMockStrikesRepository
    {
        public List<Strike> GetAllStrikes();

        public Strike GetStrikeById(int id);
    }
}
