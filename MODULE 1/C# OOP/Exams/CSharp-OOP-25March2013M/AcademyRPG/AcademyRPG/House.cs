namespace AcademyRPG
{
    public class House : StaticObject, IWorldObject
    {
        public House(Point position, int owner = 0) : base(position, owner)
        {
            this.HitPoints = 500;
        }
    }
}
