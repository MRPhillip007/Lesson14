using AbstractHw;

internal interface IOrder
{
    public int Id { get; set; }
    public List<Product> Products { get; set; }
    public int Price { get; }
    public Client OrderFrom { get; set; }
    public DateTime OrderDate { get; set; }
}

