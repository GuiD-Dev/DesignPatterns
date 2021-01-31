namespace DesignPatterns.Factory
{
    public interface IShape
    {
        void area(params double[] args);
        void draw();
    }
}