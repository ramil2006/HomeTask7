namespace HomeTask
{


    internal class Square : Figure
    {
        private double side { get; set; }


        public Square(double Side)
        {
            if (Side < 0)
            {
                Console.WriteLine("teref menfi ola bilmez");
            }
            else
            {
                side = Side;
            }
        }

             public override double CalcArea()
             {
            return side* side;
             }
    }
    

}
