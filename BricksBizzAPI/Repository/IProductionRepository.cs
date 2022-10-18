using BricksBizzAPI.Model;

namespace BricksBizzAPI.Repository
{
    public interface IProductionRepository
    {
        Task<List<ProductDTO>> GetAllProduct();
        Task<ProductDTO> GetProductByCode(int OrderId);
    }
}
