namespace Patterns.Lab2
{
    public class Scene
    {
        private ICollection<GraphObject> _objects;

        private static Scene _instance;

        private Scene()
        {
            _objects = new HashSet<GraphObject>();
        }

        public static Scene GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Scene();
            }
                
            return _instance;
        }

        public void Add(GraphObject obj)
        {
            _objects.Add(obj);
        }

        public void Clear()
        {
            _objects.Clear();
        }

        public void Draw()
        {
            foreach (GraphObject obj in _objects)
            {
                obj.Draw();
            }
        }
    }
}
