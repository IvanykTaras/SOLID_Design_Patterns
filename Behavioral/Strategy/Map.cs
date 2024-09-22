using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.Strategy
{
    public class Map : IRouteStrategy
    {
        private IRouteStrategy _routeStrategy;
        public Map(IRouteStrategy strategy) => _routeStrategy = strategy;
        public void CreateRoute(Coordinate start, Coordinate end) => _routeStrategy.CreateRoute(start, end);
    }
}
