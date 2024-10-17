namespace Patterns.Lab2
{
    public class Triangle
    {
        public Coordinates ACoordinates { get; private set; }

        public Coordinates BCoordinates { get; private set; }

        public Coordinates CCoordinates { get; private set; }

        public Triangle(Coordinates aCoordinates, Coordinates bCoordinates, Coordinates cCoordinates)
        {
            ACoordinates = aCoordinates;
            BCoordinates = bCoordinates;
            CCoordinates = cCoordinates;
        }
    }
}
