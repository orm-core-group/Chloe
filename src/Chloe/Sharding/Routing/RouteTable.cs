﻿namespace Chloe.Sharding.Routing
{
    public class RouteTable
    {
        public string Name { get; set; }
        public string Schema { get; set; }
        public RouteDataSource DataSource { get; set; }
    }
}