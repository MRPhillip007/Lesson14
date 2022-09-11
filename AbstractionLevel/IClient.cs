
using AbstractHw;

internal interface IClient
{
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Order> Orders { get; set; }
}

