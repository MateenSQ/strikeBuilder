using Microsoft.AspNetCore.Mvc;
using StrikeBuilderMVC.Models;
using StrikeBuilderMVC.Services;

namespace StrikeBuilderMVC.Controllers
{
    public class StrikeController : Controller
    {
        private readonly IMockSavedStrikesRepository _mockSavedStrikesRepository;
        private readonly IMockStrikesRepository _mockStrikesRepository;
        private readonly IStrikeService _strikeService;

        public StrikeController(
            IMockSavedStrikesRepository MockSavedStrikesRepository,
            IMockStrikesRepository MockStrikesRepository,
            IStrikeService strikeService
        )
        {
            _mockSavedStrikesRepository = MockSavedStrikesRepository;
            _mockStrikesRepository = MockStrikesRepository;
            _strikeService = strikeService;
        }

        public IActionResult Index()
        {
            List<Strike> allStrikes = _mockSavedStrikesRepository.GetAllSavedStrikes();

            return View(allStrikes);
        }

        public IActionResult Select()
        {
            List<Strike> AllStrikes = _mockStrikesRepository.GetAllStrikes();

            return View(AllStrikes);
        }

        [HttpPost]
        public IActionResult Select(int id)
        {
            _strikeService.AddToSaved(id);

            return Redirect("/Strike/Index");
        }
    }
}
