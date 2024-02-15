public class Calculo_area_circulo
{
    static void Main(string[] args)
    {
        double radius, area;
        string data_of_radius;

        do
        {
            Console.WriteLine("Enter the radius of the circle:");
            data_of_radius = Console.ReadLine();
        }
        while (!double.TryParse(data_of_radius, out radius));
        radius = Convert.ToDouble(data_of_radius);

        area= Math.PI * radius;

        Console.WriteLine("The area of the circle is " + area);


        Console.WriteLine("");

    }
}