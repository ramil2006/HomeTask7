namespace HomeTask
{
    internal class Rectangular: Figure
    {
        private double Width { get; set; }
        private double Length { get; set; }

        public Rectangular(double width, double length)
        {
            if (width < 0 || length<0)
            {
                Console.WriteLine("teref menfi ola bilmez");
            }
            else
            {
                Width = width;
                Length = length;
            }
        }

        public override double CalcArea()
        {
            return Width * Length;
        }
    }
}
