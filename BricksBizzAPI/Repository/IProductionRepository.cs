using BricksBizzAPI.Model;

namespace BricksBizzAPI.Repository
{
    public interface IProductionRepository
    {
        Task<List<ProductDTO>> GetAllProduct();
    }
}
