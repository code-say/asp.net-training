using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCollections
{
    class BusRouteRepository
    {
        public static BusRoute[] InitializeRoutes()
        {
            return new BusRoute[]
            {
                new BusRoute(40, "MoreCambe", "Preston"),
                new BusRoute(42, "Lancaster", "Blackpool"),
                new BusRoute(100, "University", "MoreCambe"),
                new BusRoute(555, "Lancaster", "Keswick")
            };
        }
    }
}
