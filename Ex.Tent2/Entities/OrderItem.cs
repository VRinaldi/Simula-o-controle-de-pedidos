namespace Ex.Tent2.Entities
{
    class OrderItem
    {
        public Product Productt { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(Product productt, int quantity)
        {
            Productt = productt;
            Quantity = quantity;
        }

        public double Subtotal()
        {
            return Productt.Price * Quantity;
        }

        public override string ToString()
        {
            return Productt.Name
                + ", $"
                + Productt.Price.ToString("F2")
                + ", Quantity: "
                + Quantity
                +", Subtotal: $"
                + Subtotal().ToString("F2");
        }

    }
}
