namespace PrototypeFiguras
{
    public abstract class Shape
    {
        public int x;
        public int y;
        public string color;

        public Shape(Shape carga )
        {
            carga.x = x;
            carga.y = y;
            carga.color = color;
        }

        public abstract Shape Clone();
    }
}