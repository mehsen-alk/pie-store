using Microsoft.AspNetCore.Mvc;

namespace pie_store.Models
{
    public class PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository) : Controller
    {
        private readonly IPieRepository _pieRepository = pieRepository;
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public IActionResult List(){
            return View(_pieRepository.AllPies);
        }
 
    }
}