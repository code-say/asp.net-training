//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusRouteCollections
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<BusRoute> allRoutes = BusRouteRepository.InitializeRoutes();


//            Console.WriteLine($"Before: There are {allRoutes.Count} routes:");
//            foreach (BusRoute route in allRoutes)
//                Console.WriteLine($"Route: {route}");


//            allRoutes.RemoveAt(2);


//            Console.WriteLine($"\r\nAfter: There are {allRoutes.Count} routes:");
//            foreach (BusRoute route in allRoutes)
//                Console.WriteLine($"Route: {route}");
//        } 
//    }
//}
