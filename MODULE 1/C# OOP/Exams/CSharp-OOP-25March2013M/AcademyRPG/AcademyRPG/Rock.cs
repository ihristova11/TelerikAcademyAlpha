namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        public Rock(int hitPoints, Point position, int owner = 0) : base(position, 0)
        {
            this.HitPoints = hitPoints;
            this.Type = ResourceType.Stone;
            this.Quantity = this.HitPoints / 2;
        }

        public int Quantity { get; }
        public ResourceType Type { get; }
    }
}
