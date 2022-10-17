using BricksBizzAPI.Model;
using BricksBizzAPI.Repository;

namespace BricksBizzAPI.Component
{
    public class ProductionComponent : IProductionComponent
    {

        public IProductionRepository _productionRepository;
        public ProductionComponent(IProductionRepository productionRepository)
        {
            this._productionRepository = productionRepository;
        }


        
        public List<ProductDTO> GetAllProduct()
        {
            List<ProductDTO> products = new List<ProductDTO>();
            products = _productionRepository.GetAllProduct();
            return products;
        }
    }
}
