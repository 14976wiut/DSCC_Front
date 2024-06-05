namespace DSCC_Front.DTO
{
    public class OrderUpdateDto
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
    }
}
