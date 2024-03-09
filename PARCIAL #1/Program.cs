using System;

class Program
{
    static void Main(string[] args)
    {
        double salariobase = 650000;
        double comisiones = 0.10;
        int meta = 1000000;
        double venta1,venta2,venta3;
        double comisiones1, comisiones2, comisiones3;
        double comisionalta, mayorventa;

        Console.WriteLine("***Venta #1***");
        Console.WriteLine("Escribir el valor en $ de la venta 1:");
        venta1 = Convert.ToDouble(Console.ReadLine);

        Console.WriteLine("***Venta #2***");
        Console.WriteLine("Escribir el valor en $ de la venta 2:");
        venta2 = Convert.ToDouble(Console.ReadLine);

        Console.WriteLine("***Venta #3***");
        Console.WriteLine("Escribir el valor en $ de la venta 3:");
        venta3 = Convert.ToDouble(Console.ReadLine);

        comisiones1 = venta1 * comisiones;
        comisiones2 = venta2 * comisiones;
        comisiones3 = venta3 * comisiones;


        if (comisiones1>comisionalta)
        {
            comisionalta = comisiones1;
            mayorventa = venta1;
        }
        if (comisiones2>comisionalta)
        {
            comisionalta = comisiones2;
            mayorventa = venta2;
        }
        if (comisiones3 > comisionalta)
        {
            comisionalta = comisiones3;
            mayorventa = venta3;
        }
        double comisionestotales = comisiones1 + comisiones2 + comisiones3;

    }
}
