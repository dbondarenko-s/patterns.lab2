namespace Patterns.Lab2
{
    public class ConcreteBuilder : Builder
    {
        private readonly AbstractGOFactory _colorGOFactory;

        private readonly AbstractGOFactory _monochromeGOFactory;

        public ConcreteBuilder()
        {
            _colorGOFactory = new ColorGOFactory();

            _monochromeGOFactory = new MonochromeGOFactory();
        }

        public override void BuildCircle()
        {
            _colorGOFactory.CreateCircle();
        }

        public override void BuildLine()
        {
            _monochromeGOFactory.CreateLine();
        }

        public override void BuildPoint()
        {
            _colorGOFactory.CreatePoint();
        }

        public override void GetResult()
        {
            Scene.GetInstance().Draw();
        }
    }
}
