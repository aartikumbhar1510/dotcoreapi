using BricksBizzAPI.Component;
using BricksBizzAPI.Model;
using BricksBizzAPI.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BricksBizzAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        public IProductionComponent _productionComponent;
        public PurchaseController(IProductionComponent productionComponent)
        {
            _productionComponent = productionComponent;
        }

        [HttpGet]
        [Route("getallproduct")]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = _productionComponent.GetAllProduct();
            return Ok(result);
        }
    }
}
