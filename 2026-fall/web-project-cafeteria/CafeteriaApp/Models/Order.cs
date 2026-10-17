using System.ComponentModel.DataAnnotations;
using CafeteriaApp.Attributes;

namespace CafeteriaApp.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Order id must be filled !")]
        [Range(1, 20, ErrorMessage = "Order id must be between 1 and 20 !")]
        [OrderId(ErrorMessage = "This order id is already collected !")]
        public int? OrderId { get; set; }
        public string? StudentName { get; set; }
        public string? MealName { get; set; }
        public bool Collected { get; set; }
        public DateTime? ColledtedAt { get; set; }

        public Order() { }

        public Order(
            int? orderId,
            string studentName,
            string mealName,
            bool collected,
            DateTime? collectedAt
        )
        {
            OrderId = orderId;
            StudentName = studentName;
            MealName = mealName;
            Collected = collected;
            ColledtedAt = collectedAt;
        }
    }
}
