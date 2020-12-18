namespace Matematica.Negocio
{
    internal class Complejo
    {
        private double x;
        private double y;

        public Complejo(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public int Real { get; internal set; }
        public int Imaginaria { get; internal set; }
    }
}