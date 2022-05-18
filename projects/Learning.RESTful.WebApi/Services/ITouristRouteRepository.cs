using Learning.RESTful.WebApi.Models;

namespace Learning.RESTful.WebApi.Services
{
    public interface ITouristRouteRepository
    {
        IEnumerable<TouristRoute> GetTouristRoutes();
        TouristRoute GetTouristRoute(Guid id);
    }
}
