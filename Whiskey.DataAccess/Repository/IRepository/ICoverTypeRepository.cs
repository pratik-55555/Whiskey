using Whiskey.Models;

namespace Whiskey.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : Repository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
