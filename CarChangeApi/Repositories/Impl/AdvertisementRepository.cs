using CarChangeApi.Domain.DatabaseContext;
using CarChangeApi.Domain.Models;

namespace CarChangeApi.Repositories.Impl
{
    public class AdvertisementRepository : GenericRepository<Advertisement>, IAdvertisementRepository
    {
        public AdvertisementRepository(MyDBContext context) : base(context)
        {
        }
    }
}
