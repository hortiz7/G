using System;
using System.IO;
using G1000Rx;

namespace GarminDataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProyectRoute = "/home/corleone/Documentos/Garmin/G";
            string Name = "CaravanAttributes.mdf";
            string fileName = Path.Combine(ProyectRoute, Name);

            byte[]? data = null;

            try
            {
                data = FileReader.ReadFile(fileName);
                DataProcessor.processData(data);
                DataPrinter.PrintData();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}

