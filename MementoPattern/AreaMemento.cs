using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class AreaMemento
    {
        public AreaMemento(string areaName, string lng, string lat, string createTime)
        {
            AreaName = areaName;
            Lng = lng;
            Lat = lat;
            CreateTime = createTime;
        }

        public string AreaName { get; set; }
        public string Lng { get; set; }
        public string Lat { get; set; }
        public string CreateTime { get; set; }
    }
}
