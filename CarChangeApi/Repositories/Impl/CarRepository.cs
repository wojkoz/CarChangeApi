using CarChangeApi.Domain.DatabaseContext;
using CarChangeApi.Domain.Models;

namespace CarChangeApi.Repositories.Impl
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(MyDBContext context) : base(context)
        {
        }
    }
}
