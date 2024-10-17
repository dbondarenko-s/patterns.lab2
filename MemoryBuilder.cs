namespace Patterns.Lab2
{
    public class MemoryBuilder : Builder
    {
        private decimal _value;

        private readonly AbstractGOFactory _colorGOFactory;

        public MemoryBuilder()
        {
            _colorGOFactory = new ColorGOFactory();

            _value = 0m;
        }

        public override void BuildCircle()
        {
            var item = _colorGOFactory.CreateCircle();

            _value += GetObjectSize(item);
        }

        public override void BuildLine()
        {
            var item = _colorGOFactory.CreateLine();

            _value += GetObjectSize(item);
        }

        public override void BuildPoint()
        {
            var item = _colorGOFactory.CreatePoint();

            _value += GetObjectSize(item);
        }

        public override void GetResult()
        {
            Console.WriteLine($"Занимает памяти: {_value} байт.");
        }

        private long GetObjectSize(GraphObject item)
        {
            return new Random().Next(100);
        }
    }
}
