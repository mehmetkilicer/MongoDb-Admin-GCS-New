using AutoMapper;
using MongoDB.Driver;
using MongoDbEgitim.Dtos.ProductDtos;
using MongoDbEgitim.Entities;
using MongoDbEgitim.Settings;

namespace MongoDbEgitim.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;
        public ProductService(IMapper mapper, IDatabaseSetting _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }
        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var value = _mapper.Map<Product>(createProductDto);
            await _productCollection.InsertOneAsync(value);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(x => x.ProductId == id);
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            var values = await _productCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task<GetByIdProductDto> GetByIdProductAsync(string id)
        {
            var value = await _productCollection.Find<Product>(x => x.ProductId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductDto>(value);
        }

        public async Task<List<ResultProductWithCategoryDto>> GetProductWithCategoryAsync()
        {
            var value = await _productCollection.Find(x => true).ToListAsync();
            foreach (var item in value)
            {
                item.Category = await _categoryCollection.Find(x => x.CategoryId == item.CategoryId).FirstAsync();
            }
            return _mapper.Map<List<ResultProductWithCategoryDto>>(value);
        }

        public async Task<List<ResultProductWithCategoryDto>> GetProductWithCategoryExcelListAsync()
        {
            var value = await _productCollection.Find(x => true).ToListAsync();
            foreach (var item in value)
            {
                item.Category = await _categoryCollection.Find(x => x.CategoryId == item.CategoryId).FirstAsync();
            }
            return _mapper.Map<List<ResultProductWithCategoryDto>>(value);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateUpdateDto)
        {
            var values = _mapper.Map<Product>(updateUpdateDto);
            await _productCollection.FindOneAndReplaceAsync(x => x.ProductId == updateUpdateDto.ProductId, values);
        }
    }
}
