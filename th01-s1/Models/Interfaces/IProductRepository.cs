namespace th01_s1.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProducts();
        Product GetProductDetail(int id);
    }
}
