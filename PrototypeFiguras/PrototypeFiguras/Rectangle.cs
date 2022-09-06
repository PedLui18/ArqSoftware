namespace PrototypeFiguras
{
    public class Rectangle : Shape
    {
        public int width;
        public int height;

        public Rectangle(Rectangle rectangle) : base(rectangle)
        {
            this.y = rectangle.y;
            this.x = rectangle.x;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}