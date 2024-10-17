namespace Patterns.Lab2
{
    public class ColorGOFactory : AbstractGOFactory
    {
        private Point _defaultPoint = new Point(0, 0);

        public override Circle CreateCircle(CompositeShape parent)
        {
            var item = new Circle(0, 0, 1);

            item.SetColor("Green");

            OnCreate(parent, item);

            return item;
        }

        public override Line CreateLine(CompositeShape parent)
        {
            var item = new Line(0, 0, 1, 1);

            item.SetColor("Red");

            OnCreate(parent, item);

            return item;
        }

        public override Point CreatePoint(CompositeShape parent)
        {
            var item = _defaultPoint.Clone();

            item.SetColor("Yellow");

            OnCreate(parent, item);

            return item;
        }


        public override TriangleAdapter CreateTriangle(CompositeShape parent)
        {
            var item = new TriangleAdapter(0, 0, 1, 1, 1, 0, GraphObject.DefaultColor);

            OnCreate(parent, item);

            return item;
        }

        public override CompositeShape CreateRoot()
        {
            var item = new CompositeShape();

            OnCreate(null, item);

            return item;
        }

        public override CompositeShape CreateContainer(CompositeShape parent)
        {
            var item = new CompositeShape();

            OnCreate(parent, item);

            return item;
        }

        protected void OnCreate(CompositeShape parent, GraphObject item)
        {
            // if(item.Color.Equals(GraphObject.DefaultColor) == false)
            // {
                Scene.GetInstance().Add(parent, item);
            // }
        }
    }
}
