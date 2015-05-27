using System.Web.Mvc;
using LightpointTestTask.DAL;

namespace LightpointTestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Home
        public ActionResult Index()
        {
            var stores = unitOfWork.StoreRepository.Get();

            return View(stores);
        }

        [HttpGet]
        public ActionResult GetProducts(int id)
        {
            var products = unitOfWork.StoreRepository.GetByID(id).Products;

            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}