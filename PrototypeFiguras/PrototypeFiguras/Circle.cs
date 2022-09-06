namespace PrototypeFiguras
{
    public class Circle : Shape
    {
        public int radius;

        public Circle(Circle circle) : base(circle)
        {

            this.radius = circle.radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}