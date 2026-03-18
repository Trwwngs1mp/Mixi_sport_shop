namespace BackEnd.Models
{
    public class CartItem
    {
        public Product Product { get; set; } = new Product();

        public int Quantity { get; set; }

        // Tính tổng tiền từng sản phẩm
        public int TotalPrice => Product.Price * Quantity;
    }
}