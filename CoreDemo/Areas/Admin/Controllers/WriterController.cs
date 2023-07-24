using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class WriterController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }
        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id= 1,
                Name = "Ayşe"
            },
            new WriterClass
            {
                Id= 2,
                Name = "Ahmet"
            },
            new WriterClass
            {
                Id= 3,
                Name = "Mehmet"
            }
        };
    }
}
