namespace Patterns.Lab2
{
    public class TriangleAdapter : GraphObject
    {
        private readonly Triangle _triangle;

        public TriangleAdapter(TriangleAdapter triangle) : this(triangle._triangle.ACoordinates.X, triangle._triangle.ACoordinates.Y, triangle._triangle.BCoordinates.X, triangle._triangle.BCoordinates.Y, triangle._triangle.CCoordinates.X, triangle._triangle.ACoordinates.Y, triangle.Color)
        {
        }

        public TriangleAdapter(int aX, int aY, int bX, int bY, int cX, int cY, string color) : base(color)
        {
            _triangle = new Triangle(new Coordinates(aX, aY), new Coordinates(bX, bY), new Coordinates(cX, cY));
        }

        public override GraphObject Clone()
        {
            return new TriangleAdapter(this);
        }

        public override void Draw()
        {
            Console.WriteLine($"Triangle. Coordinates: A(X={_triangle.ACoordinates.X}, Y={_triangle.ACoordinates.Y}), B(X={_triangle.BCoordinates.X}, Y={_triangle.BCoordinates.Y}), C(X={_triangle.CCoordinates.X}, Y={_triangle.CCoordinates.Y}). Color: {Color}.");
        }
    }
}
