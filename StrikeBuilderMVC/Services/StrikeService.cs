
using StrikeBuilderMVC.Models;

namespace StrikeBuilderMVC.Services
{
    public class StrikeService : IStrikeService
    {
        private readonly IMockSavedStrikesRepository _mockSavedStrikesRepository;
        private readonly IMockStrikesRepository _mockStrikesRepository;

        public StrikeService(IMockSavedStrikesRepository MockSavedStrikesRepository, IMockStrikesRepository MockStrikesRepository) 
        {
            _mockSavedStrikesRepository = MockSavedStrikesRepository;
            _mockStrikesRepository = MockStrikesRepository;
        }

        public int AddToSaved(int id) 
        {
            /*
            1. With id, get the corresponding strike from all strikes
            2. Check the saved strikes repository and find the strike with the highest order.
            3. Increment the value of the highest order and add it to the order field of the found strike (from the id)
            4. Insert the strike into the saved strikes repo
             */

            return 1;
        }
    }
}
