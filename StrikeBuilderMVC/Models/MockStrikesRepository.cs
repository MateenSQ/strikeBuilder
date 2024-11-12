namespace StrikeBuilderMVC.Models
{
    public class MockStrikesRepository : IMockStrikesRepository
    {
        public IEnumerable<Strike> AllStrikes => new List<Strike> 
        {
            new Strike {Id = 1, Name="Jab", Description="Lorem Ipsum"},
            new Strike {Id = 2, Name="Cross", Description="Lorem Ipsum"},
            new Strike {Id = 3, Name="Left Hook", Description="Lorem Ipsum"},
            new Strike {Id = 4, Name="Right Hook", Description="Lorem Ipsum"},
            new Strike {Id = 5, Name="Uppercut", Description="Lorem Ipsum"},
            new Strike {Id = 6, Name="Left Round Kick", Description="Lorem Ipsum"},
            new Strike {Id = 7, Name="Right Round Kick", Description="Lorem Ipsum"},
        };

        public List<Strike> GetAllStrikes()
        {
            return AllStrikes.ToList();
        }

        public Strike GetStrikeById(int id)
        {
            return AllStrikes.FirstOrDefault(s => s.Id == id);
        }
    }
}
