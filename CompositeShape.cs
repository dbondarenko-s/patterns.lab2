namespace Patterns.Lab2
{
    using Newtonsoft.Json;

    public class CompositeShape : GraphObject
    {
        private ICollection<GraphObject> _children;

        public ICollection<GraphObject> GetChildren()
        {
            if (_children == null)
            {
                _children = new List<GraphObject>();
            }

            return _children;
        }

        public override GraphObject Clone()
        {
            return JsonConvert.DeserializeObject<CompositeShape>(JsonConvert.SerializeObject(this));
        }

        public override void Draw()
        {
            foreach (var child in GetChildren())
            {
                child.Draw();
            }
        }
    }
}
