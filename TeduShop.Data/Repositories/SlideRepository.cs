using TeduShop.Model.Models;
using TeduShop.Data.Infrastructure;

namespace TeduShop.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    {

    }
    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }

}
