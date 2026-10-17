using CafeteriaApp.Models;

namespace CafeteriaApp.Data
{
    public class OrdersRepo
    {
        private static readonly List<Order> _orders = null;
        public static List<Order> Orders
        {
            get { return _orders; }
        }

        static OrdersRepo()
        {
            _orders =
            [
                new Order(1, "Serhan", "Döner", true, new DateTime(2026, 10, 17, 15, 30, 0)),
                new Order(2, "Serra", "Sarma", false, null),
                new Order(3, "Kumsal", "Hamburger", false, null),
                new Order(4, "Gökay", "Tantuni", true, new DateTime(2026, 10, 17, 16, 23, 0)),
                new Order(5, "Totiç", "İskender", true, new DateTime(2026, 10, 17, 20, 10, 0)),
                new Order(6, "Tolga", "Pilav", true, new DateTime(2026, 10, 17, 18, 02, 0)),
                new Order(7, "Bilal", "Pizza", false, null),
                new Order(8, "Yusuf", "Makarna", false, null),
                new Order(9, "Fevziye", "Çorba", true, new DateTime(2026, 10, 17, 12, 00, 0)),
                new Order(10, "Sıla", "Çorba", true, new DateTime(2026, 10, 17, 12, 01, 0)),
                new Order(11, "Soner", "Börek", false, null),
                new Order(12, "Seray", "Ispanak", false, null),
                new Order(13, "Servet", "Köfte", false, null),
                new Order(14, "Yiğit", "Lahmacun", true, new DateTime(2026, 10, 17, 13, 38, 0)),
                new Order(15, "Melih", "Tavuk", false, null),
                new Order(16, "Doğukan", "Dolma", false, null),
                new Order(17, "Müslüm", "Kebap", false, null),
                new Order(18, "Ezel", "Makarna", false, null),
                new Order(19, "Utku", "Döner", false, null),
                new Order(20, "Gamze", "Çiğ Köfte", true, new DateTime(2026, 10, 17, 10, 43, 0)),
            ];
        }

        public static Order GetById(int id)
        {
            return _orders.FirstOrDefault(o => o.OrderId == id);
        }

        public static void Collect(int id)
        {
            var order = GetById(id);
            if (!order.Collected)
            {
                order.Collected = true;
                order.ColledtedAt = DateTime.Now;
            }
        }
    }
}
