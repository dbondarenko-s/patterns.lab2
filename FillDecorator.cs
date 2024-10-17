namespace Patterns.Lab2
{
    using Newtonsoft.Json;

    public class FillDecorator : GraphObject
    {
        private readonly GraphObject _graphObject;

        private string _color;

        public FillDecorator(GraphObject graphObject, string color) : base(color)
        {
            _graphObject = graphObject;
            _color = color;
        }

        public override GraphObject Clone()
        {
            return JsonConvert.DeserializeObject<CompositeShape>(JsonConvert.SerializeObject(this));
        }

        public override void Draw()
        {
            _graphObject.Draw();

            if(_color != null)
            {
                Console.WriteLine($"Выполнена заливка объекта {_color} цветом.");
            }
        }
    }
}
