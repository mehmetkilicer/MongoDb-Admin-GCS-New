using MongoDbEgitim.Dtos.CategoryDtos;
using MongoDbEgitim.Dtos.ProductDtos;

namespace MongoDbEgitim.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createUpdateDto);
        Task UpdateProductAsync(UpdateProductDto updateUpdateDto);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
        Task<List<ResultProductWithCategoryDto>> GetProductWithCategoryAsync();
        Task<List<ResultProductWithCategoryDto>> GetProductWithCategoryExcelListAsync();
    }
}
