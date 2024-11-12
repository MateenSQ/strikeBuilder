namespace StrikeBuilderMVC.Models
{
    public class MockSavedStrikesRepository : IMockSavedStrikesRepository
    {
        public IEnumerable<Strike> SavedStrikes = Enumerable.Empty<Strike>();

        public List<Strike> GetAllSavedStrikes()
        {
            return SavedStrikes.ToList();
        }
    }
}
