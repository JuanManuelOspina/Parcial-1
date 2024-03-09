using System;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        double salidatren1 = 10.0;
        double velotren1 = 80.0;
        double salidatren2=11.0;
        double velotren2=100.0;
        double distanciatren1, alcanzartren1, hora;

        distanciatren1 = velotren1 * (salidatren2 - salidatren1);
        alcanzartren1 = distanciatren1 / (velotren2 - velotren1);
        hora = salidatren2 + alcanzartren1;

        Console.WriteLine("El tren alcanzará al otro a las "+ hora.ToString("0.00")+"horas");
    }
}
