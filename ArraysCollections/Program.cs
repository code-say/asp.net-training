using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute[] allRoutes = BusRouteRepository.InitializeRoutes();
            Console.WriteLine("Where do you want to goto ?");

            string location = Console.ReadLine();
            BusRoute route = FindBusTo(allRoutes, location);

            if(route != null)
                Console.WriteLine($"You can use route {route}");

            else
                Console.WriteLine($"No routes go to {location}");
        }

        public static BusRoute FindBusTo(BusRoute[] routes, string location)
        {
            return Array.Find(routes,
                route => route.Origin == location || route.Destination == location);

            //foreach(BusRoute route in routes)
            //{
            //    if (route.Origin == location || route.Destination == location)
            //        return route;
            //}
            //return null;
            //Console.ReadKey();
        }
    }
}
