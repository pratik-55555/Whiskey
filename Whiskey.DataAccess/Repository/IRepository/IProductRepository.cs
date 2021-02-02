using Whiskey.Models;

namespace Whiskey.DataAccess.Repository.IRepository
{
    public interface IProductRepository : Repository<Product>
    {
        void Update(Product product);
    }
}
