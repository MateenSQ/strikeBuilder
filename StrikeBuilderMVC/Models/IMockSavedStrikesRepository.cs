namespace StrikeBuilderMVC.Models
{
    public interface IMockSavedStrikesRepository
    {
        public List<Strike> GetAllSavedStrikes();

        public int GetHighestOrder();

        public void AddStrikeToSaved(Strike selectedStrike);
    }
}
