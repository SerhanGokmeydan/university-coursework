using System.ComponentModel.DataAnnotations;
using CafeteriaApp.Data;

namespace CafeteriaApp.Attributes
{
    public sealed class OrderIdAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is not int orderId)
            {
                return true;
            }

            var order = OrdersRepo.GetById(orderId);

            if (order == null)
            {
                return true;
            }

            return !order.Collected;
        }
    }
}
