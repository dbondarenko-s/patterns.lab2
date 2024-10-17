
namespace Patterns.Lab2
{
    public class Scene : ISceneFacade
    {
        private GraphObject _root;

        private static Scene _instance;

        private Scene()
        {
        }

        public static Scene GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Scene();
            }
                
            return _instance;
        }

        public void Add(CompositeShape parent, GraphObject obj)
        {
            if (parent == null && _root is CompositeShape)
            {
                parent = (CompositeShape)_root;
            }

            if (parent == null)
            {
                _root = obj;
            }
            else
            {
                parent.GetChildren().Add(obj);
            }
        }

        public void Clear() => _root = null;

        public void SetRoot(GraphObject graphObject)
        {
            _root = graphObject;
        }

        public GraphObject GetRoot()
        {
            return _root;
        }

        public void Draw()
        {
            if( _root != null)
            {
                _root.Draw();
            }
        }

        public void Show(IEnumerable<(string, string)> elements)
        {
            _root = new CompositeShape();

            var random = new Random();

            foreach (var element in elements)
            {
                switch (element.Item1)
                {
                    case "point":
                        Add((CompositeShape)_root, new Point(random.Next(), random.Next(), element.Item2));
                        break;

                    case "circle":
                        Add((CompositeShape)_root, new Circle(random.Next(), random.Next(), random.Next(), element.Item2));
                        break;

                    case "line":
                        Add((CompositeShape)_root, new Line(random.Next(), random.Next(), random.Next(), random.Next(), element.Item2));
                        break;

                    case "triangle":
                        Add((CompositeShape)_root, new TriangleAdapter(random.Next(), random.Next(), random.Next(), random.Next(), random.Next(), random.Next(), element.Item2));
                        break;
                }
            }

            Draw();
        }
    }
}
