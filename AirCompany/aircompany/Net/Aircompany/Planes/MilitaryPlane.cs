using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        private MilitaryType militaryType;

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType militaryType)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            this.militaryType = militaryType;
        }

        public override bool Equals(object obj)
        {
            var militaryPlane = obj as MilitaryPlane;
            return militaryPlane != null &&
                   base.Equals(obj) &&
                   this.militaryType == militaryPlane.militaryType;
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + militaryType.GetHashCode();
            return hashCode;
        }

        public MilitaryType GetPlaneType()
        {
            return militaryType;
        }


        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + militaryType +
                    '}');
        }        
    }
}
