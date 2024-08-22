using HomeTask;

Console.WriteLine("Istifade etmek istediyiniz emeliyyati secin");
Console.WriteLine("1.Square");
Console.WriteLine("2. Rectangular");
Console.WriteLine("0. Quit");
double num=Convert.ToDouble(Console.ReadLine());
if (num == 0)
{
    Console.WriteLine("Cixis edildi");
}
else if (num == 1)
{
    Console.WriteLine("Side daxil edin: ");
    double Sid = Convert.ToDouble(Console.ReadLine());

    Square square1 =new Square(Sid);
    Console.WriteLine(square1.CalcArea());
}
else if (num == 2)
{
    Console.WriteLine("Width daxil edin: ");
    double Wid = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Length daxil edin:");
    double Len = Convert.ToDouble(Console.ReadLine());
    Rectangular rectangular = new Rectangular(Wid, Len);
    Console.WriteLine(rectangular.CalcArea());
}
