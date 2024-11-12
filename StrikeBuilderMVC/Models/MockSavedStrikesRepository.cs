namespace StrikeBuilderMVC.Models
{
    public class MockSavedStrikesRepository : IMockSavedStrikesRepository
    {
        public List<Strike> SavedStrikes = new List<Strike>();

        public List<Strike> GetAllSavedStrikes()
        {
            return SavedStrikes.ToList();
        }

        public int GetHighestOrder()
        {
            if (SavedStrikes.Count() == 0)
            {
                return 0;
            }
            Strike foundStrike = SavedStrikes.OrderByDescending(x => x.Order).First();

            return foundStrike.Id;
        }

        public void AddStrikeToSaved(Strike selectedStrike)
        {
            SavedStrikes[0] = selectedStrike;

            //SavedStrikes.Append(selectedStrike);
        }
    }
}
