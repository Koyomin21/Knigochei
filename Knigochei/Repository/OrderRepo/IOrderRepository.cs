using Knigochei.Models;


namespace Knigochei.Repository.OrderRepo
{
	public interface IOrderRepository
	{
		public void CreateOrder(Order order);
		public IEnumerable<Order> All();
		public void AddOrderItems(List<OrderItem> orderItems);
		public IEnumerable<Order> GetOrdersByUserId(int userId);
	}
}
