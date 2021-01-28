using Whiskey.Models;

namespace Whiskey.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : Repository<Category>
    {
        void Update(Category category);
    }
}
