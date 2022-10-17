using BricksBizzAPI.Model;

namespace BricksBizzAPI.Repository
{
    public interface IProductionRepository
    {
        public List<ProductDTO> GetAllProduct();
    }
}
