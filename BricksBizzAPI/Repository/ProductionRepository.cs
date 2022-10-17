using BricksBizzAPI.Model;

namespace BricksBizzAPI.Repository
{
    public class ProductionRepository : IProductionRepository
    {
        public List<ProductDTO> GetAllProduct()
        {
            

            List<ProductDTO> products = new List<ProductDTO>();

            ProductDTO product = new ProductDTO()
            {
                OrderId =1001,
                ProductName="Coal",
                qty=10
            };

            ProductDTO product1 = new ProductDTO()
            {
                OrderId = 1002,
                ProductName = "Soil",
                qty = 10
            };
            products.Add(product);
            products.Add(product1);

            return products;
        }
    }
}
