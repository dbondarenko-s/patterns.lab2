namespace Patterns.Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractGOFactory factory = new ColorGOFactory();

            var root = factory.CreateRoot();

            factory.CreatePoint(root).SetColor("red");

            factory.CreateTriangle(root).SetColor("green");

            Scene.GetInstance().Add(root, new FillDecorator(new Circle(0, 0, 1, "yellow"), "white"));

            Scene.GetInstance().Draw();

            Scene.GetInstance().Show(new List<(string, string)> { ("point", "red"), ("circle", "brown") });
        }
    }
}
