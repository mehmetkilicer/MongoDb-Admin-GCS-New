using MongoDbEgitim.Dtos.OrderDtos;

namespace MongoDbEgitim.Services.OrderServices
{
    public interface IOrderService
    {
        Task<List<ResultOrderDto>> GetAllOrderAsync();
        Task CreateOrderAsync(CreateOrderDto createOrderDto);
        Task UpdateOrderAsync(UpdateOrderDto updateOrderDto);
        Task DeleteOrderAsync(string id);
        Task<GetByIdOrderDto> GetByIdOrderAsync(string id);
        Task<List<ResultOrderWithCustomerAndProductDto>> GetOrderWithCustomerAndProductAsync();
    }
}
