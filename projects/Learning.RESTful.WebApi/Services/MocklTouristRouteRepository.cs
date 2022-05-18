using Learning.RESTful.WebApi.Models;

namespace Learning.RESTful.WebApi.Services
{
    public class MocklTouristRouteRepository : ITouristRouteRepository
    {
        private List<TouristRoute>  _routes;
        public MocklTouristRouteRepository()
        {
            _routes=new List<TouristRoute>();
            InitializeTouristRoutes();
        }
        public TouristRoute GetTouristRoute(Guid id)
        {
            return _routes.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _routes;
        }

        private void InitializeTouristRoutes() 
        {
            _routes.Add(new TouristRoute
            {
                Id = Guid.NewGuid(),
                Title = "西湖",
                Description = "上有天堂，下有苏杭。",
                OriginalPrice = 299,
                Features = "吃住行",
                Fees = "交通费自理",
                Nodes = "注意保暖"
            });

            _routes.Add(new TouristRoute
            {
                Id = Guid.NewGuid(),
                Title = "宋城",
                Description = "千古宋城情",
                OriginalPrice = 699,
                Features = "吃住行",
                Fees = "无",
                Nodes = "注意保暖"
            });
        }
    }
}
