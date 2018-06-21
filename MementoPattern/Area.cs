using System;

namespace MementoPattern
{
    public class Area
    {
        public string AreaName { get; set; }
        public string Lng { get; set; }
        public string Lat { get; set; }
        public string CreateTime { get; set; }

        public void Save(string name)
        {
            Caretaker<AreaMemento>.SaveArea(name, new AreaMemento(this.AreaName,this.Lng,this.Lat,this.CreateTime));
        }
        public Area ReLoad(string name)
        {
            var memento = Caretaker<AreaMemento>.ResolveArea(name);
            this.AreaName = memento.AreaName;
            this.Lng = memento.Lng;
            this.Lat = memento.Lat;
            this.CreateTime = memento.CreateTime;
            return this;
        }
    }
}
