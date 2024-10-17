namespace Patterns.Lab2
{
    public class Director
    {
        private readonly Builder _builder;

        public Director(Builder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildPoint();
            _builder.BuildLine();
            _builder.BuildCircle();
        }
    }
}
