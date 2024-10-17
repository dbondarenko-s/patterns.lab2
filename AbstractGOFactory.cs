namespace Patterns.Lab2
{
    public abstract class AbstractGOFactory
    {
        public abstract Point CreatePoint(CompositeShape parent);

        public abstract Circle CreateCircle(CompositeShape parent);

        public abstract Line CreateLine(CompositeShape parent);

        public abstract TriangleAdapter CreateTriangle(CompositeShape parent);

        public abstract CompositeShape CreateRoot();

        public abstract CompositeShape CreateContainer(CompositeShape parent);
    }
}
