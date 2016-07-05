using TeduShop.Data.Infrastructure;

namespace TeduShop.Data.Repositories
{
    public interface IMenuRepository
    {
        //add something Method
    }
    public class MenuRepository: RepositoryBase<MenuRepository>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}
