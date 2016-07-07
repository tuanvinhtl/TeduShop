using TeduShop.Model.Models;
using TeduShop.Data.Infrastructure;

namespace TeduShop.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {

    }
    public class TagRepository :RepositoryBase<Tag>,ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
