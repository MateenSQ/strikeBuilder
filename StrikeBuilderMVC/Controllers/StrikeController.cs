using Microsoft.AspNetCore.Mvc;
using StrikeBuilderMVC.Models;

namespace StrikeBuilderMVC.Controllers
{
    public class StrikeController : Controller
    {
        private readonly IMockSavedStrikesRepository _mockSavedStrikesRepository;
        private readonly IMockStrikesRepository _mockStrikesRepository;

        public StrikeController(
            IMockSavedStrikesRepository MockSavedStrikesRepository,
            IMockStrikesRepository MockStrikesRepository
        )
        {
            _mockSavedStrikesRepository = MockSavedStrikesRepository;
            _mockStrikesRepository = MockStrikesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Select()
        {
            return View();
        }
    }
}
