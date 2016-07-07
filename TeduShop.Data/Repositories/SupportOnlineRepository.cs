using TeduShop.Model.Models;
using TeduShop.Data.Infrastructure;
namespace TeduShop.Data.Repositories
{
    public interface ISupportOnlineRepository : IRepository<SupportOnline>
    {

    }
    public class SupportOnlineRepository :RepositoryBase<SupportOnline>,ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
