using MongoDbEgitim.Dtos.CustomerDtos;

namespace MongoDbEgitim.Services.CustomerServices
{
    public interface ICustomerService
    {
        Task<List<ResultCustomerDto>> GetAllCustomerAsync();
        Task CreateCustomerAsync(CreateCustomerDto createUpdateDto);
        Task UpdateCustomerAsync(UpdateCustomerDto updateUpdateDto);
        Task DeleteCustomerAsync(string id);
        Task<GetByIdCustomerDto> GetByIdCustomerAsync(string id);
    }
}
