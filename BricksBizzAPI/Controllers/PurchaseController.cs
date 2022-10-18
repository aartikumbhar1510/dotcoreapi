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
        public IProductionRepository _productionRepository;
        public PurchaseController(IProductionRepository productionRepository)
        {
            _productionRepository = productionRepository;
        }

        [HttpGet]
        [Route("getallproduct")]
        public async Task<CustomeResponse> GetAllProducts()
        {
            CustomeResponse response = new CustomeResponse();
            response.Response = await _productionRepository.GetAllProduct();
            return response;
        }

        [HttpGet]
        [Route("getproductbyid")]
        public async Task<CustomeResponse> GetProductByOrderId(int OrderId)
        {
            CustomeResponse response = new CustomeResponse();
             response.Response = await _productionRepository.GetProductByCode(OrderId);
            return response;
        }
    }
}
