using G1000Rx;

namespace GarminDataProcessor
{
    static class DataProcessor
    {
        public static void processData(byte[] data)
        {
            int offset = 0;
            while (offset < data.Length)
            {
                byte[] parameterData = new byte[24]; 
                string parameterSource = "172.16.0.2";

                Array.Copy(data, offset, parameterData, 0, 24);//Se copian 24 bytes
                offset += 24;

                int dataSize = BitConverter.ToInt32(parameterData, 4); // Tamaño de los datos almacenado en el encabezado
                byte[] deviceData = new byte[dataSize]; //reservar un espacio para datos que se extraerán de los bytes leídos
                Array.Copy(data, offset, deviceData, 0, dataSize); 
                offset += dataSize;

                short result = Garmin_reciever.readGarminData(parameterData, parameterSource);     
                 Console.WriteLine(result); 
            }
        }
    }
}


