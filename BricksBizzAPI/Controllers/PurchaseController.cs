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
            this._productionComponent = productionComponent;
        }

       
        [HttpGet(Name = "GetProducts")]
        public ProductModel GetAllProducts()
        {
            ProductModel model = new ProductModel();
            model.ProductList = _productionComponent.GetAllProduct();
            return model;
        }

        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllProduct()
        {
            return await Task.FromResult(_productionComponent.GetAllProduct());
        }
    }
}
