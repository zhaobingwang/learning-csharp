using Learning.RESTful.WebApi.Data;
using Learning.RESTful.WebApi.Models;

namespace Learning.RESTful.WebApi.Services
{
    public class TouristRouteRepository : ITouristRouteRepository
    {
        private readonly AppDbContext _appDbContext;

        public TouristRouteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public TouristRoute GetTouristRoute(Guid id)
        {
            return _appDbContext.TouristRoutes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _appDbContext.TouristRoutes;
        }
    }
}
