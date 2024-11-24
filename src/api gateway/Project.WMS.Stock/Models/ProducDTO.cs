namespace Project.WMS.Stock.Models
{
    public record ProductDTO (string name, string description, decimal price, DateTime Created, DateTime? Disabled);
}
