namespace MarketPlace.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
