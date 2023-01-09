using MyBlock.mvc.Interface;
using MyBlock.mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyBlock.mvc.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBlockInterface _blockInterface;

        public AdminController(IBlockInterface blockInterface)
        {
            _blockInterface = blockInterface;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var allBlock = _blockInterface.GetAllBlocks();
            return View(allBlock);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Block block)
        {
            _blockInterface.AddBlock(block);
            return RedirectToAction("index");
        }
    }
}
