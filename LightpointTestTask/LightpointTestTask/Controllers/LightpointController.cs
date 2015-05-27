using System.Web.Http;
using LightpointTestTask.DAL;

namespace LightpointTestTask.Controllers
{
    public class LightpointController : ApiController
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();



        public IHttpActionResult GetProducts(int id)
        {
            var products = unitOfWork.StoreRepository.GetByID(id).Products;

            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }
    }
}
